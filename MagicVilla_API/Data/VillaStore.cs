﻿using MagicVilla_API.Models.Dto;
using System.Net.NetworkInformation;

namespace MagicVilla_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto> 
        {
            new VillaDto() {Id = 1, Nombre = "Vista a la piscina", Ocupantes = 3, MetrosCuadrados = 50},
            new VillaDto() {Id = 2, Nombre = "Vista a la playa", Ocupantes = 4, MetrosCuadrados = 80}
        };
    }
}
