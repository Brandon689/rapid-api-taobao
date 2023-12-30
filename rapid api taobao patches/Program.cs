using RestSharp;


//// 20 - day
{
var client = new RestClient("https://taobao-tmall-product-detail.p.rapidapi.com/detail-product?id=726788588467");
var request = new RestRequest();
request.AddHeader("X-RapidAPI-Key", "vLvj7nB6uwmshcYMvFTsQKNfVsvDp1MtrVsjsnthENr5UaRGGj");
request.AddHeader("X-RapidAPI-Host", "taobao-tmall-product-detail.p.rapidapi.com");
RestResponse response = client.Get(request);

    
    File.WriteAllText("C:\\demo\\Butoca API 726788588467.json",
    //File.WriteAllText("C:\\Code2\\June\\rapid api taobao patches\\rapid api taobao patches\\exampleResponses\\Butoca API.json",
    response.Content);
}


//// 20 - day
//{
//    var client = new RestClient("https://taobao-tmall1.p.rapidapi.com/BatchGetItemFullInfo?language=en&itemId=681554651911&TargetAreaCode=110103");
//    var request = new RestRequest();
//    request.AddHeader("X-RapidAPI-Key", "vLvj7nB6uwmshcYMvFTsQKNfVsvDp1MtrVsjsnthENr5UaRGGj");
//    request.AddHeader("X-RapidAPI-Host", "taobao-tmall1.p.rapidapi.com");
//    RestResponse response = client.Get(request);

//    File.WriteAllText("C:\\Code2\\June\\rapid api taobao patches\\rapid api taobao patches\\exampleResponses\\otcommerce.json",
//        response.Content);
//}


//// 10 - day
//{
//    var client = new RestClient("https://taobao-tmall-16881.p.rapidapi.com/api/tkl/item/detail?provider=taobao&id=681554651911");
//    var request = new RestRequest();
//    request.AddHeader("X-RapidAPI-Key", "vLvj7nB6uwmshcYMvFTsQKNfVsvDp1MtrVsjsnthENr5UaRGGj");
//    request.AddHeader("X-RapidAPI-Host", "taobao-tmall-16881.p.rapidapi.com");
//    RestResponse response = client.Get(request);


//    File.WriteAllText("C:\\Code2\\June\\rapid api taobao patches\\rapid api taobao patches\\exampleResponses\\API TAOBAO.json",
//        response.Content);
//}


// 100 - month
{
    //var client = new RestClient("https://taobao-tmall-tao-bao-data-service.p.rapidapi.com/item/itemFullInfo?itemId=%3CREQUIRED%3E");
    //var request = new RestRequest();
    //request.AddHeader("X-RapidAPI-Key", "vLvj7nB6uwmshcYMvFTsQKNfVsvDp1MtrVsjsnthENr5UaRGGj");
    //request.AddHeader("X-RapidAPI-Host", "taobao-tmall-Tao-Bao-data-service.p.rapidapi.com");
    //RestResponse response = client.Get(request);

    //File.WriteAllText("C:\\Code2\\June\\rapid api taobao patches\\rapid api taobao patches\\exampleResponses\\Thammachet Asavathongkul TAOBAO TMALL 1688.json",
    //    response.Content);

    // get seller items
    var client = new RestClient("https://taobao-tmall-tao-bao-data-service.p.rapidapi.com/seller/sellerItems?sellerId=134348404&page=2&isTmall=false");
    var request = new RestRequest();
    request.AddHeader("X-RapidAPI-Key", "vLvj7nB6uwmshcYMvFTsQKNfVsvDp1MtrVsjsnthENr5UaRGGj");
    request.AddHeader("X-RapidAPI-Host", "taobao-tmall-Tao-Bao-data-service.p.rapidapi.com");
    RestResponse response = client.Get(request);

    File.WriteAllText("C:\\Code2\\June\\rapid api taobao patches\\rapid api taobao patches\\exampleResponses\\Thammachet Asavathongkul TAOBAO TMALL 1688 5.json",
     response.Content);
}




//// 20 - month
//{
//    var client = new RestClient("https://taobao-tmall-16882.p.rapidapi.com/item_get?provider=taobao&num_id=681554651911&lang=en&is_promotion=1");
//    var request = new RestRequest();
//    request.AddHeader("X-RapidAPI-Key", "vLvj7nB6uwmshcYMvFTsQKNfVsvDp1MtrVsjsnthENr5UaRGGj");
//    request.AddHeader("X-RapidAPI-Host", "taobao-tmall-16882.p.rapidapi.com");
//    var response = client.Get(request);

//    File.WriteAllText("C:\\Code2\\June\\rapid api taobao patches\\rapid api taobao patches\\exampleResponses\\iamEvara Taobao/Tmall (淘宝) Data Service.json",
//        response.Content);
//}










//using System.Net.Http.Headers;
//var client = new HttpClient();
//var request = new HttpRequestMessage
//{
//    Method = HttpMethod.Get,
//    RequestUri = new Uri("https://taobao-tmall-16882.p.rapidapi.com/item_get?provider=taobao&num_id=689320134694cv&lang=en&is_promotion=1"),
//    Headers =
//    {
//        { "X-RapidAPI-Key", "vLvj7nB6uwmshcYMvFTsQKNfVsvDp1MtrVsjsnthENr5UaRGGj" },
//        { "X-RapidAPI-Host", "taobao-tmall-16882.p.rapidapi.com" },
//    },
//};

//using (var response = await client.SendAsync(request))
//{
//    response.EnsureSuccessStatusCode();
//    var body = await response.Content.ReadAsStringAsync();
//    Console.WriteLine(body);
//    File.WriteAllText("C:\\Code2\\June\\rapid api taobao patches\\rapid api taobao patches\\exampleResponses\\Thammachet Asavathongkul TAOBAO TMALL 1688.json", body);
//}
