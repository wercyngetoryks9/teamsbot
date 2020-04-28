
using Microsoft.Graph;
using System.Collections.Generic;

namespace Sample.IncidentBot.Data
{
    /// <summary>
    /// The MeetingNow request data.
    /// </summary>
    public class MeetingNowRequestData
    {
        /// <summary>
        /// Gets or sets the tenant id.
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets the organizer id.
        /// </summary>
        public string OrganizerId { get; set; }

        /// <summary>
        /// Get or sets Attendies
        /// </summary>
        public IEnumerable<MeetingParticipantInfo> Attendies { get; set; }
    }
}
