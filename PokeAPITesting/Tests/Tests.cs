using FluentAssertions;
using NUnit.Framework;
using PokeAPITesting.Models;
using PokeAPITesting.Models.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPITesting.Tests
{
    // Test class that inherits from the SetupBase class (To reuse code)
    internal class Tests : SetupBase
    {
        [Test]
        public void GetCharmander()
        {
            var endpoint = "https://pokeapi.co/api/v2/pokemon/charmander";
            var responseBody = ExecuteGetRequest<SinglePokemonGetResponse>(endpoint);

            responseBody.id.Should().Be(4);
            responseBody.is_default.Should().BeTrue();
            responseBody.base_experience.Should().Be(62);
            responseBody.stats[0].base_stat.Should().Be(39);
        }

        public void GetCharmeleon()
        {
            var endpoint = "https://pokeapi.co/api/v2/pokemon/charmeleon";
            var responseBody = ExecuteGetRequest<SinglePokemonGetResponse>(endpoint);

            responseBody.id.Should().Be(5);
            responseBody.is_default.Should().BeTrue();
            responseBody.height.Should().Be(11);
        }
    }
}
