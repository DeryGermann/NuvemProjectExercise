namespace NuvemProjectExercise.Pharmacy.Service.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; } 
        public bool Success { get; set; } = true;
        public string Status { get; set; } = "500";
        public string Message { get; set; } = string.Empty;
    }
}