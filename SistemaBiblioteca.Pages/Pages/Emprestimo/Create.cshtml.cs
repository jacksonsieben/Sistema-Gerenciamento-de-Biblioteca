using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SistemaBiblioteca.Pages.Models;

namespace SistemaBiblioteca.Pages.Pages.Emprestimo
{
    public class Create : PageModel
    {
        [BindProperty]
        public EmprestimoModel EmprestimoModel { get; set; } = new();
        public Create(){}

        public async Task<IActionResult> OnPostAsync(int id){
                if(!ModelState.IsValid){
                    return Page();
                }
                
                var httpClient = new HttpClient();
                var url = "http://localhost:5185/Emprestimo/Create";
                var bibliotecarioJson = JsonConvert.SerializeObject(EmprestimoModel);
                var content = new StringContent(bibliotecarioJson, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(url, content);
                
                if(response.IsSuccessStatusCode){
                    return RedirectToPage("/Emprestimo/Index");
                } else {
                    return Page();
                }
        }
    }
}