using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;

namespace Boss_Project_Az
{
    public class SearchJob
    {
        private UserData userData;
        private JobData jobData;

        public SearchJob()
        {
            userData = JsonDataManager.LoadUserData();
            jobData = JsonDataManager.LoadJobData();
        }

        public void RegisterJobWorker()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"

                                   ▄▀▀█▄▄   ▄▀▀▀▀▄   ▄▀▀▀▀▄  ▄▀▀▀▀▄ 
                                  ▐ ▄▀   █ █      █ █ █   ▐ █ █   ▐ 
                                    █▄▄▄▀  █      █    ▀▄      ▀▄   
                                    █   █  ▀▄    ▄▀ ▀▄   █  ▀▄   █  
                                   ▄▀▄▄▄▀    ▀▀▀▀    █▀▀▀    █▀▀▀   
                                  █    ▐             ▐       ▐      
                                  ▐                                 
");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t\tWorker Register");
            Console.Write("\t\t\t\t\tEnter mail: ");
            string mail = Console.ReadLine();
            Console.Write("\t\t\t\t\tEnter password: ");
            string password = Console.ReadLine();

            var newWorker = new Worker
            {
                Id = userData.Workers.Count + 1,
                WorkerMail = mail,
                WorkerPassword = password
            };

            userData.Workers.Add(newWorker);
            JsonDataManager.SaveUserData(userData);
        }

        public void RegisterJobEmployer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"

                                   ▄▀▀█▄▄   ▄▀▀▀▀▄   ▄▀▀▀▀▄  ▄▀▀▀▀▄ 
                                  ▐ ▄▀   █ █      █ █ █   ▐ █ █   ▐ 
                                    █▄▄▄▀  █      █    ▀▄      ▀▄   
                                    █   █  ▀▄    ▄▀ ▀▄   █  ▀▄   █  
                                   ▄▀▄▄▄▀    ▀▀▀▀    █▀▀▀    █▀▀▀   
                                  █    ▐             ▐       ▐      
                                  ▐                                 
");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t\tEmployer Register");
            Console.Write("\t\t\t\t\tEnter mail: ");
            string mail = Console.ReadLine();
            Console.Write("\t\t\t\t\tEnter password: ");
            string password = Console.ReadLine();

            var newEmployer = new JobEmployer
            {
                Id = userData.Employers.Count + 1,
                EmployerMail = mail,
                EmployerPassword = password
            };

            userData.Employers.Add(newEmployer);
            JsonDataManager.SaveUserData(userData);
        }

        public void CreateJobPosting(JobEmployer Employer)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"

                                   ▄▀▀█▄▄   ▄▀▀▀▀▄   ▄▀▀▀▀▄  ▄▀▀▀▀▄ 
                                  ▐ ▄▀   █ █      █ █ █   ▐ █ █   ▐ 
                                    █▄▄▄▀  █      █    ▀▄      ▀▄   
                                    █   █  ▀▄    ▄▀ ▀▄   █  ▀▄   █  
                                   ▄▀▄▄▄▀    ▀▀▀▀    █▀▀▀    █▀▀▀   
                                  █    ▐             ▐       ▐      
                                  ▐                                 
");
            Console.ResetColor();
            Console.WriteLine("Create Job Posting\n");
            Console.Write("\t\t\t\t\tEnter Job Name: ");
            string jobName = Console.ReadLine();
            Console.Write("\t\t\t\t\tEnter Job Info: ");
            string jobInfo = Console.ReadLine();
            Console.Write("\t\t\t\t\tEnter Job Salary: ");
            double jobSalary = double.Parse(Console.ReadLine());

            int jobId = jobData.JobPostings.Count > 0 ? jobData.JobPostings.Max(j => j.JobId) + 1 : 1;

            var newJob = new JobSearcing
            {
                JobId = jobId,
                JobName = jobName,
                JobInfo = jobInfo,
                JobSalary = jobSalary,
                CreatedByEmployerId = Employer.Id
            };

            jobData.JobPostings.Add(newJob);
            JsonDataManager.SaveJobData(jobData);
            Console.WriteLine("\t\t\t\t\tJob posting created successfully!");
        }

        public void JobList()
        {
            Console.Clear();
            foreach (var item in jobData.JobPostings)
            {
                Console.WriteLine($"\t\t\t\t\tJob Id: {item.JobId}");
                Console.WriteLine($"\t\t\t\t\tJob Name: {item.JobName}");
                Console.WriteLine($"\t\t\t\t\tJob Info: {item.JobInfo}");
                Console.WriteLine($"\t\t\t\t\tJob Salary: {item.JobSalary}");
                Console.WriteLine();
            }
        }

        public void CreateWorkerCV(Worker worker)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"

                                   ▄▀▀█▄▄   ▄▀▀▀▀▄   ▄▀▀▀▀▄  ▄▀▀▀▀▄ 
                                  ▐ ▄▀   █ █      █ █ █   ▐ █ █   ▐ 
                                    █▄▄▄▀  █      █    ▀▄      ▀▄   
                                    █   █  ▀▄    ▄▀ ▀▄   █  ▀▄   █  
                                   ▄▀▄▄▄▀    ▀▀▀▀    █▀▀▀    █▀▀▀   
                                  █    ▐             ▐       ▐      
                                  ▐                                 
");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t\tCreate Worker CV\n");

            Console.Write("\t\t\t\t\tEnter Name: ");
            string name = Console.ReadLine();
            Console.Write("\t\t\t\t\tEnter Surname: ");
            string surname = Console.ReadLine();
            Console.Write("\t\t\t\t\tEnter Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("\t\t\t\t\tEnter Address: ");
            string address = Console.ReadLine();
            Console.Write("\t\t\t\t\tEnter Skills (comma separated): ");
            string skillsInput = Console.ReadLine();

            List<string> skills = skillsInput.Split(',').Select(skill => skill.Trim()).ToList();

            worker.WorkerName = name;
            worker.WorkerSurname = surname;
            worker.WorkerPhoneNumber = phoneNumber;
            worker.WorkerAddress = address;
            worker.WorkerSkill = skillsInput;

            JsonDataManager.SaveUserData(userData);

            Console.WriteLine("\t\t\t\t\tCV created successfully!");
        }

        public void ApplyToJobPosting(Worker worker)
        {
            Console.Clear();
            if (string.IsNullOrEmpty(worker.WorkerSkill))
            {
                Console.WriteLine("\t\t\t\t\tBefore Create CV.");
                Console.WriteLine("\t\t\t\t\tDo you want to create a CV now? (Y/N)");
                string response = Console.ReadLine();

                if (response.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    CreateWorkerCV(worker);
                }
                else
                {
                    Console.WriteLine("\t\t\t\t\tCV creation is required to apply for job postings.");
                    return;
                }
            }

            Console.WriteLine("\t\t\t\t\tAvailable Job Postings:");
            JobList();
            Console.Write("\t\t\t\t\tEnter the Job Id you want to apply for: ");
            int jobId = int.Parse(Console.ReadLine());

            var jobPosting = jobData.JobPostings.FirstOrDefault(job => job.JobId == jobId);

            if (jobPosting != null)
            {
                Console.WriteLine($"\t\t\t\t\tYou have successfully applied for the job: {jobPosting.JobName}");

                var Employer = userData.Employers.FirstOrDefault(o => o.Id == jobPosting.CreatedByEmployerId);
                if (Employer != null)
                {
                    Employer.StoreCV(worker.WorkerName, worker.WorkerSurname, worker.WorkerSkill);
                }
            }
            else
            {
                Console.WriteLine("\t\t\t\t\tInvalid Job Id. Application failed.");
            }

            ReturnToMainMenu();
        }


        public void ViewCVs(JobEmployer Employer)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"
                                   ▄▀▀█▄▄   ▄▀▀▀▀▄   ▄▀▀▀▀▄  ▄▀▀▀▀▄ 
                                  ▐ ▄▀   █ █      █ █ █   ▐ █ █   ▐ 
                                    █▄▄▄▀  █      █    ▀▄      ▀▄   
                                    █   █  ▀▄    ▄▀ ▀▄   █  ▀▄   █  
                                   ▄▀▄▄▄▀    ▀▀▀▀    █▀▀▀    █▀▀▀   
                                  █    ▐             ▐       ▐      
                                  ▐                                 
");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t\tView Received CVs\n");

            foreach (var cv in Employer.CVList)
            {
                Console.WriteLine($"\t\t\t\t\tWorker Name: {cv.WorkerName}");
                Console.WriteLine($"\t\t\t\t\tWorker Surname: {cv.WorkerSurname}");
                Console.WriteLine($"\t\t\t\t\tWorker Skills: {cv.WorkerSkills}");
                Console.WriteLine();
            }

            ReturnToMainMenu();
        }


        private void ReturnToMainMenu()
        {
            Console.WriteLine("\t\t\t\t\tPress Enter to return to the main menu...");
            Console.ReadLine();
        }

        public void LoginJobWorker()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"
                                   ▄▀▀█▄▄   ▄▀▀▀▀▄   ▄▀▀▀▀▄  ▄▀▀▀▀▄ 
                                  ▐ ▄▀   █ █      █ █ █   ▐ █ █   ▐ 
                                    █▄▄▄▀  █      █    ▀▄      ▀▄   
                                    █   █  ▀▄    ▄▀ ▀▄   █  ▀▄   █  
                                   ▄▀▄▄▄▀    ▀▀▀▀    █▀▀▀    █▀▀▀   
                                  █    ▐             ▐       ▐      
                                  ▐                                 

");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t\tWorker Login");
            Console.Write("\t\t\t\t\tEnter mail: ");
            string mail = Console.ReadLine();
            Console.Write("\t\t\t\t\tEnter password: ");
            string password = Console.ReadLine();

            var worker = userData.Workers.SingleOrDefault(w => w.WorkerMail == mail && w.WorkerPassword == password);

            if (worker != null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(@"
                                   ▄▀▀█▄▄   ▄▀▀▀▀▄   ▄▀▀▀▀▄  ▄▀▀▀▀▄ 
                                  ▐ ▄▀   █ █      █ █ █   ▐ █ █   ▐ 
                                    █▄▄▄▀  █      █    ▀▄      ▀▄   
                                    █   █  ▀▄    ▄▀ ▀▄   █  ▀▄   █  
                                   ▄▀▄▄▄▀    ▀▀▀▀    █▀▀▀    █▀▀▀   
                                  █    ▐             ▐       ▐      
                                  ▐                                 

");
                Console.ResetColor();
                Console.WriteLine("\t\t\t\t\t----------------- Welcome Worker -----------------\n");
                Console.WriteLine($"\t\t\t\t\tWorker Logged In: {worker.WorkerName}");
                Console.WriteLine("\t\t\t\t\t 1 - Create CV");
                Console.WriteLine("\t\t\t\t\t 2 - List Applications");
                Console.WriteLine("\t\t\t\t\t 3 - Apply to Job Posting");
                Console.WriteLine("\t\t\t\t\t 4 - Back To Login");
                Console.Write("\t\t\t\t\tEnter: ");
                int select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        CreateWorkerCV(worker);
                        break;
                    case 2:
                        JobList();
                        break;
                    case 3:
                        ApplyToJobPosting(worker);
                        break;
                    case 4:
                        JobMenu();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("\t\t\t\t\tLogin Failed. Invalid email or password.");
            }
        }

        public void LoginJobEmployer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"
                                   ▄▀▀█▄▄   ▄▀▀▀▀▄   ▄▀▀▀▀▄  ▄▀▀▀▀▄ 
                                  ▐ ▄▀   █ █      █ █ █   ▐ █ █   ▐ 
                                    █▄▄▄▀  █      █    ▀▄      ▀▄   
                                    █   █  ▀▄    ▄▀ ▀▄   █  ▀▄   █  
                                   ▄▀▄▄▄▀    ▀▀▀▀    █▀▀▀    █▀▀▀   
                                  █    ▐             ▐       ▐      
                                  ▐                                 ");
            Console.ResetColor();
            Console.WriteLine("\t\t\t\t\tEmployer Login");
            Console.Write("\t\t\t\t\tEnter mail: ");
            string mail = Console.ReadLine();
            Console.Write("\t\t\t\t\tEnter password: ");
            string password = Console.ReadLine();

            var Employer = userData.Employers.SingleOrDefault(o => o.EmployerMail == mail && o.EmployerPassword == password);

            if (Employer != null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(@"
                                   ▄▀▀█▄▄   ▄▀▀▀▀▄   ▄▀▀▀▀▄  ▄▀▀▀▀▄ 
                                  ▐ ▄▀   █ █      █ █ █   ▐ █ █   ▐ 
                                    █▄▄▄▀  █      █    ▀▄      ▀▄   
                                    █   █  ▀▄    ▄▀ ▀▄   █  ▀▄   █  
                                   ▄▀▄▄▄▀    ▀▀▀▀    █▀▀▀    █▀▀▀   
                                  █    ▐             ▐       ▐      
                                  ▐                                
");
                Console.ResetColor();
                Console.WriteLine("\t\t\t\t\tEmployer Logged In: " + Employer.EmployerName);
                Console.WriteLine("\t\t\t\t\t1 - Create Job");
                Console.WriteLine("\t\t\t\t\t2 - List Applications");
                Console.WriteLine("\t\t\t\t\t3 - Wiew CV");
                Console.WriteLine("\t\t\t\t\t4 - Back To Login");
                Console.Write("\t\t\t\t\tEnter: ");
                int select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        CreateJobPosting(Employer);
                        break;
                    case 2:
                        JobList();
                        break;
                    case 3:
                        ViewCVs(Employer);
                        break;
                    case 4:
                        JobMenu();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Login Failed.");
            }
        }

        public void JobMenu()
        {
            int selectedMenu = 1; 

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                Console.WriteLine(@"
                             ▄▀▀█▄▄   ▄▀▀▀▀▄   ▄▀▀▀▀▄  ▄▀▀▀▀▄ 
                            ▐ ▄▀   █ █      █ █ █   ▐ █ █   ▐ 
                              █▄▄▄▀  █      █    ▀▄      ▀▄   
                              █   █  ▀▄    ▄▀ ▀▄   █  ▀▄   █  
                             ▄▀▄▄▄▀    ▀▀▀▀    █▀▀▀    █▀▀▀   
                            █    ▐             ▐       ▐      
                            ▐                                 
");
                Console.ResetColor();

                for (int i = 1; i <= 4; i++)
                {
                    if (i == selectedMenu)
                    {
                        Console.WriteLine($"\t\t\t\t >> {i} - {(i == 1 ? "Register Worker" : (i == 2 ? "Register Employer" : (i == 3 ? "Login Worker" : "Login Employer")))}");
                    }
                    else
                    {
                        Console.WriteLine($"\t\t\t\t   {i} - {(i == 1 ? "Register Worker" : (i == 2 ? "Register Employer" : (i == 3 ? "Login Worker" : "Login Employer")))}");
                    }
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedMenu = Math.Max(selectedMenu - 1, 1); 
                        break;
                    case ConsoleKey.DownArrow:
                        selectedMenu = Math.Min(selectedMenu + 1, 4); 
                        break;
                    case ConsoleKey.Enter:
                        if (selectedMenu == 1)
                        {
                            RegisterJobWorker();
                        }
                        else if (selectedMenu == 2)
                        {
                            RegisterJobEmployer();
                        }
                        else if (selectedMenu == 3)
                        {
                            LoginJobWorker();
                        }
                        else if (selectedMenu == 4)
                        {
                            LoginJobEmployer();
                        }
                        break;
                    default:
                        Console.WriteLine(@"Select from menu! 1 - 2 - 3 - 4");
                        break;
                }
            }
        }
    }


    //==========================================================================================
    //==========================================================================================
    //==========================================================================================
    public class Worker
    {
        public int Id { get; set; }
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }
        public string WorkerMail { get; set; }
        public string WorkerPassword { get; set; }
        public string WorkerPhoneNumber { get; set; }
        public string WorkerAddress { get; set; }
        public string WorkerSkill { get; set; }
    }

    public class WorkerCV
    {
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }
        public string WorkerSkills { get; set; }
    }

    public class JobEmployer
    {
        public int Id { get; set; }
        public string EmployerName { get; set; }
        public string EmployerPhoneNumber { get; set; }
        public string EmployerMail { get; set; }
        public string EmployerPassword { get; set; }
        public string EmployerAddress { get; set; }

        public List<WorkerCV> CVList { get; set; } = new List<WorkerCV>();

        public void StoreCV(string workerName, string workerSurname, string workerSkills)
        {
            var cv = new WorkerCV
            {
                WorkerName = workerName,
                WorkerSurname = workerSurname,
                WorkerSkills = workerSkills
            };

            CVList.Add(cv);
        }
    }

    public class JobSearcing
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobInfo { get; set; }
        public double JobSalary { get; set; }

        public int CreatedByEmployerId { get; set; }
    }

    public class UserData
    {
        public List<Worker> Workers { get; set; } = new List<Worker>();
        public List<JobEmployer> Employers { get; set; } = new List<JobEmployer>();
    }

    public class JobData
    {
        public List<JobSearcing> JobPostings { get; set; } = new List<JobSearcing>();
    }

    public static class JsonDataManager
    {
        private static readonly string UserDataFilePath = "UserData.json";
        private static readonly string JobDataFilePath = "EmployerData.json";

        public static UserData LoadUserData()
        {
            if (File.Exists(UserDataFilePath))
            {
                string json = File.ReadAllText(UserDataFilePath);
                return JsonConvert.DeserializeObject<UserData>(json);
            }
            return new UserData();
        }

        public static void SaveUserData(UserData userData)
        {
            string json = JsonConvert.SerializeObject(userData);
            File.WriteAllText(UserDataFilePath, json);
        }

        public static JobData LoadJobData()
        {
            if (File.Exists(JobDataFilePath))
            {
                string json = File.ReadAllText(JobDataFilePath);
                return JsonConvert.DeserializeObject<JobData>(json);
            }
            return new JobData();
        }

        public static void SaveJobData(JobData jobData)
        {
            string json = JsonConvert.SerializeObject(jobData);
            File.WriteAllText(JobDataFilePath, json);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SearchJob SearchJob = new SearchJob();

            SearchJob.JobMenu();
        }
    }
}
