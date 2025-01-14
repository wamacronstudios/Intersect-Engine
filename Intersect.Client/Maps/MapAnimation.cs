﻿using Intersect.Client.Entities;
using Intersect.Client.Framework.Entities;
using Intersect.Client.Framework.Maps;
using Intersect.GameObjects;
using System;

namespace Intersect.Client.Maps
{

    public partial class MapAnimation : Animation, IMapAnimation
    {
        public Guid Id { get; } = Guid.NewGuid();

        private int mDir;

        private int mTileX;

        private int mTileY;


        public MapAnimation(AnimationBase animBase, int tileX, int tileY, int dir, Entity owner = null) : base(animBase, false, false, -1, owner)
        {
            mTileX = tileX;
            mTileY = tileY;
            mDir = dir;
        }

    }

}
