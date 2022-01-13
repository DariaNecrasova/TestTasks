using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using HandlebarsDotNet.StringUtils;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace TestTask_API
{
    [ApiController]
    [Route("[controller]")]
    public class RegistrationController : ControllerBase
    {
        private static List<GetRegistrationResponse> Registered =
        new List<GetRegistrationResponse>
        {
            new GetRegistrationResponse
            ( Guid.NewGuid().ToString(), DateTime.Today, "en", new Person("Jon", "Smit", "jonSmit@gmail.com")),
            new GetRegistrationResponse
            ( Guid.NewGuid().ToString(), DateTime.Today, "en", new Person("Jess", "Smit", "jessSmit@gmail.com")),
    };
       
        private readonly ILogger<RegistrationController> _logger;

        public RegistrationController(ILogger<RegistrationController> logger)
        {
            _logger = logger;
        }
        
        //Post /registration
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public String Post(String x_correlationid,[FromBody] String reg)
        {            
            try
            {
                String substring = Guid.NewGuid().ToString();
                reg = reg.Insert(1, "\n\"registrationDate\": \"" + substring + "\",\n");
                
                Registered.Add(JsonSerializer.Deserialize<GetRegistrationResponse>(reg));

                return Registered.Last().getId();
            }
            catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.BadRequest)
            {
                Error er = new Error("ValidationFailed", null);
                ErrorResponse erResp = new ErrorResponse(er, new FieldError("fieldName", "IsRequired", "The field is required"));
                string erJson = JsonSerializer.Serialize<ErrorResponse>(erResp);
                return erJson;
            }
            catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.InternalServerError)
            {
                Error er = new Error("InternalServerError", "Human friendly error message");
                ErrorResponse erResp = new ErrorResponse(er, null);
                string erJson = JsonSerializer.Serialize<ErrorResponse>(erResp);
                return erJson;
            }
        }
        
        // GET /registration
        [HttpGet]
        public IEnumerable<GetRegistrationResponse> Get()
        {
            return Registered;
        }
        
        
        //GET registration/{registrationId}
        [HttpGet("{registrationId}")]
        public String Get(String registrationId, String x_correlationid)
        {
            try
            {
                foreach (GetRegistrationResponse r in Registered)
                {
                    if (registrationId.Equals(r.getId()))
                    {
                        string regJson = JsonSerializer.Serialize<GetRegistrationResponse>(r);
                        return regJson;
                    }
                }
            }
            catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.NotFound || (ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.InternalServerError)
            {
                Error er = new Error("InternalServerError", "Human friendly error message");
                ErrorResponse erResp = new ErrorResponse(er, null);
                string erJson = JsonSerializer.Serialize<ErrorResponse>(erResp);
                return erJson;
            }
            Error erF = new Error("InfoNotFound", "Please check your database");
            ErrorResponse erRespFinal = new ErrorResponse(erF, null);
            string erJsonNotInfo = JsonSerializer.Serialize<ErrorResponse>(erRespFinal);
            return erJsonNotInfo;

        }

        
    }
}
