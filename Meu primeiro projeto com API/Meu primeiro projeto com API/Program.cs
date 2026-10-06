var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços para a API
builder.Services.AddControllers();

// =========================================================
// 1. CONFIGURAÇÃO DO CORS (Sempre ANTES do builder.Build())
// =========================================================
builder.Services.AddCors(options =>
{
    // Criamos uma política chamada "MinhaPoliticaCors"
    options.AddPolicy("MinhaPoliticaCors", policy =>
    {
        policy.AllowAnyOrigin()   // Permite qualquer domínio (ex: Live Server do VS Code)
              .AllowAnyMethod()   // Permite GET, POST, PUT, DELETE
              .AllowAnyHeader();  // Permite qualquer cabeçalho (Headers)
    });
});

var app = builder.Build();

// =========================================================
// PIPELINE DE EXECUÇÃO (A ORDEM AQUI É OBRIGATÓRIA)
// =========================================================

// Se estiver testando localmente em HTTP e tomando "Erro 307", comente esta linha:
// app.UseHttpsRedirection();

// 2. ATIVAÇÃO DO CORS (Sempre ANTES do Authorization e do MapControllers)
app.UseCors("MinhaPoliticaCors");

// O Authorization DEVE vir depois do CORS
app.UseAuthorization();

// Mapeia as rotas da sua API
app.MapControllers();

app.Run();