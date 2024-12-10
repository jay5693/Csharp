using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpClient2
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 비동기 메서드를 동기적으로 호출
            MainAsync(args).GetAwaiter().GetResult();
            Console.ReadKey();
        }

        public static async Task MainAsync(string[] args)
        {
            using (HttpClient client = new HttpClient())
            {
                string baseUrl = "https://jsonplaceholder.typicode.com/posts";

                try
                {
                    // GET 요청
                    Console.WriteLine("GET 요청 결과:");
                    await GetRequest(client, baseUrl);

                    // POST 요청
                    Console.WriteLine("\nPOST 요청 결과:");
                    await PostRequest(client, baseUrl);

                    // PUT 요청
                    Console.WriteLine("\nPUT 요청 결과:");
                    await PutRequest(client, baseUrl + "/1"); // ID가 1인 리소스를 업데이트
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private static async Task GetRequest(HttpClient client, string url)
        {
            string filteredUrl = url + "?id=1"; // 특정 id 필터링
            HttpResponseMessage response = await client.GetAsync(filteredUrl);
            response.EnsureSuccessStatusCode(); // 상태 코드 확인

            string responseData = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Response Data:");
            Console.WriteLine(responseData);
        }

        private static async Task PostRequest(HttpClient client, string url)
        {
            var postData = new StringContent(
                "{\"title\": \"foo\", \"body\": \"bar\", \"userId\": 1}",
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await client.PostAsync(url, postData);
            response.EnsureSuccessStatusCode(); // 상태 코드 확인

            string responseData = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Response Data:");
            Console.WriteLine(responseData);
        }

        private static async Task PutRequest(HttpClient client, string url)
        {
            var putData = new StringContent(
                "{\"id\": 1, \"title\": \"updated title\", \"body\": \"updated body\", \"userId\": 1}",
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await client.PutAsync(url, putData);
            response.EnsureSuccessStatusCode(); // 상태 코드 확인

            string responseData = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Response Data:");
            Console.WriteLine(responseData);
        }
    }
}
