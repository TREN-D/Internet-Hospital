﻿using System;
using System.ComponentModel.DataAnnotations;

namespace InternetHospital.DataAccess.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int? UserId { get; set; }
        public int StatusId { get; set; }
        public string Address { get; set; }
        public bool IsAllowPatientInfo { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public virtual AppointmentStatus Status { get; set; }
        public virtual IllnessHistory IllnessHistory { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual User User { get; set; }
    }
}
