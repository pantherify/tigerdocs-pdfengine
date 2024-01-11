using Microsoft.AspNetCore.Mvc;
using tigerdocs_pdfengine.Models;

namespace tigerdocs_pdfengine.Controllers;


[ApiController]
[Route("[controller]")]
public class PDFParserController(ILogger<PDFParserController> logger) : ControllerBase
{
  private readonly ILogger<PDFParserController> _logger = logger;

  [HttpGet(Name = "GetAPIVersion")]
  public PDFEngineApiVersion Get()
  {
    return new PDFEngineApiVersion
    {
      Version = "0.0.1",
      Name = "TigerDocs PDF Engine (pdf-parser)",
      Description = "A PDF Engine for TigerDocs"
    };
  }

}