﻿using System;
using System.Collections.Generic;

namespace zh_qy5sae.Models;

public partial class Fogasok
{
    public int FogasId { get; set; }

    public string? FogasNev { get; set; }

    public byte[]? Kep { get; set; }

    public string? Leiras { get; set; }

    public virtual ICollection<Receptek> Receptek { get; } = new List<Receptek>();
}
