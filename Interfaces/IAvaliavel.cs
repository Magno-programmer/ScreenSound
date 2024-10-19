﻿using ScreenSound.Models;

namespace ScreenSound.Interfaces;

internal interface IAvaliavel
{
    public void Avaliar(Avaliacao nota);

    public double Media { get; }
}
