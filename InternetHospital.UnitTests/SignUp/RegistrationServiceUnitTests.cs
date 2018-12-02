﻿using AutoFixture;
using AutoMapper;
using FluentAssertions;
using InternetHospital.BusinessLogic.Models;
using InternetHospital.BusinessLogic.Services;
using InternetHospital.DataAccess;
using InternetHospital.DataAccess.Entities;
using InternetHospital.UnitTests.TestHelpers;
using Xunit;

namespace InternetHospital.UnitTests.SignUp
{
    public class RegistrationServiceUnitTests
    {
        public RegistrationServiceUnitTests()
        {
            Mapper.Reset();
            Mapper.Initialize(cfg => cfg.CreateMap<UserRegistrationModel, User>());
        }

        [Fact]
        public async void ShouldPatientRegistrate()
        {
            const string PATIENT = "Patient";

            var options = DbContextHelper.GetDbOptions(nameof(ShouldPatientRegistrate));
            var fixture = FixtureHelper.CreateOmitOnRecursionFixture();

            var expectedUser = fixture.Build<User>()
                .Create();

            var fixtureRegistrationModel = RegistrationHelper.GetRegistrationModel(expectedUser, PATIENT);
            var fakeUserManager = RegistrationHelper.GetConfiguredUserManager();
            var fakeRoleManager = RegistrationHelper.GetFakeRoleManager();

            using (var context = new ApplicationContext(options))
            {
                var registrationService = new RegistrationService(context, fakeUserManager.Object, fakeRoleManager.Object);

                // act 
                var res = await registrationService.PatientRegistration(fixtureRegistrationModel);

                // asset
                res.Email.Should().BeEquivalentTo(expectedUser.Email);
            }
        }

        [Fact]
        public async void ShoulDoctorRegistrate()
        {
            const int USER_ID = 2;
            const string DOCTOR = "Doctor";

            var options = DbContextHelper.GetDbOptions(nameof(ShoulDoctorRegistrate));
            var fixture = FixtureHelper.CreateOmitOnRecursionFixture();

            var expectedUser = fixture.Build<User>()
                .With(u => u.Id, USER_ID)
                .With(u => u.Doctor, new Doctor
                {
                    UserId = USER_ID
                })
                .Create();

            var fixtureRegistrationModel = RegistrationHelper.GetRegistrationModel(expectedUser, DOCTOR);
            var fakeUserManager = RegistrationHelper.GetConfiguredUserManager();
            var fakeRoleManager = RegistrationHelper.GetFakeRoleManager();

            using (var context = new ApplicationContext(options))
            {
                var registrationService = new RegistrationService(context, fakeUserManager.Object, fakeRoleManager.Object);

                // act 
                var res = await registrationService.DoctorRegistration(fixtureRegistrationModel);

                // assert
                res.Email.Should().BeEquivalentTo(expectedUser.Email);
                res.Doctor.UserId.Should().Be(expectedUser.Doctor.UserId);
            }
        }
    }
}
