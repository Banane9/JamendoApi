﻿using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiEntities.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Reviews
{
    /// <summary>
    /// Represents a call to the /reviews/albums path.
    /// </summary>
    public sealed class TrackReviewsCall : CallInformation<TrackReview[]>
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the access_token parameter.
        /// </summary>
        public AccessTokenParameter AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the album_id parameter.
        /// </summary>
        public AlbumIdParameter AlbumIds { get; set; }

        /// <summary>
        /// Gets or sets the artist_id parameter.
        /// </summary>
        public ArtistIdParameter ArtistId { get; set; }

        /// <summary>
        /// Gets or sets the audiodlformat parameter.
        /// </summary>
        public AudioDownloadFormatParameter AudioDownloadFormat { get; set; }

        /// <summary>
        /// Gets or sets the audioformat parameter.
        /// </summary>
        public AudioFormatParameter AudioFormat { get; set; }

        /// <summary>
        /// Gets or sets the datebetween parameter.
        /// </summary>
        public DateBetweenParameter DateBetween { get; set; }

        /// <summary>
        /// Gets or sets the hasscore parameter.
        /// </summary>
        public HasScoreParameter HasScore { get; set; }

        /// <summary>
        /// Gets or sets the ids parameter.
        /// </summary>
        public IdParameter Ids { get; set; }

        /// <summary>
        /// Gets or sets the lang parameter.
        /// </summary>
        public LanguageParameter Language { get; set; }

        /// <summary>
        /// Gets or sets the limit parameter.
        /// </summary>
        public LimitParameter Limit { get; set; }

        /// <summary>
        /// Gets or sets the offset parameter.
        /// </summary>
        public OffsetParameter Offset { get; set; }

        /// <summary>
        /// Gets or sets the order parameter.
        /// </summary>
        public OrderParameter<ReviewOrder> Order { get; set; }

        /// <summary>
        /// Gets or sets the track_id parameter.
        /// </summary>
        public TrackIdParameter TrackIds { get; set; }

        /// <summary>
        /// Gets or sets the user_id parameter.
        /// </summary>
        public UserIdParameter UserId { get; set; }

        #endregion Parameters

        public override IEnumerable<Parameter> Parameters
        {
            get
            {
                yield return AccessToken;
                yield return AlbumIds;
                yield return ArtistId;
                yield return AudioDownloadFormat;
                yield return AudioFormat;
                yield return DateBetween;
                yield return HasScore;
                yield return Ids;
                yield return Language;
                yield return Limit;
                yield return Offset;
                yield return Order;
                yield return TrackIds;
                yield return UserId;
            }
        }

        public override string Path
        {
            get { return "/reviews/tracks"; }
        }
    }
}