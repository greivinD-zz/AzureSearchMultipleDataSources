using Azure.Search.Documents.Indexes;
using Azure.Search.Documents.Indexes.Models;
using Microsoft.Spatial;
using System;
using System.Text.Json.Serialization;

namespace AzureSearch.SDKHowTo
{
    public partial class Entity
    {
        [SimpleField(IsKey = true)]
        public string Id { get; set; }

        public string entity_key { get; set; }

        [SearchableField(IsFilterable = true)]
        public string name { get; set; }

        [SearchableField(IsFilterable = true, IsSortable = true)]
        public string first_name { get; set; }

        [SearchableField(AnalyzerName = LexicalAnalyzerName.Values.EnLucene)]
        public string middle_name { get; set; }

        [SearchableField(AnalyzerName = LexicalAnalyzerName.Values.FrLucene)]
        public string last_name { get; set; }

        [SearchableField(IsFilterable = true, IsSortable = true, IsFacetable = true)]
        public string city { get; set; }

        [SearchableField(IsFilterable = true, IsFacetable = true)]
        public string address_line_1 { get; set; }

        [SearchableField(IsFilterable = true, IsFacetable = true)]
        public string address_line_2 { get; set; }

        [SearchableField(IsFilterable = true, IsFacetable = true)]
        public string postal_code { get; set; }

        [SearchableField(IsFilterable = true, IsFacetable = true)]
        public string state_province { get; set; }

        [SearchableField(IsFilterable = true, IsFacetable = true)]
        public string area_code { get; set; }

        [SearchableField(IsFilterable = true, IsFacetable = true)]
        public string phone_number { get; set; }

        [SearchableField(IsFilterable = true, IsFacetable = true)]
        public string phone_extension { get; set; }

        [SearchableField(IsFilterable = true, IsFacetable = true)]
        public string email_address { get; set; }

        [SearchableField(IsFilterable = true, IsSortable = true)]
        public string Type { get; set; }

        [SearchableField(IsFilterable = true, IsSortable = true)]
        public string Status { get; set; }

        public Case[] Cases { get; set; }
    }
}
