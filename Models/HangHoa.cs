using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GoodsAPI2.Models
{
    public class HangHoa
    {
        [Key]
        [StringLength(9)]
        [JsonPropertyName("maHangHoa")]
        public string MaHangHoa { get; set; } = null!;

        [Required]
        [Unicode(true)]
        [JsonPropertyName("tenHangHoa")]
        public string TenHangHoa { get; set; } = null!;

        [JsonPropertyName("soLuong")]
        public int SoLuong { get; set; }

        [JsonPropertyName("ghiChu")]
        public string? GhiChu { get; set; }

    }
}
