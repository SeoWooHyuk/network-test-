using System;
using System.Net.Http;
using System.Threading.Tasks;

class HttpClientDemo
{
    static async Task Main()
    {
        //클라이언트 개체생성
        HttpClient httpClient = new HttpClient();

        //클라이언트 매서드 호출
        HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("http://www.microsoft.com/");

        //html 가져오기
        string reponsBody = await httpResponseMessage.Content.ReadAsStringAsync();

        //출력 
        Console.WriteLine(reponsBody); //그래도 텍스트로만 출력 이예제에서는
     
            }
}