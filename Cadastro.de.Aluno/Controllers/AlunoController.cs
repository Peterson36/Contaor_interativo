using Microsoft.AspNetCore.Mvc;

public class AlunoController : Controller
{
    // GET: /Aluno/Cadastrar — Exibe o formulário vazio
    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    // POST: /Aluno/Cadastrar — Recebe os dados do formulário
    [HttpPost]
    public IActionResult Cadastrar(Aluno aluno)
    {
        if (!ModelState.IsValid)
        {
            return View(aluno);
        }

        return View("Confirmacao", aluno);
    }
}
