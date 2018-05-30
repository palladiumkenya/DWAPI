export interface PatientExtract {
    PatientPK?: number;
    SiteCode?: number;
    EMR?: string;
    Project?: string;
    FacilityName?: string;
    Gender?: string;
    DOB?: Date;
    RegistrationDate?: Date;
    RegistrationAtCCC?: Date;
    RegistrationAtPMTCT?: Date;
    RegistrationAtTBClinic?: Date;
    PatientSource?: string;
    Region?: string;
    District?: string;
    Village?: string;
    ContactRelation?: string;
    LastVisit?: Date;
    MaritalStatus?: string;
    EducationLevel?: string;
    DateConfirmedHIVPositive?: Date;
    PreviousARTExposure?: string;
    PreviousARTStartDate?: Date;
    StatusAtCCC?: string;
    StatusAtPMTCT?: string;
    StatusAtTBClinic?: string;
    SatelliteName?: string;
    PatientID?: string;
    FacilityId?: number;
}
