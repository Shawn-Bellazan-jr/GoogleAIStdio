using Azure.Core;
using GoogleAIStudio.Core.Interfaces.IPrompts;
using GoogleAIStudio.Core.Models;
using GoogleAIStudio.Infrastructure.Dtos.ContentDtos;
using GoogleAIStudio.Infrastructure.Services.IServices;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Authenticators.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAIStudio.Infrastructure.Services
{
    public class FreeformPromptService : PromptService<FreeformPrompt>, IFreeformPromptService
    {
        public FreeformPromptService(IPromptRepository<FreeformPrompt> repository, IRestClient client) : base(repository, client)
        {
        }


        public async Task<string> SendPrompt(PromptDto prompt)
        {

            // Determine the specific endpoint for sending prompts to AI Studio.
            var request = new RestRequest("models/gemini-pro:generateContent", Method.Post);

            // Replace placeholders with your actual project ID, location, and studio ID
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("x-goog-api-key", "AIzaSyCk1_TBA0X4HIVjThXQUcEsnU8zSTapAko");
            request.AddJsonBody(prompt);

            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                // Handle errors
                Console.WriteLine($"Error: {response.StatusCode} - {response.ErrorMessage}");
                throw new Exception($"Error sending prompt: {response.ErrorMessage}");
            }
        }
    }
}
