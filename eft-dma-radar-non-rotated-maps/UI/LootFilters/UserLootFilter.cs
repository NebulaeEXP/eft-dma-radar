﻿using eft_dma_shared.Common.Misc.Data;

namespace eft_dma_radar_non_rotated_maps.UI.LootFilters
{
    public sealed class UserLootFilter
    {
        [JsonPropertyName("enabled")] public bool Enabled { get; set; } = true;

        [JsonInclude]
        [JsonPropertyName("entries")]
        public List<LootFilterEntry> Entries { get; init; } = new();
    }
}