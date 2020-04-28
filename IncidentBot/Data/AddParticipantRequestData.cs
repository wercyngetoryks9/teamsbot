﻿
namespace Sample.IncidentBot.Data
{
    /// <summary>
    /// The add participant request body.
    /// </summary>
    public class AddParticipantRequestData
    {
        /// <summary>
        /// Gets or sets the object id.
        /// </summary>
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or sets the replaces call identifier.
        /// </summary>
        /// <value>
        /// The replaces call identifier.
        /// </value>
        public string ReplacesCallId { get; set; }
    }
}
