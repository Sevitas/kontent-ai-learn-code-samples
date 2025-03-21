// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import kontent.ai.delivery.*;

// Initializes a DeliveryClient
DeliveryClient client = new DeliveryClient("KONTENT_AI_ENVIRONMENT_ID");

// Tip: Create strongly typed models according to https://kontent.ai/learn/net-strong-types
// Registers the model class for articles
client.registerType(Article.class);

// Gets all articles
CompletionStage<List<Article>> items = client.getItems(
    Article.class, 
    DeliveryParameterBuilder.params()
        .filterEquals("system.type", "article")
        .build();
);
