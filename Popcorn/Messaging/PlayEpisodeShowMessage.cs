﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using Popcorn.Models.Episode;

namespace Popcorn.Messaging
{
    /// <summary>
    /// Play an episode of a show
    /// </summary>
    public class PlayShowEpisodeMessage : MessageBase
    {
        /// <summary>
        /// Episode
        /// </summary>
        public readonly EpisodeShowJson Episode;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="episode">Episode</param>
        public PlayShowEpisodeMessage(EpisodeShowJson episode)
        {
            Episode = episode;
        }
    }
}
