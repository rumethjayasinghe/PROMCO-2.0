using System.Globalization;
using System.Net;
using System;
using MS.PROM.BACKEND.Models;
using MS.PROM.BACKEND.MidasDTO;
using Microsoft.EntityFrameworkCore;

namespace MS.PROM.BACKEND.Data
{
    public interface IAbpUser
    {
        IEnumerable<Models.User> GetAll();
    }
    public class AbpUserRepository : IAbpUser
    {
        readonly MidasDataContext _AppDbContext;
        


        public AbpUserRepository(MidasDataContext context)
        {
            _AppDbContext = context;
          
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        //IEnumerable<User> IAbpUser.GetAll()
        //{
        //    //throw new NotImplementedException();
        //    return _AppDbContext.AbpUsers.FromSqlRaw($"select * from AbpUsers where Approver_Mobile =  '{mobile}'")).ToList();
        //}
        //public List<Models.EmployeeDirectory> GetEmployeeDirectory(string search, int page, int count)
        //{
        //    var skip = page * count;
        //    return (_AppDbContext.EmployeeDirectories.FromSqlRaw($"EXECUTE sp_employeedirectory @skip = {skip} ,@take = {count}, @search = N'{search}' ")).ToList();
        //}


        //public IEnumerable<Attendance> GetAll(string mobile)
        //{

        //    var result = new List<Attendance>();
        //    var user = _AppDbContext.Employees.FirstOrDefault(d => d.Mobile.EndsWith(mobile));
        //    if (user != null && user.SAPNumber != null)
        //    {
        //        result = (_AppDbContext.Attendances.FromSqlRaw($"EXECUTE sp_GetEASTime @ST_DATE = N'{(DateTime.Now.AddDays(-40)).ToString("yyyy/MM/dd")}' ,@EN_DATE = N'{DateTime.Now.ToString("yyyy/MM/dd")}', @EMP = N'{user.SAPNumber}'")).ToList();
        //    }
        //    return result;
        //}

        //public IEnumerable<AttendanceRequest> GetApprovalRequests(string mobile)
        //{
        //    return (_AppDbContext.AttendanceRequests.FromSqlRaw($"select * from vw_EASAttendanceRequests where Approver_Mobile =  '{mobile}'")).ToList();
        //}

        //public List<AttendanceAdjustment> GetAttendanceAdjustments(string mobile)
        //{
        //    var result = new List<AttendanceAdjustment>();
        //    var user = _AppDbContext.Users.FirstOrDefault(d => d.Mobile.EndsWith(mobile));
        //    if (user != null && user.SAPNumber != null)
        //    {
        //        result = (_AppDbContext.AttendanceAdjustments.FromSqlRaw($"EXECUTE sp_GetAdjustments @EMP = N'{user.SAPNumber}'")).ToList();
        //    }
        //    return result;

        //}

        //public Message<string> GetProcessApproval(EASData data)
        //{
        //    List<DbLogger> notifications = new List<DbLogger>(0);
        //    try
        //    {
        //        var user = _AppDbContext.Users.FirstOrDefault(d => d.Mobile.EndsWith(data.Mobile));

        //        if (user != null)
        //        {
        //            switch (data.Action)
        //            {
        //                case "APPROVED":
        //                    foreach (var item in data.Data)
        //                    {

        //                        var req = _EASDbContext.TbAttendanceModificationDetail.SingleOrDefault(d => d.RnAttendanceId == item.Code && (d.FormStatus == (int)CommonResources.EASStatus.IN_PROGRESS || d.FormStatus == (int)CommonResources.EASStatus.HRBP_APPROVED));
        //                        if (req != null)
        //                        {
        //                            var employee = _AppDbContext.Users.FirstOrDefault(d => d.Code == req.RequestBy);
        //                            req.FormStatus = (int)CommonResources.EASStatus.APPROVED;
        //                            req.ApprovedDateTime = DateTime.Now;
        //                            req.RemarkByHr = item.Reason;

        //                            _EASDbContext.TbEmployeeAttendance.Add(new TbEmployeeAttendance()
        //                            {
        //                                ActualTime = DateTime.Now,
        //                                AttendanceDateTime = req.AttendanceDateTime,
        //                                DblocationCode = req.DblocationCode,
        //                                InsertedDateTime = DateTime.Now,
        //                                IsDeleted = false,
        //                                IsSync = true,
        //                                LocationCode = req.LocationCode,
        //                                ManuallyUpdateBy = user.Code,
        //                                ManuallyUpdateDateTime = DateTime.Now,
        //                                SapemployeeNo = req.SapemployeeNo,
        //                                Status = req.Status,
        //                            });


        //                            notifications.Add(new DbLogger()
        //                            {
        //                                Message = $"Your Attendance Adjustment has been {data.Action} by {user.Name}",
        //                                LoggedDateTime = DateTime.Now,
        //                                Mobile = employee.Mobile,
        //                                IpAddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString(),
        //                                Status = data.Action,
        //                                System = CommonResources.Systems.EAS.ToString()
        //                            });

        //                            continue;
        //                        }
        //                        throw new Exception($"Invalid Request : request No# {item.Code}");
        //                    }
        //                    _EASDbContext.SaveChanges();
        //                    _logger.LogAll(notifications);
        //                    return new Message<string>() { Result = data.Action, StatusCode = "S" };
        //                case "REJECTED":
        //                    foreach (var item in data.Data)
        //                    {
        //                        var req = _EASDbContext.TbAttendanceModificationDetail.SingleOrDefault(d => d.RnAttendanceId == item.Code && (d.FormStatus == (int)CommonResources.EASStatus.IN_PROGRESS || d.FormStatus == (int)CommonResources.EASStatus.HRBP_APPROVED));
        //                        if (req != null)
        //                        {
        //                            var employee = _AppDbContext.Users.FirstOrDefault(d => d.Code == req.RequestBy);
        //                            req.FormStatus = (int)CommonResources.EASStatus.REJECTED;
        //                            req.ApprovedDateTime = DateTime.Now;
        //                            req.RemarkByHr = item.Reason;

        //                            notifications.Add(new DbLogger()
        //                            {
        //                                Message = $"Your Attendance Adjustment has been {data.Action} by {user.Name}",
        //                                LoggedDateTime = DateTime.Now,
        //                                Mobile = employee.Mobile,
        //                                IpAddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString(),
        //                                Status = data.Action,
        //                                System = CommonResources.Systems.EAS.ToString()
        //                            });

        //                            continue;
        //                        }
        //                        throw new Exception($"Invalid Request : request No# {item.Code}");
        //                    }
        //                    _EASDbContext.SaveChanges();
        //                    _logger.LogAll(notifications);
        //                    return new Message<string>() { Result = data.Action, StatusCode = "S" };
        //            }
        //        }
        //        throw new Exception("Invalid User ID");
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Message<string>() { Result = data.Action, StatusCode = "E", Text = ex.Message };
        //    }
        //}

        //public AdjustmentHeader GetSubmissionDetail(string mobile)
        //{
        //    var eas = new EASBL(_AppDbContext, _EASDbContext);
        //    Models.UserRole HRBP = null;
        //    Models.UserRole AttendanceOficer = null;

        //    var header = new AdjustmentHeader()
        //    {
        //        Locations = CommonResources.GetLocations(),
        //        Records = new List<AttendanceAdjustment>(),
        //    };

        //    var user = _AppDbContext.Users.FirstOrDefault(d => d.Mobile.EndsWith(mobile));
        //    if (user != null && user.SAPNumber != null)
        //    {

        //        eas.LoadHRBPDetails(ref AttendanceOficer, ref HRBP, user);
        //        var supervisor = eas.GetSupervisor_ESB(user.Email, "App");

        //        if (supervisor != null)
        //        {
        //            header.Supervisor = string.Format("{0} {1}", supervisor.Name, supervisor.LastName);
        //        }

        //        if (AttendanceOficer != null)
        //        {
        //            header.TimeAttendanceOfficer = string.Format("{0} {1}", AttendanceOficer.Name, AttendanceOficer.LastName);
        //        }

        //        if (HRBP != null)
        //        {
        //            header.HRBPOfficer = string.Format("{0} {1}", HRBP.Name, HRBP.LastName);
        //        }

        //        var region = eas.GetRegion(user.SAPNumber);
        //        var submissions = eas.GetValidateRecords(user.Code);
        //        if (region == null)
        //        {
        //            throw new Exception("Invalid Region");
        //        }

        //        DateTime preMonth = DateTime.Now.AddMonths(-1);
        //        int correctionEnableDate = region.DayEnd + 3;
        //        var lastPayrollPeriod = new { start = new DateTime(preMonth.Year, preMonth.Month, region.DayStart).Date, end = new DateTime(DateTime.Now.Year, DateTime.Now.Month, region.DayEnd).Date };

        //        var records = (_AppDbContext.Attendances.FromSqlRaw($"EXECUTE sp_GetEASTime @ST_DATE = N'{(lastPayrollPeriod.start).ToString("yyyy/MM/dd")}' ,@EN_DATE = N'{DateTime.Now.ToString("yyyy/MM/dd")}', @EMP = N'{user.SAPNumber}'")).ToList();

        //        //// Filter
        //        foreach (var data in records)
        //        {
        //            DateTime running;
        //            if (!DateTime.TryParseExact(data.Day, new string[] { "dd/MM/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None,
        //                out running))
        //            {
        //                throw new Exception("Invalid Date format ( day:d/M/yyyy time:H:mm)");
        //            }

        //            AttendanceAdjustment item = new AttendanceAdjustment
        //            {
        //                Location = data.Location
        //            };

        //            if (running.Date == DateTime.Now.Date)
        //                continue;

        //            if (data.In == "" && data.Out == "")
        //                continue;

        //            if (data.In != "" && data.Out != "")
        //                continue;

        //            if (data.In == "")
        //            {

        //                item.Day = data.Day;
        //                item.Type = "IN";
        //            }

        //            if (data.Out == "")
        //            {
        //                item.Day = data.Day;
        //                item.Type = "OUT";
        //            }

        //            var find = eas.CheckRecordExist(running, item.Type, user.SAPNumber);
        //            if (find > 0 && item.Type == "IN")
        //            {
        //                continue;
        //            }
        //            else if (find > 2 && item.Type == "OUT")
        //            {
        //                continue;
        //            }

        //            if (DateTime.Now.Date <= new DateTime(DateTime.Now.Year, DateTime.Now.Month, correctionEnableDate).Date)
        //            {

        //                if (!(running.Date >= lastPayrollPeriod.start && running.Date <= new DateTime(DateTime.Now.Year, DateTime.Now.Month, correctionEnableDate).Date))
        //                {
        //                    continue;
        //                }
        //            }
        //            else
        //            {
        //                if (!(running.Date >= lastPayrollPeriod.end))
        //                {
        //                    continue;
        //                }
        //            }


        //            var isContain = (from s in submissions
        //                             where s.AttendanceDateTime.Date == running.Date && s.Status == item.Type
        //                             select s).ToList();
        //            if (isContain.Count > 0)
        //            {
        //                continue;
        //            }


        //            item.Nature = "Missing";
        //            header.Records.Add(item);
        //        }


        //        List<TbAttendanceModificationDetail> attendanceModReqs = new List<TbAttendanceModificationDetail>();
        //        if (DateTime.Now.Date <= new DateTime(DateTime.Now.Year, DateTime.Now.Month, correctionEnableDate).Date)
        //        {
        //            attendanceModReqs = eas.GetRecords(user.Code,
        //                 lastPayrollPeriod.start, new DateTime(DateTime.Now.Year, DateTime.Now.Month, correctionEnableDate).Date);
        //        }
        //        else
        //        {
        //            attendanceModReqs = eas.GetRecords(user.Code,
        //                lastPayrollPeriod.end, DateTime.Now.Date);
        //        }

        //        var hrbpVerification = (from s in attendanceModReqs
        //                                where s.FormStatus == (int)CommonResources.EASStatus.HRBP_IN_PROGRESS
        //                                || (s.HrbpprocessBy != null && s.FormStatus == (int)CommonResources.EASStatus.APPROVED)
        //                                || (s.HrbpprocessBy != null && s.FormStatus == (int)CommonResources.EASStatus.IN_PROGRESS)
        //                                select s).ToList();


        //        var recordCount = (attendanceModReqs.Count - hrbpVerification.Count);
        //        if (6 > recordCount)
        //        {
        //            recordCount = 6 - recordCount;
        //        }
        //        else
        //        {
        //            header.Approver = "HRBP";
        //            recordCount = 6;
        //        }

        //        List<TbAttendanceModificationDetail> newRecords = new List<TbAttendanceModificationDetail>();
        //        for (int i = 0; i < (recordCount - header.Records.Count(d => d.Nature == "Missing")); i++)
        //        {
        //            header.Records.Add(new AttendanceAdjustment() { Nature = "New" });
        //        }
        //    }
        //    return header;
        //}

        //public Message<string> UpdateSubmissionDetail(string mobile, AdjustmentHeader data)
        //{
        //    try
        //    {

        //        CommonResources.EASStatus Status = CommonResources.EASStatus.IN_PROGRESS;
        //        Models.UserRole HRBP = null;
        //        Models.UserRole AttendanceOficer = null;
        //        DateTime recordDateTime;
        //        List<TbAttendanceModificationDetail> newRecords = new List<TbAttendanceModificationDetail>();

        //        var eas = new EASBL(_AppDbContext, _EASDbContext);
        //        var user = _AppDbContext.Users.FirstOrDefault(d => d.Mobile.EndsWith(mobile));
        //        if (user != null && user.SAPNumber != null)
        //        {
        //            DateTime localTime = eas.GetLocalTimeOfUser(user.PersonnelArea);
        //            eas.LoadHRBPDetails(ref AttendanceOficer, ref HRBP, user);
        //            var supervisor = eas.GetSupervisor_ESB(user.Email, "App");
        //            var submissions = eas.GetValidateRecords(user.Code);

        //            var region = eas.GetRegion(user.SAPNumber);
        //            if (region == null)
        //            {
        //                throw new Exception("Employee region does not found!!");
        //            }



        //            DateTime preMonth = DateTime.Now.AddMonths(-1);
        //            int correctionEnable = region.DayEnd + 3;
        //            var lastPayrollPeriod = new
        //            {
        //                start = new DateTime(preMonth.Year, preMonth.Month, region.DayStart).Date,
        //                end = new DateTime(DateTime.Now.Year, DateTime.Now.Month, region.DayEnd).Date
        //            };

        //            /// Missing Records
        //            foreach (var row in data.Records.Where(d => d.Nature != "New"))
        //            {

        //                if (!(!string.IsNullOrEmpty(row.Day) && !string.IsNullOrEmpty(row.Time) &&
        //                    !string.IsNullOrEmpty(row.Type) && !string.IsNullOrEmpty(row.Location) && !string.IsNullOrEmpty(row.Reason)))
        //                {
        //                    throw new Exception("Invalid Record. Date,Time,Status & Reason is required, Day:" + row.Day);
        //                }


        //                if (!DateTime.TryParseExact(row.Day + " " + row.Time, new string[] { "d/M/yyyy H:mm" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out recordDateTime))
        //                {
        //                    throw new Exception("Invalid Date format ( day:d/M/yyyy time:H:mm)");
        //                }

        //                if (localTime < recordDateTime)
        //                {
        //                    throw new Exception("Invalid Record: " + recordDateTime + " should be less than  " + localTime + " (local time) : Day " + row.Day);
        //                }
        //                else
        //                {
        //                    var isExist = eas.IsAttendanceByRunDate(recordDateTime.Date, user.SAPNumber, row.Type);
        //                    if (!isExist || row.Type != "IN")
        //                    {
        //                        if (DateTime.Now.Date <= new DateTime(DateTime.Now.Year, DateTime.Now.Month, correctionEnable).Date)
        //                        {
        //                            if (!(recordDateTime.Date >= lastPayrollPeriod.start && recordDateTime.Date <= new DateTime(DateTime.Now.Year, DateTime.Now.Month, correctionEnable).Date))
        //                            {
        //                                throw new Exception("Invalid Record: " + recordDateTime + "- PayRoll Period Closed");
        //                            }
        //                        }
        //                        else
        //                        {
        //                            if (!(recordDateTime.Date >= lastPayrollPeriod.end))
        //                            {
        //                                throw new Exception("Invalid Record :" + recordDateTime + "- PayRoll Period Closed");
        //                            }
        //                        }

        //                        newRecords.Add(new TbAttendanceModificationDetail()
        //                        {
        //                            AttendanceDateTime = recordDateTime,
        //                            ActualTime = DateTime.Now,
        //                            Status = row.Type,
        //                            InsertedDateTime = DateTime.Now,
        //                            LocationCode = row.Location,
        //                            DblocationCode = row.Location,
        //                            SapemployeeNo = user.SAPNumber,
        //                            RecordNature = "Missing",
        //                            Remark = row.Reason,
        //                            RequestBy = user.Code,
        //                            RequestDateTime = DateTime.Now,
        //                            ApprovedBy = supervisor.Code,
        //                            HrapprovedBy = AttendanceOficer.Code,
        //                            FormStatus = (int)CommonResources.EASStatus.IN_PROGRESS,
        //                            Hrbpremark = string.Empty
        //                        });
        //                    }
        //                    else
        //                    {
        //                        throw new Exception($"Record already exist for given day {row.Day} {row.Time}");
        //                    }
        //                }
        //            }

        //            recordDateTime = new DateTime();

        //            /// New Records
        //            foreach (var row in data.Records.Where(d => d.Nature == "New"))
        //            {
        //                //dd/mm/yyyy
        //                if (!(!string.IsNullOrEmpty(row.Day) && !string.IsNullOrEmpty(row.Time) &&
        //                !string.IsNullOrEmpty(row.Type) && !string.IsNullOrEmpty(row.Location) && !string.IsNullOrEmpty(row.Reason)))
        //                {
        //                    continue;
        //                }

        //                //throw new Exception("Invalid missing record, Day" + row.Day);

        //                if (!DateTime.TryParseExact(row.Day + " " + row.Time, new string[] { "d/M/yyyy H:mm" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out recordDateTime))
        //                {
        //                    throw new Exception("Invalid Date format ( day:d/M/yyyy time:H:mm)");
        //                }

        //                if (localTime < recordDateTime)
        //                {
        //                    throw new Exception("Invalid Record: " + recordDateTime + " should be less than  " + localTime + " (local time) : Day " + row.Day);
        //                }
        //                else
        //                {
        //                    var isExist = eas.IsAttendanceByRunDate(recordDateTime.Date, user.SAPNumber, row.Type);
        //                    if (!isExist || row.Status != "IN")
        //                    {

        //                        eas.CheckRecordAlreadySubmit(recordDateTime, row.Type, user.SAPNumber);
        //                        if (DateTime.Now.Date <= new DateTime(DateTime.Now.Year, DateTime.Now.Month, correctionEnable).Date)
        //                        {
        //                            if (!(recordDateTime.Date >= lastPayrollPeriod.start && recordDateTime.Date <= new DateTime(DateTime.Now.Year, DateTime.Now.Month, correctionEnable).Date))
        //                            {
        //                                throw new Exception("Invalid Record: " + recordDateTime + "- PayRoll Period Closed");
        //                            }
        //                        }
        //                        else
        //                        {
        //                            if (!(recordDateTime.Date >= lastPayrollPeriod.end))
        //                            {
        //                                throw new Exception("Invalid Record: " + recordDateTime + "- PayRoll Period Closed");
        //                            }
        //                        }

        //                        newRecords.Add(new TbAttendanceModificationDetail()
        //                        {
        //                            AttendanceDateTime = recordDateTime,
        //                            ActualTime = DateTime.Now,
        //                            Status = row.Type,
        //                            InsertedDateTime = DateTime.Now,
        //                            LocationCode = row.Location,
        //                            DblocationCode = row.Location,
        //                            SapemployeeNo = user.SAPNumber,
        //                            RecordNature = "New",
        //                            Remark = row.Reason,
        //                            RequestBy = user.Code,
        //                            RequestDateTime = DateTime.Now,
        //                            ApprovedBy = supervisor.Code,
        //                            HrapprovedBy = AttendanceOficer.Code,
        //                            FormStatus = (int)CommonResources.EASStatus.IN_PROGRESS,
        //                            Hrbpremark = string.Empty,
        //                            IsDeleted = false
        //                        });
        //                    }
        //                    else
        //                    {
        //                        throw new Exception($"Record already exist for given day {row.Day} {row.Time}");
        //                    }
        //                }
        //            }

        //            var requests = eas.AttendaceRequestForPeriod(correctionEnable, user.SAPNumber, lastPayrollPeriod.start, lastPayrollPeriod.end);

        //            var hrbpVerification = (from s in requests
        //                                    where s.FormStatus == (int)CommonResources.EASStatus.HRBP_IN_PROGRESS
        //                                    || (s.HrbpprocessBy != null && s.FormStatus == (int)CommonResources.EASStatus.APPROVED)
        //                                    || (s.HrbpprocessBy != null && s.FormStatus == (int)CommonResources.EASStatus.IN_PROGRESS)
        //                                    select s).ToList();

        //            if (((requests.Count - hrbpVerification.Count) + newRecords.Count()) > 6)
        //            {
        //                if (!(supervisor.Email == HRBP.Email // supervisor & HRBP is same
        //                  || user.Email == HRBP.Email)) // Current User & HRBP is same 
        //                {
        //                    Status = CommonResources.EASStatus.HRBP_IN_PROGRESS;
        //                    foreach (var item in newRecords)
        //                    {
        //                        item.FormStatus = (int)CommonResources.EASStatus.HRBP_IN_PROGRESS;
        //                    }
        //                }
        //            }

        //            if (newRecords.Count > 0)
        //            {
        //                /// insert all
        //                eas.InsertALL(newRecords);

        //                string content1 = string.Empty;
        //                content1 = AttModificationMailContent(newRecords, content1, user.Name);

        //                string content2 = string.Empty;
        //                content2 = AttNewMailContent(newRecords, content2, user.Name);

        //                string CurrentProcessrNote = " & currently awaiting approval by ";
        //                if (Status == CommonResources.EASStatus.HRBP_IN_PROGRESS)
        //                {
        //                    CurrentProcessrNote += (HRBP.Name + " ( HR business partner )");
        //                    string[] HRBPUsers = new string[] { HRBP.Email };
        //                    //send email
        //                    // SendNotificationHRBP(AttendanceOficer.Name, supervisor.Name, HRBP.Name, 
        //                    //HRBPUsers, content1, content2, string.Empty, supervisor.Code, user.Name);
        //                }
        //                else if (Status == CommonResources.EASStatus.IN_PROGRESS)
        //                {
        //                    CurrentProcessrNote += (supervisor.Name + " ( Supervisor )");
        //                    string[] hod = new string[] { supervisor.Email };
        //                    //send email
        //                    //SendNotification(AttendanceOficer.Name, supervisor.Name, hod, content1, content2, string.Empty, supervisor.Code,
        //                    // String.Join(",", newRecords.Select(d => d.RnAttendanceId)), user.Name);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Message<string>() { Text = ex.Message, StatusCode = "E", Result = "FAIL" };
        //    }
        //    return new Message<string>() { StatusCode = "S", Text = "", Result = "Sucess" };
        //}


        //private string AttNewMailContent(List<TbAttendanceModificationDetail> details, string content2, string currentUserName)
        //{
        //    if (details.Where(s => s.RecordNature == "New").Count() > 0)
        //    {
        //        content2 = currentUserName + " has added the following <b>new attendance</b> records for <b> IN/OUT</b> records.<br /><br /><table style='width:450px;'>";
        //        foreach (var item in details.Where(s => s.RecordNature == "New"))
        //        {
        //            content2 += "<tr>";

        //            content2 += "<td>";
        //            content2 += item.SapemployeeNo;
        //            content2 += "</td>";

        //            content2 += "<td>";
        //            content2 += item.Status;
        //            content2 += "</td>";

        //            content2 += "<td>";
        //            content2 += item.AttendanceDateTime.ToShortDateString();
        //            content2 += "</td>";

        //            content2 += "<td>";
        //            content2 += item.AttendanceDateTime.ToShortTimeString();
        //            content2 += "</td>";

        //            content2 += "<td>";
        //            content2 += item.Remark;
        //            content2 += "</td>";

        //            content2 += "</tr>";

        //        }
        //        content2 += "</table>";
        //    }
        //    return content2;
        //}

        //private string AttModificationMailContent(List<TbAttendanceModificationDetail> details, string content1, string currentUserName)
        //{
        //    if (details.Where(s => s.RecordNature == "Missing").Count() > 0)
        //    {
        //        content1 = currentUserName + " has added the following <b>missing time attendance</b> of <b>either IN or OUT</b> records.<br /> <br /><table style='width:450px;'>";
        //        foreach (var item in details.Where(s => s.RecordNature == "Missing"))
        //        {
        //            content1 += "<tr>";

        //            content1 += "<td>";
        //            content1 += item.SapemployeeNo;
        //            content1 += "</td>";

        //            content1 += "<td>";
        //            content1 += item.Status;
        //            content1 += "</td>";

        //            content1 += "<td>";
        //            content1 += item.AttendanceDateTime.ToShortDateString();
        //            content1 += "</td>";

        //            content1 += "<td>";
        //            content1 += item.AttendanceDateTime.ToShortTimeString();
        //            content1 += "</td>";

        //            content1 += "<td>";
        //            content1 += item.Remark;
        //            content1 += "</td>";

        //            content1 += "</tr>";

        //        }
        //        content1 += "</table>";
        //    }
        //    return content1;
        //}

        //public void SendNotification(string HRPerson, string Supervisor, string[] emailUsers, string Content1,
        //    string Content2, string Content3, int approveUSRID, string _idList, string currentUserName)
        //{
        //    var mailBody = String.Empty;
        //    System.Net.Mail.Attachment attachment;
        //    string emailSubject = "Attendance Record Modification - " + currentUserName;
        //    List<System.Net.Mail.Attachment> list = new List<System.Net.Mail.Attachment>();

        //    StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\Mail\\MailTempalte02.html");
        //    mailBody = sr.ReadToEnd();
        //    sr.Close();

        //    attachment = new System.Net.Mail.Attachment(Directory.GetCurrentDirectory() + "\\Images\\Midas_Logo_New_Resized.png");
        //    attachment.ContentDisposition.Inline = false;
        //    attachment.ContentId = "img001logo";
        //    list.Add(attachment);//signature logo

        //    attachment = new System.Net.Mail.Attachment(Directory.GetCurrentDirectory() + "\\Images\\banner.png");
        //    attachment.ContentDisposition.Inline = false;
        //    attachment.ContentId = "img002logo";
        //    list.Add(attachment);//signature logo

        //    mailBody = mailBody.Replace("#HRPERSON#", HRPerson);
        //    mailBody = mailBody.Replace("#SUPERVISOR#", Supervisor);
        //    mailBody = mailBody.Replace("#SENDER#", currentUserName);
        //    mailBody = mailBody.Replace("#TABLE01#", Content1);
        //    mailBody = mailBody.Replace("#TABLE02#", Content2);
        //    mailBody = mailBody.Replace("#TABLE03#", Content3);
        //    // mailBody = mailBody.Replace("#Reason#", reason);
        //    mailBody = mailBody.Replace("#HRBPREMARK#", string.Empty);

        //    mailBody = mailBody.Replace("#REJECTLINK#", string.Format("http://eas.midassit.com/ProcessRequest.aspx?rq={0}", CommonResources.Base64Encode(string.Format("{0}-{1}-{2}", "R", _idList, approveUSRID))));
        //    mailBody = mailBody.Replace("#APPROVEDLINK#", string.Format("http://eas.midassit.com/ProcessRequest.aspx?rq={0}", CommonResources.Base64Encode(string.Format("{0}-{1}-{2}", "A", _idList, approveUSRID))));
        //    // mailBody = mailBody.Replace("#VIEWLINK#", string.Format("http://eas.midassit.com/ProcessRequest.aspx?rq={0}", CommonResource.Base64Encode(string.Format("{0}-{1}-{2}", "V", 0, approveUSRID))));


        //    mailBody = mailBody.Replace("#IMAGE_URL#", "cid:img001logo");
        //    mailBody = mailBody.Replace("#IMAGE_BANNER#", "cid:img002logo");

        //    ///TESTING
        //    ///

        //    sendAsync(emailUsers, new string[] { }, emailSubject, mailBody, list);
        //}


        //public void SendNotificationHRBP(string HRPerson, string Supervisor, string HRBP, string[] emailUsers, string Content1,
        //    string Content2, string Content3, int approveUSRID, string currentUserName)
        //{
        //    var mailBody = String.Empty;
        //    System.Net.Mail.Attachment attachment;
        //    string emailSubject = "Attendance Record Modification - " + currentUserName;
        //    List<System.Net.Mail.Attachment> list = new List<System.Net.Mail.Attachment>();

        //    StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\Mail\\MailTempalte05.html");
        //    mailBody = sr.ReadToEnd();
        //    sr.Close();

        //    attachment = new System.Net.Mail.Attachment(Directory.GetCurrentDirectory() + "\\Images\\Midas_Logo_New_Resized.png");
        //    attachment.ContentDisposition.Inline = false;
        //    attachment.ContentId = "img001logo";
        //    list.Add(attachment);//signature logo

        //    attachment = new System.Net.Mail.Attachment(Directory.GetCurrentDirectory() + "\\Images\\banner.png");
        //    attachment.ContentDisposition.Inline = false;
        //    attachment.ContentId = "img002logo";
        //    list.Add(attachment);//signature logo

        //    mailBody = mailBody.Replace("#HRBP#", HRBP);
        //    mailBody = mailBody.Replace("#HRPERSON#", HRPerson);
        //    mailBody = mailBody.Replace("#SUPERVISOR#", Supervisor);
        //    mailBody = mailBody.Replace("#SENDER#", currentUserName);
        //    mailBody = mailBody.Replace("#TABLE01#", Content1);
        //    mailBody = mailBody.Replace("#TABLE02#", Content2);
        //    mailBody = mailBody.Replace("#TABLE03#", Content3);
        //    // mailBody = mailBody.Replace("#Reason#", reason);




        //    mailBody = mailBody.Replace("#IMAGE_URL#", "cid:img001logo");
        //    mailBody = mailBody.Replace("#IMAGE_BANNER#", "cid:img002logo");


        //    sendAsync(emailUsers, new string[] { }, emailSubject, mailBody, list);
        //}

        //public void SendNotificationToUser(string HRPerson,
        //    string Supervisor, string[] emailUsers, string[] cc, string Content1, string Content2, string Content3, string currentProcessor, string currentUserName)
        //{
        //    var mailBody = String.Empty;
        //    System.Net.Mail.Attachment attachment;
        //    string emailSubject = "Attendance Record Modification - " + currentUserName;
        //    List<System.Net.Mail.Attachment> list = new List<System.Net.Mail.Attachment>();


        //    StreamReader sr = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "\\Mail\\MailTempalte04.html"));
        //    mailBody = sr.ReadToEnd();
        //    sr.Close();

        //    attachment = new System.Net.Mail.Attachment(Path.Combine(Directory.GetCurrentDirectory(), "\\Images\\Midas_Logo_New_Resized.png"));
        //    attachment.ContentDisposition.Inline = false;
        //    attachment.ContentId = "img001logo";
        //    list.Add(attachment);//signature logo

        //    attachment = new System.Net.Mail.Attachment(Path.Combine(Directory.GetCurrentDirectory(), "\\images\\banner.png"));
        //    attachment.ContentDisposition.Inline = false;
        //    attachment.ContentId = "img002logo";
        //    list.Add(attachment);//signature logo

        //    mailBody = mailBody.Replace("#HRPERSON#", HRPerson);
        //    mailBody = mailBody.Replace("#SENDER#", currentUserName);
        //    mailBody = mailBody.Replace("#TABLE01#", Content1);
        //    mailBody = mailBody.Replace("#TABLE02#", Content2);
        //    mailBody = mailBody.Replace("#TABLE03#", Content3);
        //    mailBody = mailBody.Replace("#SUPERVISOR#", Supervisor);
        //    mailBody = mailBody.Replace("#CURRNETAPPROVEBY#", currentProcessor);

        //    mailBody = mailBody.Replace("#IMAGE_URL#", "cid:img001logo");
        //    mailBody = mailBody.Replace("#IMAGE_BANNER#", "cid:img002logo");


        //    sendAsync(emailUsers, cc, emailSubject, mailBody, list);
        //}


        //private void sendAsync(string[] email, string[] cc, string emailSubject, string emailBody, List<System.Net.Mail.Attachment> att)
        //{
        //    Extensions.SendMailBL.Send(email, cc, emailSubject, emailBody, string.Empty, att);
        //}

        //public bool UpdateMobile(string mobile, string sapNumber)
        //{
        //    var easServices = new EASBL(_AppDbContext, _EASDbContext);
        //    return easServices.UpdateMobile(mobile, sapNumber);
        //}

        //public TbSapemployee GetSAPEmployeeDetails(string sapNumber)
        //{
        //    var easServices = new EASBL(_AppDbContext, _EASDbContext);
        //    return easServices.GetSAPEmployee(sapNumber);
        //}

        //public TbSapemployee GetSAPEmployeeDetailsByMobile(string mobile)
        //{
        //    var easServices = new EASBL(_AppDbContext, _EASDbContext);
        //    return easServices.GetSAPEmployee(mobile);
        //}

        //public TbCredentials SAPCredentials(CommonResources.SAPServices service)
        //{
        //    var easServices = new EASBL(_AppDbContext, _EASDbContext);
        //    return easServices.GetCurrentSAPCredentials(service);
        //}

        //public List<Profile> GetEmployeeByRegion(string region)
        //{
        //    return (from d in _AppDbContext.Users
        //            where d.Region == region &&
        //           ((d.PermanentAddress != string.Empty && d.PermanentAddress != null) ||
        //             (d.TemporaryAddress != string.Empty && d.TemporaryAddress != null))

        //            select new Profile()
        //            {
        //                Name = $"{d.Name} {d.LastName}",
        //                BloodGroup = d.BloodGroup ?? string.Empty,
        //                EmployeeID = d.SAPNumber,
        //                Nationality = d.Nationality ?? string.Empty,
        //                NIC = d.CNICNumber ?? string.Empty,
        //                PermanentAddress = new AddressModel()
        //                {
        //                    Address = d.PermanentAddress ?? string.Empty,
        //                    Lat = d.PermanentAddrLat ?? 0,
        //                    Lon = d.PermanentAddrLon ?? 0
        //                },
        //                TemporaryAddress = new AddressModel()
        //                {
        //                    Address = d.TemporaryAddress ?? string.Empty,
        //                    Lat = d.TemporaryAddrLat ?? 0,
        //                    Lon = d.TemporaryAddrLon ?? 0
        //                },
        //                DateofBirth = $"{d.DayOfBirth}/{d.MonthOfBirth}/{d.YearofBirth}",
        //                BusinessUnit = d.BusinessUnit ?? string.Empty,
        //                Department = d.SAPDepartment ?? string.Empty,
        //                IsImageSet = d.IsImageSync
        //            }).ToList();
        //}

        //public List<Profile> GetEmployeeBasicInfoByPA(string factory)
        //{
        //    return (from d in _AppDbContext.Users
        //            where d.PersonnelArea == factory &&
        //           ((d.PermanentAddress != string.Empty && d.PermanentAddress != null) ||
        //             (d.TemporaryAddress != string.Empty && d.TemporaryAddress != null))

        //            select new Profile()
        //            {
        //                Name = $"{d.Name} {d.LastName}",
        //                BloodGroup = d.BloodGroup ?? string.Empty,
        //                EmployeeID = d.SAPNumber,
        //                Nationality = d.Nationality ?? string.Empty,
        //                NIC = d.CNICNumber ?? string.Empty,
        //                PermanentAddress = new AddressModel()
        //                {
        //                    Address = d.PermanentAddress ?? string.Empty,
        //                    Lat = d.PermanentAddrLat ?? 0,
        //                    Lon = d.PermanentAddrLon ?? 0
        //                },
        //                TemporaryAddress = new AddressModel()
        //                {
        //                    Address = d.TemporaryAddress ?? string.Empty,
        //                    Lat = d.TemporaryAddrLat ?? 0,
        //                    Lon = d.TemporaryAddrLon ?? 0
        //                },
        //                DateofBirth = $"{d.DayOfBirth}/{d.MonthOfBirth}/{d.YearofBirth}",
        //                BusinessUnit = d.BusinessUnit ?? string.Empty,
        //                Department = d.SAPDepartment ?? string.Empty,
        //                IsImageSet = d.IsImageSync
        //            }).ToList();
        //}

        //public List<Profile> GetEmployeeBasicInfoByPA(string factory, string department)
        //{
        //    return (from d in _AppDbContext.Users
        //            where d.PersonnelArea == factory &&
        //           ((d.PermanentAddress != string.Empty && d.PermanentAddress != null) ||
        //             (d.TemporaryAddress != string.Empty && d.TemporaryAddress != null))
        //             && d.SAPDepartment.ToLower() == department.ToLower()
        //            select new Profile()
        //            {
        //                Name = $"{d.Name} {d.LastName}",
        //                BloodGroup = d.BloodGroup ?? string.Empty,
        //                EmployeeID = d.SAPNumber,
        //                Nationality = d.Nationality ?? string.Empty,
        //                NIC = d.CNICNumber ?? string.Empty,
        //                PermanentAddress = new AddressModel()
        //                {
        //                    Address = d.PermanentAddress ?? string.Empty,
        //                    Lat = d.PermanentAddrLat ?? 0,
        //                    Lon = d.PermanentAddrLon ?? 0
        //                },
        //                TemporaryAddress = new AddressModel()
        //                {
        //                    Address = d.TemporaryAddress ?? string.Empty,
        //                    Lat = d.TemporaryAddrLat ?? 0,
        //                    Lon = d.TemporaryAddrLon ?? 0
        //                },
        //                DateofBirth = $"{d.DayOfBirth}/{d.MonthOfBirth}/{d.YearofBirth}",
        //                BusinessUnit = d.BusinessUnit ?? string.Empty,
        //                Department = d.SAPDepartment ?? string.Empty,
        //                IsImageSet = d.IsImageSync
        //            }).ToList();
        //}

        //public List<Profile> GetEmployeeBasicinfoByRoute(string factory, string pickupType, int code)
        //{
        //    switch (pickupType)
        //    {
        //        case "PICK1":
        //            return (from d in _AppDbContext.Employees
        //                    where d.PersonnelArea == factory &&
        //                     (d.PickupPoint1AddrLat > 0 && d.PickupPoint1AddrLon > 0) &&
        //                     ((code == 0) || (code > 0 && d.PickupPoint1RouteCode == code))
        //                    select new Profile()
        //                    {
        //                        Name = $"{d.Name} {d.LastName}",
        //                        BloodGroup = d.BloodGroup ?? string.Empty,
        //                        EmployeeID = d.SAPNumber,
        //                        Nationality = d.Nationality ?? string.Empty,
        //                        NIC = d.CNICNumber ?? string.Empty,
        //                        PermanentAddress = new AddressModel()
        //                        {
        //                            Address = d.PermanentAddress ?? string.Empty,
        //                            Lat = d.PermanentAddrLat ?? 0,
        //                            Lon = d.PermanentAddrLon ?? 0
        //                        },
        //                        TemporaryAddress = new AddressModel()
        //                        {
        //                            Address = d.TemporaryAddress ?? string.Empty,
        //                            Lat = d.TemporaryAddrLat ?? 0,
        //                            Lon = d.TemporaryAddrLon ?? 0
        //                        },
        //                        PickupPoint1Address = new AddressModel()
        //                        {
        //                            Address = d.PickupPoint1Address ?? string.Empty,
        //                            Lat = d.PickupPoint1AddrLat ?? 0,
        //                            Lon = d.PickupPoint1AddrLon ?? 0
        //                        },
        //                        PickupPoint2Address = new AddressModel()
        //                        {
        //                            Address = d.PickupPoint2Address ?? string.Empty,
        //                            Lat = d.PickupPoint2AddrLat ?? 0,
        //                            Lon = d.PickupPoint2AddrLon ?? 0
        //                        },
        //                        DateofBirth = $"{d.DayOfBirth}/{d.MonthOfBirth}/{d.YearofBirth}",
        //                        BusinessUnit = d.BusinessUnit ?? string.Empty,
        //                        Department = d.SAPDepartment ?? string.Empty,
        //                        IsImageSet = d.IsImageSync
        //                    }).ToList();
        //        case "PICK2":
        //            return (from d in _AppDbContext.Employees
        //                    where d.PersonnelArea == factory &&
        //                    (d.PickupPoint2AddrLat > 0 && d.PickupPoint2AddrLon > 0) &&
        //                     ((code == 0) || (code > 0 && d.PickupPoint2RouteCode == code))
        //                    select new Profile()
        //                    {
        //                        Name = $"{d.Name} {d.LastName}",
        //                        BloodGroup = d.BloodGroup ?? string.Empty,
        //                        EmployeeID = d.SAPNumber,
        //                        Nationality = d.Nationality ?? string.Empty,
        //                        NIC = d.CNICNumber ?? string.Empty,
        //                        PermanentAddress = new AddressModel()
        //                        {
        //                            Address = d.PermanentAddress ?? string.Empty,
        //                            Lat = d.PermanentAddrLat ?? 0,
        //                            Lon = d.PermanentAddrLon ?? 0
        //                        },
        //                        TemporaryAddress = new AddressModel()
        //                        {
        //                            Address = d.TemporaryAddress ?? string.Empty,
        //                            Lat = d.TemporaryAddrLat ?? 0,
        //                            Lon = d.TemporaryAddrLon ?? 0
        //                        },
        //                        PickupPoint1Address = new AddressModel()
        //                        {
        //                            Address = d.PickupPoint1Address ?? string.Empty,
        //                            Lat = d.PickupPoint1AddrLat ?? 0,
        //                            Lon = d.PickupPoint1AddrLon ?? 0
        //                        },
        //                        PickupPoint2Address = new AddressModel()
        //                        {
        //                            Address = d.PickupPoint2Address ?? string.Empty,
        //                            Lat = d.PickupPoint2AddrLat ?? 0,
        //                            Lon = d.PickupPoint2AddrLon ?? 0
        //                        },
        //                        DateofBirth = $"{d.DayOfBirth}/{d.MonthOfBirth}/{d.YearofBirth}",
        //                        BusinessUnit = d.BusinessUnit ?? string.Empty,
        //                        Department = d.SAPDepartment ?? string.Empty,
        //                        IsImageSet = d.IsImageSync
        //                    }).ToList();
        //        default:
        //            return (from d in _AppDbContext.Employees
        //                    where d.PersonnelArea == factory &&
        //                   ((d.PickupPoint2AddrLat > 0 && d.PickupPoint2AddrLon > 0) ||
        //                    (d.PickupPoint1AddrLat > 0 && d.PickupPoint1AddrLon > 0))
        //                    select new Profile()
        //                    {
        //                        Name = $"{d.Name} {d.LastName}",
        //                        BloodGroup = d.BloodGroup ?? string.Empty,
        //                        EmployeeID = d.SAPNumber,
        //                        Nationality = d.Nationality ?? string.Empty,
        //                        NIC = d.CNICNumber ?? string.Empty,
        //                        PermanentAddress = new AddressModel()
        //                        {
        //                            Address = d.PermanentAddress ?? string.Empty,
        //                            Lat = d.PermanentAddrLat ?? 0,
        //                            Lon = d.PermanentAddrLon ?? 0
        //                        },
        //                        TemporaryAddress = new AddressModel()
        //                        {
        //                            Address = d.TemporaryAddress ?? string.Empty,
        //                            Lat = d.TemporaryAddrLat ?? 0,
        //                            Lon = d.TemporaryAddrLon ?? 0
        //                        },
        //                        PickupPoint1Address = new AddressModel()
        //                        {
        //                            Address = d.PickupPoint1Address ?? string.Empty,
        //                            Lat = d.PickupPoint1AddrLat ?? 0,
        //                            Lon = d.PickupPoint1AddrLon ?? 0
        //                        },
        //                        PickupPoint2Address = new AddressModel()
        //                        {
        //                            Address = d.PickupPoint2Address ?? string.Empty,
        //                            Lat = d.PickupPoint2AddrLat ?? 0,
        //                            Lon = d.PickupPoint2AddrLon ?? 0
        //                        },
        //                        DateofBirth = $"{d.DayOfBirth}/{d.MonthOfBirth}/{d.YearofBirth}",
        //                        BusinessUnit = d.BusinessUnit ?? string.Empty,
        //                        Department = d.SAPDepartment ?? string.Empty,
        //                        IsImageSet = d.IsImageSync
        //                    }).ToList();
        //    }

        //}

        //IEnumerable<AbpUser> IAbpUser.GetAll(string mobile)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
