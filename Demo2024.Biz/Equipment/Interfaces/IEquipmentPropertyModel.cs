﻿namespace Demo2024.Biz.Equipment.Interfaces;

public interface IEquipmentPropertyModel
{
    string Index { get; set; }

    string Name { get; set; }

    string[] Desc { get; set; }

    string Url { get; set; }
}
