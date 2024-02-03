using BlazorPainel.Models;

namespace BlazorPainel.Services
{
    public interface IOrcamentoService
    {
        Task<List<Orcamento>> GetAsync();
        Task CreateAsync(Orcamento orcamento);
        Task<Orcamento?> GetByIdAsync(string id);
        Task<Orcamento> UpdateOrcamentoAsync(string id, Orcamento orcamento);
        Task AddProdutoOrcamentoAsync(string id, Produto produto);
        Task AtualizarProdutoOrcamento(string id, string produtoId, Produto produto);
        Task RemoveProdutoAsync(string id, string idProduto);
        Task DeleteAsync(string id);
    }
}