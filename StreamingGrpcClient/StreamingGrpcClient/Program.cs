using Grpc.Core;
using Grpc.Net.Client;
using ProductServices.Streaming.Demo;

namespace StreamingGrpcClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //using var channel = GrpcChannel.ForAddress("https://localhost:7005");
            using var channel = GrpcChannel.ForAddress("https://40.78.194.97:8585");
            var client = new ProductService.ProductServiceClient(channel);

            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("****************************");
                    Console.WriteLine("1. Product Listing");
                    Console.WriteLine("2. Product detail");
                    Console.WriteLine("3. Server Side Streaming");
                    Console.WriteLine("4. Clilent Side streaming");
                    Console.WriteLine("5. Both sides streaming");
                    Console.WriteLine("****************************");
                    Console.ResetColor();
                    var input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            await UnaryGetProductListing(client);
                            break;
                        case "2":
                            await UnaryGetProductDetails(client);
                            break;
                        case "3":
                            await ServerStreaming(client);
                            break;
                        case "4":
                            await ClientStreaming(client);
                            break;
                        case "5":
                            await BothSideStreamingCall(client);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (RpcException ex) when (ex.StatusCode == StatusCode.DataLoss)
                {
                    Console.WriteLine("Data loss error");
                }
                catch (Exception ex) { Console.WriteLine("Unexpected error"); }
            }

            static async Task UnaryGetProductListing(ProductService.ProductServiceClient client)
            {
                try
                {
                    var result = await client.UnaryProductListingAsync(new Google.Protobuf.WellKnownTypes.Empty());
                    foreach (var product in result.Products)
                    {
                        Console.WriteLine($"{product.ProductId}, {product.ProductName}");
                    }
                }
                catch (RpcException rpce1) when (rpce1.StatusCode == StatusCode.DeadlineExceeded)
                {
                    Console.WriteLine("Error: Deadline exceeded");
                }
                catch (RpcException rpce2) when (rpce2.StatusCode == StatusCode.Unknown)
                {
                    Console.WriteLine("Error: Unknown error, {0}", rpce2.Message);
                } catch (Exception e) {  Console.WriteLine(e.Message); }
            }
            static async Task UnaryGetProductDetails(ProductService.ProductServiceClient client)
            {
                Console.WriteLine("\nEnter the Product Id: ");
                var id = Convert.ToInt32(Console.ReadLine());
                var result = await client.UnaryGetProductDetailsAsync(new DetailsInput { ProductId = id });
                
                    Console.WriteLine($"\nDetails: \n{result.ProductId}, {result.ProductName}\n");
                
            }
            static async Task ServerStreaming(ProductService.ProductServiceClient client)
            {
                var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));

                using var streamingCall = client.GetProductListSS(new Google.Protobuf.WellKnownTypes.Empty(), cancellationToken: cts.Token);
                try
                {
                    Console.WriteLine("Product Id\tProduct Name");
                    await foreach (var product in streamingCall.ResponseStream.ReadAllAsync(cancellationToken: cts.Token))
                    {
                        foreach (var p in product.Products)
                        {
                            Console.WriteLine($"{p.ProductId}\t{p.ProductName}");
                        }
                    }
                }
                catch (RpcException ex) when (ex.StatusCode == StatusCode.Cancelled)
                {
                    Console.WriteLine("Stream cancelled");

                }
                catch (Exception e1x)
                {
                    Console.WriteLine("Something happened");
                }
                cts.Dispose();
            }
            static async Task ClientStreaming(ProductService.ProductServiceClient client)
            {
                using var streamingCall = client.GetProductListCS(); 
                Random rnd = new Random();
                var ids = new List<int>();
                for (int i = 0; i<50; i++)
                {
                    ids.Add(rnd.Next(1,77));
                }
                foreach(var c in ids)
                {
                    Console.WriteLine("Requesting details for product {0}", c);
                    await streamingCall.RequestStream.WriteAsync(new DetailsInput { ProductId = c });
                    await Task.Delay(1000);
                };
                Console.WriteLine("Completed streaming requests");
                await streamingCall.RequestStream.CompleteAsync();

                var response = await streamingCall; 

                foreach(var item in response.Products)
                {
                    Console.WriteLine($"Product Id: {item.ProductId}, Name: {item.ProductName}");
                }
                Console.WriteLine();
            }

            static async Task BothSideStreamingCall(ProductService.ProductServiceClient client)
            { 

                using var streamingCall = client.GetProductsBoth();
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in streamingCall.ResponseStream.ReadAllAsync())
                        {
                            Console.WriteLine($"Product Id: {item.ProductId}, Name: {item.ProductName}");
                        }
                    }
                    catch (RpcException rpcs) when (rpcs.StatusCode == StatusCode.Cancelled)
                    {
                        Console.WriteLine("An exception occured. {0}", rpcs.Message);
                    }
                    catch (Exception e) { Console.WriteLine("An exception occured. {0}", e.Message); }
                    
                });
                Random rnd = new Random();
                var ids = new List<int>();
                for (int i = 0; i < 50; i++)
                {
                    ids.Add(rnd.Next(1, 77));
                }
               foreach(var c in ids)
                {
                    Console.WriteLine("Requesting details for product {0}", c);
                    await streamingCall.RequestStream.WriteAsync(new DetailsInput { ProductId = c });
                    await Task.Delay(1000);
                };
                Console.WriteLine("Request stream is completing");
                await streamingCall.RequestStream.CompleteAsync();
                Console.WriteLine("Request stream is completed.");
            }
        }
    }
}
