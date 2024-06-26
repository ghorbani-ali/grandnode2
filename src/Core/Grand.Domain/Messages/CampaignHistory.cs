﻿namespace Grand.Domain.Messages
{
    /// <summary>
    /// Represents a campaign history
    /// </summary>
    public class CampaignHistory : BaseEntity
    {
        
        public string CampaignId { get; set; }

        public string Email { get; set; }

        public string CustomerId { get; set; }

        public string StoreId { get; set; }

        public DateTime CreatedDateUtc { get; set; }

    }
}
