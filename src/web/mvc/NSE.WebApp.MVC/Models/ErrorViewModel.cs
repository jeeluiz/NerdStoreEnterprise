namespace NSE.WebApp.MVC.Models
{
    public class ErrorViewModel
    {
        public int ErrorCode { get; set; }
        public string Titulo { get; set; }
        public string Message { get; set; }

    }

    public class ResponseResult
    {
        public string Title { get; set; }
        public int Status { get; set; }
        public ResponseErrosMensages Erros { get; set; }
    }

    public class ResponseErrosMensages
    {
        public List<string> Mensagens { get; set; }
    }
}