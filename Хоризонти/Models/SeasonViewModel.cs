using System.Collections.Generic;

namespace Horizons.Models
{
    public class SeasonViewModel
    {
        public List<DestinationListViewModel> Spring { get; set; } = new();
        public List<DestinationListViewModel> Summer { get; set; } = new();
        public List<DestinationListViewModel> Autumn { get; set; } = new();
        public List<DestinationListViewModel> Winter { get; set; } = new();
    }
}
