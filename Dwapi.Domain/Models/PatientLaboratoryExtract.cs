﻿using System;
using System.ComponentModel.DataAnnotations;
using Dwapi.Domain.Abstract;

namespace Dwapi.Domain.Models
{
    //[Table("PatientLaboratoryExtract")]
    public class PatientLaboratoryExtract : ClientExtract
    {
        [Key]
        public override Guid Id { get; set; }
        public int? VisitId { get; set; }
        public DateTime? OrderedByDate { get; set; }
        public DateTime? ReportedByDate { get; set; }
        public string TestName { get; set; }
        public int? EnrollmentTest { get; set; }
        public string TestResult { get; set; }

        public PatientLaboratoryExtract()
        {
        }

        public PatientLaboratoryExtract(int patientPk, string patientId, int siteCode, int? visitId, DateTime? orderedByDate, DateTime? reportedByDate, string testName, int? enrollmentTest, string testResult, string emr, string project)
        {
            PatientPK = patientPk;
            PatientID = patientId;
            SiteCode = siteCode;
            VisitId = visitId;
            OrderedByDate = orderedByDate;
            ReportedByDate = reportedByDate;
            TestName = testName;
            EnrollmentTest = enrollmentTest;
            TestResult = testResult;
            Emr = emr;
            Project = project;
        }

        public PatientLaboratoryExtract(TempPatientLaboratoryExtract extract)
        {
            PatientPK = extract.PatientPK.Value;
            PatientID = extract.PatientID;
            SiteCode = extract.SiteCode.Value;
            VisitId = extract.VisitId;
            OrderedByDate = extract.OrderedByDate;
            ReportedByDate = extract.ReportedByDate;
            TestName = extract.TestName;
            EnrollmentTest = extract.EnrollmentTest;
            TestResult = extract.TestResult;
            Emr = extract.Emr;
            Project = extract.Project;

        }
    }
}