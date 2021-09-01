﻿using osu.Framework.Graphics;
using osu.Game.Rulesets.Hitokori.Objects.TilePoints;
using osu.Game.Rulesets.Hitokori.UI.Visuals;
using osu.Game.Rulesets.Scoring;
using osuTK;

namespace osu.Game.Rulesets.Hitokori.Objects.Drawables {
	public class DrawableNoJudgementTilePoint : DrawableHitokoriHitObject<NoJudgementTilePoint, TilePoint, TilePointVisual> {
		public DrawableNoJudgementTilePoint () {
			Anchor = Anchor.Centre;
			Origin = Anchor.Centre;
		}

		protected override void OnApply () {
			base.OnApply();
			Position = (Vector2)HitObject.Position * 100;
		}

		protected override void Update () {
			base.Update();

			Position = (Vector2)HitObject.Position * 100;
		}

		protected override void CheckForResult ( bool userTriggered, double timeOffset ) {
			if ( timeOffset >= 0 ) ApplyResult( j => j.Type = HitResult.IgnoreHit );
		}

		protected override double InitialLifetimeOffset => 2000;
	}
}
