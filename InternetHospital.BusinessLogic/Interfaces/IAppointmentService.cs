﻿using System.Collections.Generic;
using InternetHospital.BusinessLogic.Models;
using InternetHospital.BusinessLogic.Models.Appointment;

namespace InternetHospital.BusinessLogic.Interfaces
{
    public interface IAppointmentService
    {
        IEnumerable<AppointmentModel> GetMyAppointments(int doctorId);
        PageModel<IEnumerable<AppointmentModel>> GetMyAppointments(AppointmentHistoryParameters parameters, int doctorId);
        PageModel<List<AvailableAppointmentModel>> GetAvailableAppointments(AppointmentSearchModel searchParameters);
        IEnumerable<AppointmentForPatient> GetPatientsAppointments(int patientId);
        bool ChangeAccessForPersonalInfo(ChangePatientInfoAccessModel model);
        bool AddAppointment(AppointmentCreationModel creationModel, int doctorId);
        bool SubscribeForAppointment(AppointmentSubscribeModel appointmentModel, int patientId);
        bool UnsubscribeForAppointment(int appointmentId);
        (bool status, string message) CancelAppointment(int appointmentId, int doctorId);
        (bool status, string message) DeleteAppointment(int appointmentId, int doctorId);
        IEnumerable<string> GetAppointmentStatuses();
    }
}