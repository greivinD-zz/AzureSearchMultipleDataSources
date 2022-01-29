using Azure.Search.Documents.Indexes;
using Azure.Search.Documents.Indexes.Models;
using Microsoft.Spatial;
using System;
using System.Text.Json.Serialization;

namespace AzureSearch.SDKHowTo
{
    public class Case
    {
        [SimpleField(IsFilterable = true)]
        public string entity_key { get; set; }

        [SimpleField(IsFilterable = true)]
        public string CASE_ID { get; set; }

        [SearchableField(IsFilterable = true)]
        public string CASE_TYPE { get; set; }

        [SearchableField(IsFilterable = true)]
        public string CASE_STATUS { get; set; }

        [SearchableField(AnalyzerName = LexicalAnalyzerName.Values.EnLucene)]
        public string CREATION_REASON { get; set; }

    }
}