using System.ComponentModel.DataAnnotations;

namespace Code1st.Models;

public class Team {
    [Key]
    public string? TeamName { get; set; }
    public string? City { get; set; }

    public string? Manager { get; set; }

    public List<Player>? Players { get; set; }
}