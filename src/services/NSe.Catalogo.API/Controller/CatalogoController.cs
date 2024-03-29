﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NSe.Catalogo.API.Models;
using NSE.WebApi.Core.Identidade;

namespace NSe.Catalogo.API.Controller
{
    [ApiController]
    [Authorize]
    public class CatalogoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public CatalogoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [AllowAnonymous]
        [HttpGet("catalogo/produtos")]
        public async Task<IEnumerable<Produto>> Index()
        {
            return await _produtoRepository.ObterTodos();
        }

        [ClaimsAuthorize("Catalogo","Ler")]
        [HttpGet("catalogo/produtos/{id}")]
        public async Task<Produto>ProdutoDetalhe(Guid id)
        {
            
            return await _produtoRepository.ObterPorId(id);
        }
    }
}
