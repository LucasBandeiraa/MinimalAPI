using APIminimal.Contexto;
using APIminimal.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<Contexto>
(options => options.UseSqlServer("Server=172.16.1.119;Database=ZOOLOGICO;Uid=lucas;Pwd=123456;"));

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(builder => builder
.AllowAnyOrigin());



app.UseSwagger();

app.MapPost("adicionarLivro", async (Livro Livro, Contexto Contexto) =>
{
    Contexto.Livro.Add(Livro);
    await Contexto.SaveChangesAsync();  
});

app.MapDelete("excluirProduto/{id}", async (int id, Contexto contexto) =>
{
    var livroExcluir = await contexto.Livro.FirstOrDefaultAsync(p => p.id_livro == id);
    if (livroExcluir != null)
    {
        contexto.Livro.Remove(livroExcluir);
        await contexto.SaveChangesAsync();
    }
});
app.MapGet("listarLivro", async ( Contexto Contexto) =>
{
    return await Contexto.Livro.ToListAsync();
});

app.MapPost("obterLivro/{id}", async (int id, Contexto Contexto) =>
{
    await Contexto.Livro.FirstOrDefaultAsync(p => p.id_livro == id);
});


app.UseSwaggerUI();

app.Run();
