using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{

    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello World!";
        }

        [HttpGet("/bsms")]
        public string bsms()
        {
            return "Responsabilidade Pessoal," +
                " mentalidade de crescimento," +
                " orientação para o futuro," +
                " persistência," +
                " comunicação," +
                " trabalho em equipe," +
                " proatividade," +
                " orientação ao detalhe,";
        }

        [HttpGet("/aprendizados")]
        public string aprendizados()
        {
            return "Revisar ASPNET," +
                " Praticar banco de dados, " +
                " Rever CRUD";
        }
    }
}
