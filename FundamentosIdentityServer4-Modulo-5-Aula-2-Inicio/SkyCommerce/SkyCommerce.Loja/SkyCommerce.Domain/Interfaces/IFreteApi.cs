﻿using Refit;
using SkyCommerce.Models;
using SkyCommerce.ViewObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkyCommerce.Interfaces
{
    public interface IFreteApi
    {
        [Get("/fretes/para/{lat},{lon}/calcular")]
        Task<IEnumerable<Frete>> Calcular([AliasAs("lat")] double latitude, [AliasAs("lon")] double longitude, Embalagem embalagem);

        [Get("/fretes")]
        Task<IEnumerable<DetalhesFrete>> Modalidades(PosicaoViewObject posicao);
    }
}