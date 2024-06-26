﻿using StardewValley;
using StardewValley.TerrainFeatures;

namespace UltimateFertilizer;

public class ExposedApi : IUltimateFertilizerApi {
    public bool ApplyFertilizerOnDirt(HoeDirt dirt, string itemId, Farmer who) {
        return ModEntry.Plant.ApplyFertilizerOnDirt(dirt, itemId, who);
    }

    public bool IsFertilizerApplied(HoeDirt dirt, string itemId) {
        return dirt.fertilizer.Value.Contains(itemId);
    }

    public void RegisterFertilizerType(IEnumerable<string> itemIds) {
        ModEntry.Fertilizers.Add(itemIds.ToList());
    }
}