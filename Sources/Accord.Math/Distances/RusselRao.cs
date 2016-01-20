﻿// Accord Math Library
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2015
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace Accord.Math.Distances
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    ///   Russel-Rao dissimilarity.
    /// </summary>
    /// 
    [Serializable]
    public sealed class RusselRao : IDistance<double[]>, IDistance<int[]>
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="RusselRao"/> class.
        /// </summary>
        /// 
        public RusselRao()
        {
        }

        /// <summary>
        ///   Computes the distance <c>d(x,y)</c> between points
        ///   <paramref name="x"/> and <paramref name="y"/>.
        /// </summary>
        /// 
        /// <param name="x">The first point <c>x</c>.</param>
        /// <param name="y">The second point <c>y</c>.</param>
        /// 
        /// <returns>
        ///   A double-precision value representing the distance <c>d(x,y)</c>
        ///   between <paramref name="x"/> and <paramref name="y"/> according 
        ///   to the distance function implemented by this class.
        /// </returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public double Distance(int[] x, int[] y)
        {
            int tt = 0;
            for (int i = 0; i < x.Length; i++)
                if (x[i] != 0 && y[i] != 0) tt++;

            return (x.Length - tt) / (double)(x.Length);
        }

        /// <summary>
        ///   Computes the distance <c>d(x,y)</c> between points
        ///   <paramref name="x"/> and <paramref name="y"/>.
        /// </summary>
        /// 
        /// <param name="x">The first point <c>x</c>.</param>
        /// <param name="y">The second point <c>y</c>.</param>
        /// 
        /// <returns>
        ///   A double-precision value representing the distance <c>d(x,y)</c>
        ///   between <paramref name="x"/> and <paramref name="y"/> according 
        ///   to the distance function implemented by this class.
        /// </returns>
        /// 
#if NET45
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public double Distance(double[] x, double[] y)
        {
            int tt = 0;
            for (int i = 0; i < x.Length; i++)
                if (x[i] != 0 && y[i] != 0) tt++;

            return (x.Length - tt) / (double)(x.Length);
        }


    }
}
