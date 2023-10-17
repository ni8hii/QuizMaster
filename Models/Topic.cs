using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace QuizMaster.Models
{
    public class Topic

    {

        [Key]

        public int TopicId { get; set; }



        [Required]

        [MaxLength(100)]

        public string TopicName { get; set; }

    }
}
