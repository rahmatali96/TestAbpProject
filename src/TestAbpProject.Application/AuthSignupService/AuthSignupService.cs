
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestAbpProject.AuthSignup;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace TestAbpProject.AuthSignupService
{
    public interface IAuthSignupService : IApplicationService
    {
        Task<AuthUserSignup> PostAuthSignupAsync(AuthUserSignup authUserSignup);
        //Task<IActionResult> FileUploadAsync(List<IFormFile> files, string folder, string subfolder);
    }
    public class AuthSignupService : TestAbpProjectAppService, IAuthSignupService
    {
        private readonly AuthSettings _authSettings;

        public AuthSignupService(IOptions<AuthSettings> authSettings)
        {
            _authSettings = authSettings.Value;
        }
        //public Task<IActionResult> FileUploadAsync(List<IFormFile> files, string folder, string subfolder)
        //{
        //    foreach (var file in files)
        //    {
        //        if (file.Length < 5242880)
        //        {
        //            var supportedType = new[] { "doc", "docx", "pdf", "jpg", "jpeg", "png" };
        //            var fileExt = System.IO.Path.GetExtension(file.FileName).Substring(1);

        //            if (!supportedType.Contains(fileExt))
        //            {
        //                throw new UserFriendlyException("File is not among this type txt/docx/doc/pdf/jpg/jpeg/png......");
        //            }
        //        }
        //        else
        //        {
        //            var request = new PutObjectRequest()
        //            {
        //                BucketName = "theraparea",
        //                Key = string.IsNullOrEmpty(folder) ? file.FileName : $"{folder}/{subfolder?.TrimEnd('/')}/{file.FileName}",
        //                InputStream = file.OpenReadStream()
        //            };
        //            request.Metadata.Add("Content-type", file.ContentType);
        //            await _amazonS3.PutObjectAsync(request);
        //        }
        //        return ${ folder}/{ subfolder};
        //    }
        //}

        public async Task<AuthUserSignup> PostAuthSignupAsync(AuthUserSignup authUserSignup )
        {
            var signup = new AuthUserSignup
            {
                client_id = _authSettings.ClientId,
                client_secret = _authSettings.ClientSecret,
                connection = _authSettings.Connection,
                given_name = authUserSignup.given_name,
                family_name = authUserSignup.family_name,
                email = authUserSignup.email,
                password = authUserSignup.password,
                name = $"{authUserSignup.given_name}{authUserSignup.family_name}",
            };
            var json = JsonConvert.SerializeObject(signup);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = $"{_authSettings.Domain}/dbconnections/signup";
            using var client = new HttpClient();
            var response = await client.PostAsync(url, data);
            var result = await response.Content.ReadAsStringAsync();
            return signup;
        }
    }
}
 