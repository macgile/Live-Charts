﻿using System.Drawing;

namespace LiveCharts.Core
{
    /// <summary>
    /// A set of useful extensions.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Sets the opacity.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="opacity">The opacity.</param>
        /// <returns></returns>
        public static Color SetOpacity(this Color color, double opacity)
        {
            return Color.FromArgb((byte) (255 * opacity), color.R, color.G, color.B);
        }
    }
}