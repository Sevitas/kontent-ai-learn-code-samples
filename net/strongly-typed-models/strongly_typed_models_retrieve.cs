// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using Kontent.Ai.Delivery;
using KontentAiModels;

// Tip: Use DI to create Delivery client https://kontent.ai/learn/net-register-client
IDeliveryClient client = DeliveryClientBuilder
      .WithEnvironmentId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
      .Build();

// Gets a content item by codename and maps it to the item's strongly typed model
IDeliveryItemResponse<Homepage> response = await client.GetItemAsync<Homepage>("hello_caas_world");

var homepage = response.Item;
// Use homepage
// Console.WriteLine(homepage.Headline);
