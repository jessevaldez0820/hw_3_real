using Valdez_Jesse_HW3.DAL;
using Valdez_Jesse_HW3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valdez_Jesse_HW3.Seeding
{
	public static class SeedJobPostings
	{
		public static void SeedAllJobPostings(AppDbContext db)
		{
		//Create a new list for all of the job postings
		List<JobPosting> AllJobPostings = new List<JobPosting>();
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "0b0551ac25f718d888a9f382228a95c2",
			Title = "Photographer/Editor",
			Description = "-Editing and shooting stories, interviews, videos, packages and other projects as assigned.  -Assisting producers with coordinating and directing shoots and contribute in the pre-production process. Maintain production equipment and computer backup syste",
			Company = "NBC Universal",
			City = "El Paso",
			State = "TX",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 83000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "7556f07b6872d38a68166da4ebbe1423",
			Title = "CPO - Orthotics and Prosthetics (TX, Abilene)",
			Description = "This position examines patients, formulates prosthetic and orthotic recommendations, delivers and adjusts O&P devices to patients, instructs patients on appliance use and maintenance, participates in orthotic clinics and participates in continuing education for the department. Job Summary Location Abilene, TX Posted 20 Days ago Reference code 2847133",
			Company = "West Texas Rehabilitation Center",
			City = "Abilene",
			State = "TX",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 81000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "f8d0813e5ecb48eb4f2f43164c757dbd",
			Title = "School Psychologist",
			Description = "Position Type: Student Support Services/Psychologist Date Posted: 1/31/2020 Location: District Date Available: 08/01/2020 Closing Date: 02/21/2020 District: Huber Heights City Schools-website Description: Huber Heights City Schools is seeking a fully licensed School Psychologist. Competitive salary and benefits are offered. Job Summary Location Dayton, OH 45402 Posted Today Reference code 12228_38825",
			Company = "Dayton Area School Consortium",
			City = "Dayton",
			State = "OH",
			PostedDate = new DateTime(2020,1,31),
			MinimumSalary = 60000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "5f4d9fb22b15a7c51400fedfff4b18a8",
			Title = "Billing and Insurance Specialist - Entry Level (73692)",
			Description = "Position Summary Austin Retina Associates is seeking a responsible, self-motivated individual to help us provide unparalleled patient satisfaction ... Position Details Schedule assigned by supervisor, generally during weekdays 8-5.? Travel not required. Hourly pay (FLSA non-exempt, eligible for overtime)? Physical Demands Sitting still for up to 8 hours per day. Constant viewing and use of computer terminal. Frequent use of telephone. Job Summary Location Austin, TX 78705 Posted 1 Days ago Reference code 73692",
			Company = "Austin Retina",
			City = "Austin",
			State = "TX",
			PostedDate = new DateTime(2020,1,29),
			MinimumSalary = 78000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "09680505d9e90ad1fdf9c78568d04fb0",
			Title = "Full - time Dental Hygienist",
			Description = "Our team is looking for an enthusiastic, driven hygienist to add to our family!! We work in a fast-paced, close-knit environment with countless opportunities for learning and career growth. We offer a daily bonus system, CEs and licensure provided, health insurance, paid holidays and vacation time, among many other perks. Our team is a great one to be part of for a hygienist who wants to grow in their career! Ideally we would like to hire a hygienist who has experience but we do not require this. Must be a team player with a great attitude and excitement to learn new things. Employment Type: Full Time Bonus/Commission: Yes Job Summary Location Cookeville, TN 38501 Posted 8 Days ago Reference code 257817486",
			Company = "Hayes Family Dentistry",
			City = "Cookeville",
			State = "TN",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 55000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "fb037487c8897ff3dccbb6eb1b8a0246",
			Title = "Market Research Analyst (67551)",
			Description = "We are seeking qualified Analysts to join our team. Analysts work as part of a dynamic communications consulting/market research team conduc... Our ideal candidate has a Bachelors degree and internship or summer work experience in public relations, market research, political campaigns or a related position in the communications industry. Other attributes of the successful candidate include: ? Hard-working, detail oriented, creative, and comfortable working with numbers Proven leadership, communication, and writing skills Proficiency in Microsoft Excel, PowerPoint and Word Experience with statistical software (specifically SPSS) is preferable but not required Job Summary Location New York, NY 10010 Posted 4 Days ago Reference code 67551",
			Company = "Penn Schoen & Berland Associates Ll",
			City = "New York",
			State = "NY",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 64000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "448d501e8eb4a156994901cff26b08c7",
			Title = "Operations Manager - Healthcare Industry - Claims",
			Description = "Role: Operations Manager Location: Folsom, CA Client open for CTH or Contract or Full Time. Duration: Initial 6-9 months to start with for the contract Based on the call with HM: Someone who has managed projects and processes for Healthcare clients and handled claims data. Pointers for the role: Able to consolidate, interpret, and coordinate complex requirements. Strong PM/Program Manager Manage Organizations and vendors performing claims processing, helpdesk Manage the financial side of the project. 10 - Yrs mgmt./leadership experience Federal Healthcare ie Tricare/VA is a Plus. Please connect with us at 469-270-6890 for more details. - provided by Dice Job Summary Location Folsom, CA 95630 Posted Today Reference code 6874_f2fd0227c9a3747f62691c5b471665c8",
			Company = "Mumba Technologies",
			City = "Folsom",
			State = "CA",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 76000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a051840c14073478e6a0ece7447307b9",
			Title = "LPN Clinic - Family Practice",
			Description = "PeaceHealth is leading the charge to address health concerns and increase access to care in the communities we serve. The PeaceHealth Medical group is comprised of more than 820 healthcare providers in 40 medical specialties, including Orthopedics, OB, Behavioral Health and Cardiology, just to name a few. From the pristine frontiers of Ketchikan, Alaska to the beauty of the San Juan Islands and on to the historic riverfront town of Florence Oregon, the PeaceHealth Medical Group includes dozens of clinics and hospitals across the Pacific Northwest. Consider a fulfilling career with the chance to enjoy an amazing, balanced home life in some of the most beautiful areas in the United States! Job Summary Location Salem, OR 97308 Posted Today Reference code 9355_186390-c6c90f22487ac73b828e09f00e365809",
			Company = "PeaceHealth",
			City = "Salem",
			State = "OR",
			PostedDate = new DateTime(2020,1,30),
			MinimumSalary = 40000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d17b8af5c91adf6833dc601a5d7dbd54",
			Title = "Wound Care RN",
			Description = "The Wound Care Nurse is responsible for assessing skin alterations, developing plans of care, implementing orders and treatments, and evaluating progress of specialized skin and wound conditions. The Wound Care Nurse evaluates new admissions, participates in weekly wound team rounds, documents status, insures notification of physician and family of changes, and provides education to nursing staff. The Wound Care Nurse identifies wound types, analyzes trends, which will ensure that patient's needs are met in accordance with professional standards of practice through physician orders, center policies and procedures, and federal, state and local guidelines. Wound care certification is preferred. Prior wound care experience is required. Job Summary Location Coraopolis, PA 15108 Posted 1 Days ago Reference code 704361",
			Company = "West Hills Health and Rehabilitation Center",
			City = "Coraopolis",
			State = "PA",
			PostedDate = new DateTime(2020,1,30),
			MinimumSalary = 79000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a7584d513ffadea61562a5e275055122",
			Title = "Lead Data Scientist-Machine Learning",
			Description = "Programming Skills complete with Machine Learning using the     latest open source technologies and languages     Statistics and Mathematical background    Expert in Data Wrangling, Data Visualization &amp; Communication     Alternate location options:    Salisbury, MD OR  Greenville,SC   - provided by Dice ",
			Company = "CSI Consulting",
			City = "Quincy",
			State = "MA",
			PostedDate = new DateTime(2020,1,13),
			MinimumSalary = 54000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "884793339f48f40edb3cb925a50e9537",
			Title = "CT Technologist II",
			Description = "Performs computerized tomographic procedures for the diagnosis of disease and injury according to protocols established by radiologists. This position also performs biopsy procedures an average of 30% of the time. PRIMARY RESPONSIBILITIES Prepares and positions patients and selects anatomic and technical parameters accurately. Prepares and administers contrast media and/or medications within the accepted scope of practice and applicable state and federal regulations. Observes patient during procedure and reports abnormal activity. Monitors protocols and recommends updates or refinements as warranted. Follows radiation safety procedures and guidelines. Performs other duties as assigned. EDUCATION Associate's degree EXPERIENCE No experience required Job Summary Location Saint Louis, MO 63104 Posted 1 Days ago Reference code 7772_R4798",
			Company = "Cardinal Glennon Children's Hospital",
			City = "Saint Louis",
			State = "MO",
			PostedDate = new DateTime(2020,1,29),
			MinimumSalary = 62000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "64ab32a0ebd6debe39778476de39cc38",
			Title = "Hemodialysis Technician",
			Description = "The Hemodialysis Technician provides direct care as part of the Renal team to outpatients under the supervision of the Dialysis RN. Prepares the machines, initiatives, monitors, and discontinues Hemodialysis treatments.  High School Diploma or GED required. Minimum 3 months as Hemodialysis Technician Trainee. Certified Clinical Hemodialysis Technician (CCHT) required with in 18 months of hire.",
			Company = "Southwestern Vermont Health Care",
			City = "Bennington",
			State = "VT",
			PostedDate = new DateTime(2020,1,15),
			MinimumSalary = 54000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a50a4f06bf700f76f2af0f74dc20cdf1",
			Title = "Apprentice: Hearing Aid Specialist Annapolis, MD 6357",
			Description = "Company Description nullJob Description Mission: Helping People Hear Better Club: Retail Pay: 15.00/hour until a state license is obtained Hours: Tuesday thru Saturday 9A - 6P What you will be doing: 5 weeks online course to prepare youfor the state licensing exam Hands on practical experience working under a licensed Hearing Instrument Specialist Follow-up with customers and their needs with solutions to the hearing aids Starting a career in a fast growing and fulfilling industry Who you are: Interested in Audiology, ear anatomy, and hearing aid technology Motivated by helping others hear better Ambitious with a sales attitude An entrepreneur mindset with problem-solving skills, this role will have great autonomy Qualifications null Additional Information We are an Equal Employment Opportunity Employer. Job Summary Location Annapolis, MD Posted 3 Days ago Reference code 405999953447228",
			Company = "Hearing Lab Technology, LLC",
			City = "Annapolis",
			State = "MD",
			PostedDate = new DateTime(2020,1,25),
			MinimumSalary = 79000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "9345cad1ab482b9f1ed3e343b2ecd2a8",
			Title = "Medical Lab Technologist / Medical Technologist",
			Description = "Why a Great Opportunity Medical Lab Technologist/Medical Technologist - Location: Danville, IL We are ranked the number one?healthcare employer in Illinois and Top 10 in the nation.? Job Description Job Type: Direct ? ? Salary Range: $39,000 - $65,000 ? ?Shift: 10 hour Nights Job Description: This individual is responsible for analysis, evaluation and reporting of laboratory test results in accordance with established departmental procedures and professional standards, to provide accurate data in a timely manner, for use in diagnosis and treatment of patients. Qualifications One of the following qualifications must be met. Associates degree in laboratory science or medical laboratory technology from an accredited institution. Successfully achieved a satisfactory grade in a proficiency examination approved by the HHS (HEW exam) Job Summary Location Danville, IL Posted 6 Days ago Reference code 29516",
			Company = "NPAworldwide Recruitment Network",
			City = "Danville",
			State = "IL",
			PostedDate = new DateTime(2020,1,25),
			MinimumSalary = 58000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "84143b7d04d6cefe36921c8cf007b4b2",
			Title = "Controller - - Public Company Based in Baltimore / Washington Corridor",
			Description = "Prominent public company seeks Corporate Controller to work at its global HQ in Howard County. Responsibilities include: Consolidation of financial results of parent company and subsidiaries Standardization of financial reporting of subsidiaries Coordination of monthly closings on a timely basis Preparation of all SEC filings Assistance with management of internal controls to ensure compliance with Sarbanes-Oxley Act Cash management (foreign currency, overseeing A/R and A/P) Must have strong SEC reporting skills, revenue recognition experience and proven leadership skills. Excellent opportunity to join a highly respected company, a leader in its field, currently on an acquisition spree. Compensation package includes attractive salary, bonus and stock options. Employment Type: Full Time Years Experience: 10 - 15 years Bonus/Commission: Yes Job Summary Location Columbia, MD 21046 Posted Today Reference code 261216834",
			Company = "Sudina Search, LLC",
			City = "Columbia",
			State = "MD",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 77000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "6b41e92db9a8f1365d6768c74f63fa09",
			Title = "Instructor in Kinesiology Part-Time Pool",
			Description = "This is a continuous open pool to fill part-time instructor positions at any of our three colleges (Oxnard, Moorpark, and Ventura) for the Summer 2019 , Fall 2019, and Spring 2020 semesters. If you have applied to previous pools in this discipline, you will need to apply to this pool to continue to be considered. Under the general direction of a dean, an Instructor (Non-Contract/Temporary) provides comprehensive classroom instruction to students from diverse backgrounds for the purpose of facilitating the attainment of their academic or vocational objectives. In accordance with the provisions of Education Code sections 87482.5, Instructors (Non-Contract/Temporary) may be employed up to 67% of a full-time assignment. Job Type: Part-Time Faculty Location: Districtwide (Ventura County CA) , California Agency: Districtwide Job Summary Location Districtwide (Ventura County CA), CA Posted 2 Days ago Reference code 2278915",
			Company = "Ventura County Community College District, CA",
			City = "Districtwide (Ventura County CA)",
			State = "CA",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 40000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "dcc28dae02bd5a4db6b559b86d38bf02",
			Title = "Data Architect",
			Description = "Position: Data Architect Location: Chicago, IL, USA JD: REplacement Data ARchitect Analysis skill in understanding source system, distilling the input-output pipes to comprehensive flow Job Description Big Data Architect development experience in one of the Big Data Technologies Hadoop eco system, Pig, Hive, HBASE, Spark, Scala, Kafka. Cross trained in Talend is added advantage DW basic concepts Unix scripting is added advantage To be proficient in designing efficient and robust ETL workflows To be able to work with cloud computing environments Gather and process raw data at scale including writing scripts web scraping calling APIs write SQL queries etc Secondary skillset: Knowledge on JIRA, Github, Jenkins, Zena, Healthcare Claims Knowledge Experience in Agile Development methodologies Excellent communication skills and team dynamics - provided by Dice Job Summary Location Chicago, IL 60290 Posted Today Reference code 6874_ee335205aa411a7ab8ab70f10e408f30",
			Company = "Tektree Systems Inc.",
			City = "Chicago",
			State = "IL",
			PostedDate = new DateTime(2020,1,31),
			MinimumSalary = 56000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "251897895ac2479348d57478ba7c182e",
			Title = "High School - French Teacher",
			Description = "Position Type: Certificated/Certificated - Teacher    Date Posted: 1/22/2020    Location: Lindbergh High School    Date Available: 2020-2021 School Year     Position Information:      Contract Type   Continuing     FTE   1.0     Calendar   180 Day REA*RSD Work Calendars*     Salary Schedule   *Current Salary Schedule*      Qualified candidates must hold or be eligible for Washington State Teacher Certification with endorsement in French.    See attached job description and additional information.",
			Company = "Renton School District",
			City = "Renton",
			State = "WA",
			PostedDate = new DateTime(2020,1,25),
			MinimumSalary = 37000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "2625ee8cc0d10c35ffb35c9d2905f73a",
			Title = "Full Stack Java Developer",
			Description = "Job Title: Full Stack Java Developer     Location: Pleasanton, CA   Duration: Long Term Contract   Interview: Phone + Video/Skype/Web Ex video call    Description:   Looking for Full Stack Java Developer with below skills   Java, Spring, Hibernate, Soap, Webservices, NodeJS, Cloud (PAAS)    Thanks &amp; Regards   Steve Smith   |   Sr IT Resourcing Specialist   Amiti Consulting Group | One Loudoun | Virginia   (O) 703.520.2200 | (F) 703.345.9380 |    ",
			Company = "Amiti Consulting, Inc",
			City = "Pleasanton",
			State = "CA",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 42000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "61c4efa23a057fdb6cfaade02cdde09d",
			Title = "Real Time Modeling Engineer",
			Description = "Ideal candidate would have experience working with Matlab and Simulink and Real-Time Targets. Core knowledge of motor control systems is desired. Ideal candidate would also be familiar with Real-time hardware and supporting development environments such as developing graphical user interface design in Visual Basic for target applications. Familiarity with Stateflow is beneficial. Candidate would be responsible for becoming familiar with the Main Propulsion Control system component procurement specification and system level requirements documentation to ensure delivered products perform as required to support component testing. Candidate must also demonstrate knowledge of systems engineering development process including configuration management. Apply Online Directly with Electric Boat Create a job search agent to be notified when new openings are posted. Redisplay Search Results Job Summary Location Groton, CT 06349 Posted 13 Days ago Reference code 2365_c3af5afaf2b1c55b14957f692b162245",
			Company = "General Dynamics Shared Resources",
			City = "Groton",
			State = "CT",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 57000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "982a25a01eb881b6c0af7a23b2d98d73",
			Title = "Dental Hygienist - Casa Grande, Arizona (34555)",
			Description = "The Dental Hygienist is primarily responsible for the direct provision of oral hygiene and appropriate preventive services to dental patients, and pro... KNOWLEDGE, SKILLS AND ABILITIES: Demonstrated understanding of dental methods and techniques Knowledge of state and federal regulations where applicable Knowledge of infection control protocols and procedures Ability to perform assignments requiring considerable exercise of independent judgment Competency in dealing with people of various cultures EDUCATION AND EXPERIENCE: High School diploma or equivalency Graduate of an accredited school of dental hygiene Current valid Arizona license to practice oral hygiene Certified as a radiographer The above statement reflects the general duties considered necessary to perform the principal functions of the job as identified, and shall not be considered as a detailed description of all work requirements that may be inherent in the job. Job Summary Location CASA GRANDE, AZ 85122 Posted 9 Days ago Reference code 34555",
			Company = "Sun Life Family Health Center",
			City = "CASA GRANDE",
			State = "AZ",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 77000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "7fb65f585988d9954ae921426ea62afc",
			Title = "Senior Marketing Campaign Specialist",
			Description = "Overview:  The CRS Group is currently looking for a Senior Marketing Campaign Specialist for one of our clients in the Houston area. The CRS Group is a nationwide Staffing Firm who works primarily with Fortune 500 and Fortune 1000 corporations.        Duration:  6 month contract        Location:  Houston, TX 77010     Responsibilities:   Responsible for partnering with internal and/or external business partners to implement marketing campaigns and/or programs.  Creates or manages vendors who create sales enablement materials which include digital marketing campaigns, social media ads, presentations, signage, brochures, etc.  Documents and shares assets, collateral, programs, resources, communications, etc. with other marketing groups to drive efficiency.    crs_scapozzi  ss # 86127             Qualified applicants will receive consideration for employment without regard to race, color, age, religion, sex, sexual orientation, gender identity, national origin, disability, protected veteran status, or genetic information. ",
			Company = "Computer Resource Solutions",
			City = "Houston",
			State = "TX",
			PostedDate = new DateTime(2020,1,7),
			MinimumSalary = 76000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "52954285f017de35e7252da67af23e04",
			Title = "Adjunct Instructor - Mathematics",
			Description = "The Tri-County Technical College Arts and Sciences Division is seeking collaborative, energetic, and innovative?Mathematics Adjunct Instructors. Reporting to the?Mathematics Department Head, successful candidates will teach?Mathematics courses?using systematically planned and delivered instruction for the program;?maintain records of student academic progress and attendance, evaluate level of achievement, and assign grades for the program. Classes are offered during the day, evening, and at various Tri-County Technical College?community?campuses within Anderson, Oconee, and Pickens counties. The?Mathematics Adjunct Instructor role is a part-time employment role. Successful candidates will be required to teach face-to-face instruction at one of our four community campuses (Anderson, Easley, Pendleton, or Oconee). Online instruction is not available. Job Type: Temporary - Part-Time Location: Anderson County , South Carolina Agency: Tri-County Technical College Job Summary Location Anderson County, SC Posted Today Reference code 2701355",
			Company = "State of South Carolina",
			City = "Anderson County",
			State = "SC",
			PostedDate = new DateTime(2020,1,30),
			MinimumSalary = 40000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "1d40972e51606987332c1d7b86957bf1",
			Title = "Production Assistant",
			Description = "As a Production Assistant, you will work directly with producers, senior producers and executive producers to assist in production of live news. ? Responsibilities include:?  Work closely with producers to research, select and locate required footage for broadcast.  Create rundown for technical and editorial staff, as directed by producers.  Print scripts for anchors and ensure host is prepared for live broadcast.  Act as liaison between studio and control room during live broadcast.  Assist in compiling research for anchors and maintaining on-air updates during live program.   ",
			Company = "NBC Universal",
			City = "New York",
			State = "NY",
			PostedDate = new DateTime(2020,1,2),
			MinimumSalary = 94000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "4f4f35c9bf5dabef9c8bacbb11946f06",
			Title = "Data Architect",
			Description = "Data Architect    Des Moines, IA  Long term           Architect need s to have financial services background     with a mix of life/annuity experience. Our client manager is leading     the financial services/data management IT teams and they need people     who have experience with amortization schedules on life insurance     policies and the finance that goes behind them. Good candidates will     com from life insurance companies like Sammons, Aviva back in the     day (Athene now), Fidelity and Guarantee Life, MetLife, and Voya to     name a few ",
			Company = "Resource Consulting Services",
			City = "Des Moines",
			State = "IA",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 65000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "e7702aec619ce85d849926366ff8c099",
			Title = "Stage Manager (53303)",
			Description = "Are you someone who is resourceful and organized?? Do you have a passion for theater and want to be involved??We have?an opportunity fo...  \tPrevious experience working in on-stage productions \tA passion for theater and interest in developing and supporting productions. \tMust enjoy working with children, previous childcare experience preferred but not required The YMCA is committed to a policy of nondiscrimination and equal opportunity for all employees and qualified applicants without regard to race, color, religious creed, protected genetic information, national origin, ancestry, sex, age, disability, veteran's status, or sexual orientation.  ",
			Company = "YMCA of the North Shore",
			City = "Beverly",
			State = "MA",
			PostedDate = new DateTime(2020,1,8),
			MinimumSalary = 91000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "4f4699cdcab47abdbb02406fe64718cd",
			Title = "CTO, CIO, eCommerce, $200K to $250K",
			Description = "No Consulting firms.  No sponsorship available.  Must live within a commutable distance of Long Island, NY to be considered.  For immediate consideration, send your resume in WORD format to .   Chief Technology Officer    Substantial experience with eCommerce platforms in a manufacturing     and/or distribution environment for consumer products  Cloud experience - AWS a plus    Extensive management experience including hiring and team building  Digital marketing knowledge  Team building and hiring experience  Full project lifecycle and product management experience  Excellent communication and problem solving skills    ",
			Company = "DP Search",
			City = "Ronkonkoma",
			State = "NY",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 69000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "c77b786665d49080455c7c78c549fbdd",
			Title = "X-ray/CT Tech - Overnight Weekdays - 7p-7a Tues, Wed, & Thurs",
			Description = "Obtains patient history, explains standard procedures, and addresses patient concerns. Produces computerized tomographic scanner radiographs of specific areas as required by the departmental procedures. Relies on experience and judgment to plan and accomplish goals. Performs a variety of tasks. Works under general supervision. A certain degree of creativity and latitude is required. Typically reports to a supervisor or manager. Associates degree and completion of radiologic technology training and A.R.R.T. registration, and  minimum of-2 years of experience . Familiar with standard concepts, practices, and procedures within a particular field.  ",
			Company = "Northwest Medical Center Bentonville",
			City = "Bentonville",
			State = "AR",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 55000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "0ec17af63bcf355d4a532c19c43ee191",
			Title = "Radiologic Technologist",
			Description = "Looking for a few hardworking, loyal and longterm energetic radiologic technologists to fill our full time postions and prn positions.Applicants must be registered with ARRT and licensed by the Texas Medical Board. We are a fun and energetic company that?allows flexibility and open communication with our staff at all times. We support our staff in many ways getting to know them on a personal level, their families and are always here to help them with whatever it is they need. Our company offers overtime pay, incentives and benefits. We would love to have you join our team! Please contact me via my email and include your resume.?  Employment Type: Full Time Salary: $20+ Hourly  Job Summary ",
			Company = "Manasseh Medical Imaging",
			City = "Lubbock",
			State = "TX",
			PostedDate = new DateTime(2020,1,9),
			MinimumSalary = 68000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "71e32595d5e616c43cf955cea239f9db",
			Title = "Mental Health Technician - (Job Number: 249668)",
			Description = "Providence is?looking for?a Mental Health Technician (0.9 FTE, Day Shift) to work at?Providence St. Peter Hospital in Olympia, WA?  .         We are seeking an individual to provide a safe, quiet, clean, organized environment for nursing care delivery to patients in a behavioral health setting.  In this position you will:    Participate in both the planning and implementing of individual patient treatment plans.   Help patients with personal grooming and participation in educational, recreational, and therapeutic activities.   Use good observation skills in order to recognize and report changes in behavior of patients to other team members.   Maintain patient records by using electronic systems.   ",
			Company = "Swedish Health Services",
			City = "Olympia",
			State = "WA",
			PostedDate = new DateTime(2020,1,18),
			MinimumSalary = 37000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "6cf2f59cc612057326a8d7386acb7989",
			Title = "MENTAL HEALTH TECH FULL TIME DAYS",
			Description = "Summary    Mental Health Tech    FT Days    Candidates within the unit have priority by unit seniority         The mental health technician  assists in the care of  severely mentally ill young adults through geriatric patients and in the maintenance of a safe and clean environment for patients and staff.      Qualifications:    Requirements        Education:High School Diploma or GED    Experience:None License None   Certification'BLS (AMERICAN HEART ASSN) CPI DURING ORIENTATION    '       Job:     Behavioral Tech      Primary Location:     West Palm Beach, Florida      Facility:     Saint Mary's Medical Center      Job Type:     Full-time      Shift Type:     Days    ",
			Company = "Saint Mary's Medical Center",
			City = "West Palm Beach",
			State = "FL",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 33000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "713b25ac4b70498bd249658bdd100997",
			Title = "Machine Learning Developer",
			Description = "Role: Machine Learning Developer Location: Irving,     TX Duration: 6+ Months  Description:    Computer-related degree or equivalent experience  3+ years of professional experience with machine learning or 8+       years of research experience  Strong OOP coding skills  Experience with a machine learning platform such as: TensorFlow,       Caffe, Keras, or Encog  Experience working with large data sets, both structured and unstructured  Solid understanding of machine learning techniques and       algorithms, such as HMM, neural networks, deep learning, etc.  Experience creating workflows and rule engines  Awareness of principles such as SOLID, YAGNI, and DRY ",
			Company = "Emergere Technologies",
			City = "Irving",
			State = "TX",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 78000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "3ab384cc794e215e77143ab5e1e088a8",
			Title = "Transportation Analyst - Shopify Shipping",
			Description = "That?s it! We know that applying to a new role takes a lot of work and we truly value your time. Greg, a recruiter on our team, is looking forward to reading your application.     This posting will close on Friday, January 31st at 2pm EDT.     At Shopify, we are committed to building and fostering an environment where our employees feel included, valued, and heard. Our belief is that a strong commitment to diversity and inclusion enables us to truly make commerce better for everyone. We strongly encourage applications from Indigenous peoples, racialized people, people with disabilities, people from gender and sexually diverse communities and/or people with intersectional identities.  ",
			Company = "Shopify",
			City = "Ottawa, Toronto",
			State = "NY",
			PostedDate = new DateTime(2020,1,21),
			MinimumSalary = 59000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d86b57adc86eacaa4eb66319cb0fa737",
			Title = "PHYSICIAN COMPENSATION ANALYST",
			Description = "Job Summary: The Physician/App Compensation Analyst is responsible for gathering and reporting on clinic production. This information is then used to calculate the compensation and bonuses for physicians and other providers and to calculate the revenue allocation for financial statements.    Education:  Baccalaureate degree in accounting, information services, finance or business administration.   Experience:  Minimum of 2 to 4 years of business/accounting experience CentraCare Health and Carris Health have made a commitment to diversity in its workforce. All individuals including, but not limited to, individuals with disabilities, are encouraged to apply. CentraCare Health and Carris Health are EEO/AA employers.    J",
			Company = "CentraCare Health",
			City = "Willmar",
			State = "MN",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 83000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "30e3bc3ba2293ab327819f44393042dc",
			Title = "Contracts Administrator (Windsor Mill, MD)  - Must be local and work on W2",
			Description = "Required Skills      Location   Immediately local to the greater Baltimore / Washington     DC area  Education   Minimum Bachelor's Degree in Business or Law  Experience   Minimum 1 year of experience as a Contracts     Administrator or Manager  Strong knowledge of legal requirements involved with federal contracts  Experience with Teaming Agreements (TA), Non-disclosure agreements     (NDA), Service Agreements, and Consultant Agreements.   Excellent writing skills  Keen attention to detail, with an ability to spot errors  Strong analytical and organizational skills  Ability to work with varying seniority levels, including staff,     managers and external partners   ",
			Company = "Activesoft, Inc.",
			City = "Baltimore",
			State = "MD",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 89000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a28d3a9a078141d6a2c35212743f39af",
			Title = "Program Specialist - ROLEA (Adjunct Faculty)",
			Description = "The Program Specialist serves as the coordinator for the interagency/college sponsored Reserve Officer Law Enforcement Academy (ROLEA) program.? Responsibilities include development of the ROLEA master schedule, teaching, staffing classes with qualified primary and backup instructors and assistants, maintaining student and program records, arranging for off-campus facilities to support training when necessary, securing the availability of instructional materials and resources for instructors and students, and communicating with agencies, the Advisory Board and staff regarding ROLEA program. Supervision Received The Chairperson of the Criminal Justice Department provides direct supervision consistent with established policies and procedures of Rogue Community College in cooperation with the Dean, School of Health and Public Service. The ROLEA Advisory Board serves to recommend policies and program priorities and provides general guidance to the Program Specialist through the chairperson of the Department. In addition, the Program Specialist is expected to work in cooperation with DPSP faculty and staff to accomplish the Department Mission. Job Summary Location Medford, OR Posted 1 Days ago Reference code 2694987",
			Company = "Rogue Community College",
			City = "Medford",
			State = "OR",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 46000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "7d379487d2b1bca52ab519090f7e8c7c",
			Title = "Restaurant Manager - Plymouth Meeting, PA",
			Description = "Overview When working at Cracker Barrel, you will enjoy a fast-paced, family environment, where we treat every guest as a guest in our own home. You?ll be ?Pleasing People? with our made-from-scratch recipes and inspiring smiles with our unique retail shop that combine to say: ?Welcome to Cracker Barrel, welcome home!? ? ? Responsibility Bring your passion for leading people and your strong business skills to Cracker Barrel. We?re looking for folks who can problem solve in our high-volume operations while remaining focused on achieving operational excellence and staying true to our brand promise.?? You will be mentored by some of the best in the business as you grow your career and earn industry-leading compensation. In turn, you will lead, coach, and mentor our best asset?our hourly team members. When you take care of them, they will take good care of our guests! ? Qualifications To be a successful manager you must have a high school diploma/GED and 2 years restaurant management; or equivalent combination of education and experience. A college degree in Business, Hospitality, or related field is preferred but not required. Job Summary Location Plymouth Meeting, PA 19462 Posted 13 Days ago Reference code 8433_12841",
			Company = "Cracker Barrel Old Country Store, Inc.",
			City = "Plymouth Meeting",
			State = "PA",
			PostedDate = new DateTime(2020,1,13),
			MinimumSalary = 35000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "e9479aa65edf45048ad4715235e28dc0",
			Title = "Ultrasound Tech - 40hours/week",
			Description = "Performs ultrasonic/diagnostic examinations for subsequent evaluation and treatment by attending physician.  Performs a variety of technical procedures requiring independent judgment, ingenuity and initiative in applying ultrasound or diagnostic techniques for radiologic diagnosis.  Responsible for the safety and comfort of all patients undergoing ultrasound/diagnostic procedures.  Ensures that all procedures have been appropriately ordered with satisfaction patient identification obtained prior to conducting procedure.  Performs all procedures according to departmental protocol.  Performs other related duties as required.  Equal Opportunity Employer Minorities/Females/Veterans/Disabled  VEVRAA Federal Contractor  Job Summary \r                  \r                      \r                          Location \r                              Ronceverte, WV 24970 \r                      \r                  \r                              \r                      \r                          Posted \r                          1 Days ago \r                      \r                  \r                              \r                      \r                          Reference code \r                          2365_62b28c08edd534bcdb6882c5c94321f8",
			Company = "Greenbrier Valley Medical Center",
			City = "Ronceverte",
			State = "WV",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 91000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "17f145067b90f91cf85a4c43bd932173",
			Title = "Corporate Communications Specialist",
			Description = "Communications Specialist Responsibilities: Collaborate with management to develop and implement an effective communications strategy based on our target audience Write, edit, and distribute content, including memos, newsletters, website content, and other materials that communicates the organization's delivery transformation efforts Gather feedback on communication effectiveness and implement improvements Understand the different types of communication channels and identify best ways to deliver messaging Proficiency in design and publishing software Understand OCM concepts and how change is managed Requirements: 3 to 5 years proven experience as communications specialist Experience in web design and content production is a plus Experience in copywriting and editing Experience in constructing communication campaigns Solid understanding of project management principles Working knowledge of MS Office; photo and video-editing software is an asset Excellent communication (oral and written) and presentation skills Outstanding organizational and planning abilities Qualifications: BSc/BA in public relations, communications or relevant field - provided by Dice Job Summary Location Dallas, TX 75201 Posted Today Reference code 6874_55eeaf9d755c733f31ab49237f9b0eee",
			Company = "InnoCore Solutions, Inc.",
			City = "Dallas",
			State = "TX",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 71000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "fed69ba901eb0a589c23a04491bac345",
			Title = "Web Accessibility SME - Financial Services",
			Description = "The Role The developer will work closely with UX design teams in implementing accessible UI components: - be a subject matter expert in accessibility and coach other dev teams on best practices - analyze websites and mobile apps for compliance with WCAG compliance using manual testing, automated tools, and assistive technologies - fix or rewrite code in websites and mobile apps to be accessible - code, conduct code reviews, and test software as needed Our UI tech stack includes the Angular framework, TypeScript, SCSS, RxJS, Adobe Analytics, and Cordova. Skills Required - 7+ years of experience building responsive websites - Knowledge of web and mobile accessibility, including WCAG 2.1 and WAI-ARIA guidelines - Experience with screen reader software (JAWS, VoiceOver, NVDA) - Experience in remediating accessibility issues in websites, mobile applications, and PDF documents - Strong grasp of user experience - Excellent in JavaScript and CSS - Attention to detail, with the ability to reproduce a visual design exactly using CSS and HTML - Strong communication skills and problem solving skills - Experience with Angular, TypeScript, and SCSS - provided by Dice Job Summary Location New York, NY 10001 Posted Today Reference code 6874_21b90db965c50083d6811a9abca34f54",
			Company = "East End Resources",
			City = "New York",
			State = "NY",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 76000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "ad1ae8def7a768d1d827e663ba98c4cb",
			Title = "Vice President- Marketing",
			Description = "Our client in Houston is looking for a strong Vice President- Marketing to join their team. Requirements: Ten (10) years minimum experience in a relevant commercial role Strong working knowledge of the Western US and Mexico gas markets is essential Excellent verbal and written communication skills, with specific ability to translate complex information into an organized and presentable manner. Ability to work in a fast-paced environment and work on multiple projects. Ability to solve problems. Excellent management, administrative, leadership and organizational skills. Ability to establish and maintain effective working relationships with employees, supervisors and other departments. Ability and willingness to travel up to 15% of work time Strong working knowledge and experience in all phases of Microsoft Office. Required: ?Bachelor?s degree in business/marketing or Engineering from an accredited university MBA preferred If you meet the requirements and are interested in this opportunity, please apply online. Only qualified candidates will be contacted. MUST BE ELIGIBLE TO WORK IN THE US FOR ANY EMPLOYER WITHOUT SPONSORSHIP. Recruiter: Kerri Thornton ? Kerri Thornton Sr. Recruiter 972-454-9890 Office Job Summary Location Houston, TX Posted 9 Days ago Reference code 10075310",
			Company = "KS Energy Search Group",
			City = "Houston",
			State = "TX",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 55000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "28a7e8ba5ce060036d7f3f60985f7fba",
			Title = "Optometry or Ophthalmology Assistants and Scribes",
			Description = "We are looking for?Optometry or?Ophthalmology Assistants and Scribes. This is a practice to grow with.? We will train employees working toward Ophthalmic Scribe Certification (OSC) or a Certified Ophthalmic Assistant (COA).? We pride ourselves in the continuing education of our staff and offer competitive education allowances. We are a multispecialty ophthalmology practice with four locations.? Our providers use cutting-edge technology, and with the help of their clinical staff, provide the personal experience our patients deserve. We are looking for medical assistants, ophthalmic and optometric assistants and medical scribes to join our busy ophthalmology practice.? We offer our patients a full range of ophthalmology and optometry services, from surgery to contact lenses.? Our clinical staff play a vital role in patient care.?? Responsibility and Duties include the following: A genuine, positive attitude, focusing on quality patient care Strong interpersonal skills and the ability to work as a team Strong computer skills, attentive to details and accuracy Ideally, some medical experience is preferred but not required.? We are willing to train the right candidate for the job. Employment Type: Full Time Job Summary Location Arlington, MA 02474 Posted 1 Days ago Reference code 261436551",
			Company = "Lexington Eye Associates",
			City = "Arlington",
			State = "MA",
			PostedDate = new DateTime(2020,1,30),
			MinimumSalary = 30000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "3633d9ca23a0824a1af6efe16217c8bc",
			Title = "Certified, Medical Interpreter",
			Description = "SUMMARY OF JOB: The Medical Interpreter will facilitate meaningful and effectivecommunication between doctors, nurses, laboratory technicians, and othermedical personnel and the patient/ family. Responsible for translatingin needed language medical information such as patient information,diagnoses, instructions and other hospital information for all areas ofthe hospital. CONNECTING TO MISSION: All individuals, within the scope of their position are responsible toperform their job in light of the Mission & Values of the Health System.Regardless of position, every job contributes to the challenge ofproviding health care. There is an ongoing responsibility for ensuringthat the values of Respect, Compassion, Justice, Hospitality, HolisticApproach, Stewardship and Collaboration are present in our interactionswith one another and in the services we provide. RECRUITMENT REQUIREMENTS: Bachelor's degree preferred Two years of experience in a healthcare setting as a medical interpreterpreferred. One year of prior Interpreter experience. Knowledge of medical terminology. Fluency in multiple languages preferably Russian language. LICENSE AND REGULATORY REQUIREMENTS: Certification required. Job Summary Location Allison Park, PA 15101 Posted 8 Days ago Reference code 2365_d8d6ae28c08e4cec8e7573e6841cf636",
			Company = "Holy Redeemer Health System",
			City = "Allison Park",
			State = "PA",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 33000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Communications"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d40574fb0588ceed4b4bddade1883f8f",
			Title = "22. QA / Game Tester",
			Description = "Responsibilities     Knowledgeable with TRC, TCR, and Lotcheck standards.  Tests software for defects (?Bugs?) and accurately reports them in the project database.  Review product documentation (i.e. game manuals, strategy guides, advertisements, box art, etc.) for accuracy.  Input bug reports and regress claimed fixed bugs.  Assist in the Burn Lab and/or Video Lab as needed.   ?      Requirements     High School Diploma or equivalent  Excellent written and verbal communication skills.  Willingness to work overtime when necessary.  Keep current with new and emerging game software technologies.  Maintain an understanding of all game genres and possess an intuitive understanding of what makes a quality game.     Charlyn Tango  3875 Hopyard Road Suite 130 Pleasanton ,? California ?? 94588 (925) 416-9707   ",
			Company = "West Valley Staffing",
			City = "Santa Clara",
			State = "CA",
			PostedDate = new DateTime(2020,1,18),
			MinimumSalary = 49000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "7add6d6a9868de464ec540319070cb63",
			Title = "Business Development Associate",
			Description = "Are you looking for an exciting and challenging career opportunity in the healthcare sales field?OurSan Francisco office is growing and we are seeking and ambitious Business DevelopmentAssociateto join our progressive team. Situated in ideal Jackson Square, our trendy office is in a prime spot between North Beach, China Town and Financial District.As a Business DevelopmentAssociate, you will join a high energy inside sales environment and manage a large book ofclientsthroughout theWest Coast. TheBusiness Development Associatemust be articulate and engaging.B2B experience is a plus.Clinical Management Consultants works with some the TOP 10 BEST Hospital in the US.Working effectively, tactfully and with a sense of urgency is key. Each DevelopmentAssociatemust be able to communicate effectively with Hospital Executives from C-Level to VPs.The Business Development Associate will handle the full cycle of recruiting which includes obtaining the contract and Job Order from Hospital Client and recruiting to fill the position.Juggling account manager and recruiter responsible, this is a big role. You will function as: Sales Consultant, Career Consultant, Role Model, Colleague, Marketer, Strategic Thinker and Healthcare Expert monsterboost9999 Job Summary Location San Francisco, CA Posted 9 Days ago Reference code 243122020-01-08",
			Company = "Clinical Management Consultants",
			City = "San Francisco",
			State = "CA",
			PostedDate = new DateTime(2020,1,21),
			MinimumSalary = 48000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "4f053493d62dfab82d7c81704aad3aa2",
			Title = "Junior Software Developer",
			Description = "Cloud Lake Technology, LLC, an Akima Company,? is an industry leading Technology and Mission Services Provider, delivering experience-driven and cost-optimized solutions for complex business problems for our customers across the federal, commercial and public sector markets. We are seeking candidates with relevant web development experience, high aptitude, drive for excellence, and zeal for learning, who wish to grow with one of the fastest growing companies in the industry.   Responsibilities:? ? Cloud Lake Technology, LLC. (Cloud Lake) is looking for a Senior-level?Software Developer to join our team supporting one of our current government customers!? The successful candidate will have a solid working knowledge of agile development methodologies, use?of?C#, Java script, ASP.Net, and have extensive experience in web development.  Job Summary",
			Company = "Akima, LLC",
			City = "Arlington",
			State = "VA",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 33000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "87247a388d92b1b55d5001e9eebb1687",
			Title = "General Manager",
			Description = "Bamboo Sushi, the world?s first sustainable sushi concept, has opened in Seattle at University Village!     We are seeking an experienced and inspired leader to head our first of many restaurants in the Seattle market and continue the success we have seen in our Portland and Denver restaurants. The ideal candidate will have 5-7 years of high volume experience in a service driven environment. An excellent leader who will partner with their culinary counterpart in delivering an amazing culinary experience while continuing grow our mission of sustainability within the community.     Bamboo Sushi offers a competitive salary and bonus program, excellent benefits and tremendous opportunity for growth.     To learn more about the restaurant, please visit: www.bamboosushi.com   ?     To learn more about or company, please visit:   www.sustainablerestaurantgroup.com     ",
			Company = "Bamboo Sushi",
			City = "Seattle",
			State = "WA",
			PostedDate = new DateTime(2020,1,21),
			MinimumSalary = 68000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "c0af7c9bb5b578faeff5205a6c74c67a",
			Title = "Plant Manager - high pressure aluminum die casting",
			Description = "Expanding international company has an opportunity at a plant site in east central AL for a  Plant Manager. ? The expansion is associated with capital equipment and more personnel. As a plant manager will be over the manufacturing of tier supplier components that are high pressure aluminum die casted.? There are 8 direct reports associated with the position.? Relocation assistance is also available for this role.? This opportunity is in a nice location to reside. ??   ?     Successful experience as a plant manager   Must have solid experience with high pressure aluminum die casting   Automotive / vehicle manufacturing related tier supplier experience in desired   Servo actuated die cast equipment experience is needed   Excellent communication and organizational skills are required   Strength in continuous improvement is also needed  ",
			Company = "Cameron Craig Group",
			City = "Montgomery",
			State = "AL",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 93000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "937703f7d6b051c1296b2e0bfe280880",
			Title = "English Teacher (2 Positions)",
			Description = "Position Type: Junior High/Middle School Teaching/English    Date Posted: 1/15/2020    Location: Flowing Wells Junior High School    Date Available: 2020-2021 School Year     Closing Date:  Open Until Filled     Salary:   Please visit here to view our Certified Salary Compensation Plan. The 2020-2021 Compensation Plan TBD.   Terms/Benefits:   2020-2021 School Year  Major medical, hospitalization, dental, income protection, term life, and professional growth plan   Qualifications:   Arizona Secondary Certificate and appropriately certified in English  SEI endorsement required (can obtain after hire)   PC# 171 100 002      EXEMPT EMPLOYEE     Flowing Wells Unified School District is an EQUAL OPPORTUNITY EMPLOYER, TITLE IX, and does not discriminate on the basis of race, color, gender, national origin, sexual orientation, age, religion, or disability in its employment practices.",
			Company = "Flowing Wells Unified School District",
			City = "Tuscon",
			State = "AZ",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 68000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a0cd981f586040117a947df9c55f7e05",
			Title = "Patient Care Tech/PCT",
			Description = "Participates in the development and maintenance of the hemodialysis patient's short and longterm careplans, encouraging the participation of the patient/care givers. Demonstrates knowledge of the concept of hemodialysis, uremia and dialysis complications, and the specialized needs of the patient.  Is proficient at initiation of hemodialysis and monitoring of the patient during the procedure.  Communicates patient condition changes to RN/Physician,  Transcribes orders, and Follows dialysis prescription for each patient.  Administers intradialytic medications per prescription/protocol.  Status: \tFull Time  Schedule: \tShifts are 10-12 hours with 3 to 4 Saturday shifts every 6 weeks. This is a day shift position.  Weekend: \t3 to 4 Saturday shifts every 6 weeks.  Qualifications: \tMust have HS diploma/GED and experience in Dialysis is preferred.  Pay: \tBased on experience       ",
			Company = "Larkin Contractors",
			City = "Greensboro",
			State = "NC",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 86000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "aa27ab681da84917ee546886edcfb323",
			Title = "Maintenance Technician",
			Description = "Maintenance Technician Description    Summary     Assists in the maintenance of facility to provide a safe, clean, and comfortable environment for residents, staff, and visitors.         Essential Duties & Responsibilities       \t Diagnoses technical and mechanical problems and makes repairs as appropriate.   \t Responsible for maintenance and beautification of facility and grounds.   \t Conducts scheduled maintenance throughout physical plant and for all equipment.   \t Maintains and tests the emergency power system to ensure availability of power to all entrances, exits, fire detection alarms and extinguishing equipment, and life support systems.   \t Maintains all essential equipment (e.g., boiler room equipment, nursing unit/medication room refrigerators, kitchen refrigerators and freezers, etc.) in a safe operating condition.   \t Performs other duties as assigned.      ",
			Company = "Terrace Gardens Healthcare Center",
			City = "Colorado Springs",
			State = "CO",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 43000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "6ad43f552e99207dfd8aa7f54d7ac27c",
			Title = "Service Advisor/Autobody Appraiser/Collision Estimator - Southaven",
			Description = "*  Greet each customer in a professional and courteous manner *  Educate the customer about the collision repair process; including insurance claims, processing, payment procedures, repair techniques, repair needs and approximate repair time *  Prepare all repair damage reports in an accurate and precise manner *  Supervise and route each repair; including disbursement of all paperwork, scheduling, monitoring repairs, negotiating repair times, coordinating sublet work and all other aspects of the repair *  Provide the consumer with the most expeditious and high quality repair available *  Uses tact and diplomacy when dealing with internal and external customers *  Attend daily release meetings *  Service all insurance accounts in order to maintain those business relationships vital to Service King's success Equal Opportunity Employer Minorities/Women/Protected Veterans/Disabled  JSGYM  Job Summary ",
			Company = "Service King Collision Repair",
			City = "Southaven",
			State = "MS",
			PostedDate = new DateTime(2020,1,17),
			MinimumSalary = 47000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "258e3b4c79946bbafe62925c51557e64",
			Title = "EEG Tech",
			Description = "The EEG Tech is accountable for performing quality electroneurodiagnostic procedures through the application of advanced clinical and technical knowledge while maintaining strict attention to patient care and in accordance with organization and department policy and procedures. This position is accountable for providing direct patient care and maintaining expertise for all ages spanning from neonatal/newborn to adults. The patient acuity ranges from stable outpatients to critically ill patients on full life support.   Qualifications:    High School degree or equivalent required    BLS CPR certification is required    A graduate of an accredited Electroneurodiagnostic technology program or equivalent formal training is preferred      Registry-eligible by American Board of Registration of Electroencephalographic and Evoked Potential Technologists is preferred     Job Summary ",
			Company = "Cook Children''s Medical Center",
			City = "Fort Worth",
			State = "TX",
			PostedDate = new DateTime(2020,1,21),
			MinimumSalary = 83000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "9fbf30331aee160cb091b96d9375ca2f",
			Title = "Media Specialist",
			Description = "Position Type: ??Instructional Support Positions/Media Specialist    Date Posted: ??1/8/2020    Location: ??OAKRIDGE ELEMENTARY    Date Available: ??2019-2020    ?? Qualifications:?  Hold a valid Florida Educator's Certificate or eligible for a Florida certificate in Educational Media Specialist. Ability to plan, implement and administer a media program; design, conduct, and evaluate learning activities that teach information literacy; build and manage collections that include diverse formats; organize, establish, and supervise routines and procedures for efficient operation of the media center. Requires expertise in print, nonprint and electronic information resources, library management systems, current and emerging instructional technologies, and knowledge of current educational trends and teaching practices.? Bilingual skills preferred. Computer skills as required for the position.   ?   ",
			Company = "Broward County Public Schools",
			City = "Fort Lauderdale",
			State = "FL",
			PostedDate = new DateTime(2020,1,8),
			MinimumSalary = 88000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Library"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "7b24949889b5f79fdada41894ddae296",
			Title = "Plant Safety Supervisor",
			Description = "Must have at least (3) years of industrial safety experience in any type of manufacturing environment. This role will be both strategic and tactical in nature regarding all safety and health management activities.     ?   Position will report into a Facility Manager and work closely with both Regional and Corporate Safety to oversee regulatory compliance, accident investigation, audits, reporting and OSHA VPP efforts. Responsible for all aspects of safety training (including initial new hire training), implementation of company safety policies and management of other safety program initiatives such as DOT. Excellent career growth potential into larger site, regional or corporate roles.??   ?     *Key Personality Traits:   people oriented, ability to work well with all levels in changing environment, hands-on, self-assured, personable and great communicator.",
			Company = "Cameron Craig Group",
			City = "Philadelphia",
			State = "PA",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 65000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "4b03f342bfb766c68a1b189a6f580fa7",
			Title = "LVN Licensed Vocational Nurse",
			Description = "You?re one in a million. You know that being a Licensed Nurse means being someone who is entirely committed to the care and well-being of your patients. You do more and we do more to give you the support and the opportunities you deserve. Let?s talk about your future.  Our center?s success is dependent on our skilled Licensed Nurses (LPNs/LVNs) providing compassionate patient care.   Responsibilities:     Assess patients and take vital signs \t Administer medications and treatments \t Assist the attending Physician or RN in performing specialized procedures    Qualifications:    Graduate of an accredited school of nursing \t Valid LPN license   Consider joining our center so that you can make the difference. We make it our goal to support you and provide you with opportunities to impact the lives of patients and residents while you continue to grow in your career. It?s not a job. It?s your future with us.",
			Company = "Greenview Manor",
			City = "Waco",
			State = "TX",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 62000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a4dc78a089168a6e103779293be4cb66",
			Title = "Insurance Billing Coordinator",
			Description = "Description: The Insurance Billing Coordinator is responsible for reviewing client appointments with the practice management software and assist with creating claims to send to insurance companies for all rendered appointments. The coordinator also pursues collection of all claims until payment is made by insurance companies, and performs other work associated with the billing process. The Insurance Billing Coordinator reports directly to the Accounting and Financial Manager. Other duties include: Review appointment for accuracy of insurance codes and time constraints; adjust as needed Prepare daily and weekly attendance roster; report to management Assist in preparing weekly reports for hour tracking on all billable hours Prepare and submit claims to a clearinghouse for electronic submission Secure needed medical documentation required or requested Follow up on all unpaid claims until the claim is paid Send patient statements; contract guarantor regarding outstanding invoices and discuss payment options PM20 Required High school diploma or equivalent Must be able to type 35 words per minute One year prior experience in insurance billing of third party insurance for facility and professional services Preferred Post-high school courses in insurance billing, data processing and medical terminology PI117458983 Job Summary Location Fresno, CA 93710 Posted 11 Days ago Reference code 117458983",
			Company = "California Autism Center and Learning Group",
			City = "Fresno",
			State = "CA",
			PostedDate = new DateTime(2020,1,25),
			MinimumSalary = 87000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "790e32ee7c1b5697e3347d04541e7f36",
			Title = "Library Assitant (part-time)",
			Description = "Rockingham County is an equal opportunity employer and will comply with federal and state statutes regarding discrimination?in employment matters.    General Definition of Work  Performs difficult administrative support work at the circulation desk, preparing materials for circulation, providing assistance to library patrons, maintaining records and files, and related work as apparent or assigned.? Work is performed under the supervision of the Librarian.  ?  Qualification Requirements   To perform this job successfully, an individual must be able to perform each essential function satisfactorily.? The requirements listed below are representative of the knowledge, skill and/or ability required.? Reasonable accommodations may be made to enable an individual with disabilities to perform the essential functions.  ? ? Job Type:  Part Time Regular   Location:  Rockingham County  , North Carolina   Agency:  Library   ",
			Company = "Rockingham County Government",
			City = "Rockingham",
			State = "NC",
			PostedDate = new DateTime(2020,1,4),
			MinimumSalary = 47000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Library"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "34a24c8cb18bbdab614f8862c78e268e",
			Title = "LPN Licensed Practical Nurse",
			Description = "You?re one in a million. You know that being a Licensed Nurse means being someone who is entirely committed to the care and well-being of your patients. You do more and we do more to give you the support and the opportunities you deserve. Let?s talk about your future.  Our center?s success is dependent on our skilled Licensed Nurses (LPNs/LVNs) providing compassionate patient care.   Responsibilities:     Assess patients and take vital signs \t Administer medications and treatments \t Assist the attending Physician or RN in performing specialized procedures    Qualifications:    Graduate of an accredited school of nursing \t Valid LPN license   Consider joining our center so that you can make the difference. We make it our goal to support you and provide you with opportunities to impact the lives of patients and residents while you continue to grow in your career. It?s not a job. It?s your future with us.   ",
			Company = "Anderson Mill Health and Rehabilitation Center",
			City = "Austell",
			State = "GA",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 72000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "67b2377a986242d2a5a5ebe333ef7409",
			Title = "LVN Licensed Vocational Nurse",
			Description = "You?re one in a million. You know that being a Licensed Nurse means being someone who is entirely committed to the care and well-being of your patients. You do more and we do more to give you the support and the opportunities you deserve. Let?s talk about your future.  Our center?s success is dependent on our skilled Licensed Nurses (LPNs/LVNs) providing compassionate patient care.   Responsibilities:     Assess patients and take vital signs \t Administer medications and treatments \t Assist the attending Physician or RN in performing specialized procedures    Qualifications:    Graduate of an accredited school of nursing \t Valid LPN license   Consider joining our center so that you can make the difference. We make it our goal to support you and provide you with opportunities to impact the lives of patients and residents while you continue to grow in your career. It?s not a job. It?s your future with us. ",
			Company = "Pasadena Care Center",
			City = "Pasadena",
			State = "TX",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 53000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "2f487771d208de3eaa56549fb64f444e",
			Title = "LVN Licensed Vocational Nurse",
			Description = "You?re one in a million. You know that being a Licensed Nurse means being someone who is entirely committed to the care and well-being of your patients. You do more and we do more to give you the support and the opportunities you deserve. Let?s talk about your future.  Our center?s success is dependent on our skilled Licensed Nurses (LPNs/LVNs) providing compassionate patient care.   Responsibilities:     Assess patients and take vital signs \t Administer medications and treatments \t Assist the attending Physician or RN in performing specialized procedures    Qualifications:    Graduate of an accredited school of nursing \t Valid LPN license   Consider joining our center so that you can make the difference. We make it our goal to support you and provide you with opportunities to impact the lives of patients and residents while you continue to grow in your career. It?s not a job. It?s your future with us. ",
			Company = "Memorial City Health and Rehabilitation Center",
			City = "Houston",
			State = "TX",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 31000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "44150860a10bf817fa08c25df5c1d3cf",
			Title = "LPN Licensed Practical Nurse",
			Description = "You?re one in a million. You know that being a Licensed Nurse means being someone who is entirely committed to the care and well-being of your patients. You do more and we do more to give you the support and the opportunities you deserve. Let?s talk about your future.  Our center?s success is dependent on our skilled Licensed Nurses (LPNs/LVNs) providing compassionate patient care.   Responsibilities:     Assess patients and take vital signs \t Administer medications and treatments \t Assist the attending Physician or RN in performing specialized procedures    Qualifications:    Graduate of an accredited school of nursing \t Valid LPN license   Consider joining our center so that you can make the difference. We make it our goal to support you and provide you with opportunities to impact the lives of patients and residents while you continue to grow in your career. It?s not a job. It?s your future with us.  ",
			Company = "Newport Health and Rehabilitation Center",
			City = "Newport",
			State = "TN",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 95000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "8b0d436720edadd56ebea52d7093f72d",
			Title = "LVN Licensed Vocational Nurse",
			Description = "You?re one in a million. You know that being a Licensed Nurse means being someone who is entirely committed to the care and well-being of your patients. You do more and we do more to give you the support and the opportunities you deserve. Let?s talk about your future.  Our center?s success is dependent on our skilled Licensed Nurses (LPNs/LVNs) providing compassionate patient care.   Responsibilities:     Assess patients and take vital signs \t Administer medications and treatments \t Assist the attending Physician or RN in performing specialized procedures    Qualifications:    Graduate of an accredited school of nursing \t Valid LPN license   Consider joining our center so that you can make the difference. We make it our goal to support you and provide you with opportunities to impact the lives of patients and residents while you continue to grow in your career. It?s not a job. It?s your future with us.    ",
			Company = "Brazosview Healthcare Center",
			City = "Richmond",
			State = "TX",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 47000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "896e1679a84306c183dd2794fd05e0fa",
			Title = "LPN Licensed Practical Nurse",
			Description = "$3,000 SIGN ON BONUS!   You?re one in a million. You know that being a Licensed Nurse means being someone who is entirely committed to the care and well-being of your patients. You do more and we do more to give you the support and the opportunities you deserve. Let?s talk about your future.  Our center?s success is dependent on our skilled Licensed Nurses (LPNs/LVNs) providing compassionate patient care.   Responsibilities:     Assess patients and take vital signs \t Administer medications and treatments \t Assist the attending Physician or RN in performing specialized procedures    Qualifications:    Graduate of an accredited school of nursing \t Valid LPN license   Consider joining our center so that you can make the difference. We make it our goal to support you and provide you with opportunities to impact the lives of patients and residents while you continue to grow in your career. It?s not a job. It?s your future with us.    ",
			Company = "Bel Air Health and Rehabilitation Center",
			City = "Bel Air",
			State = "MD",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 37000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "c035c55cc0e01846347e1b06e193daed",
			Title = "LPN Licensed Practical Nurse",
			Description = "$3,500 SIGN ON BONUS!   You?re one in a million. You know that being a Licensed Nurse means being someone who is entirely committed to the care and well-being of your patients. You do more and we do more to give you the support and the opportunities you deserve. Let?s talk about your future.  Our center?s success is dependent on our skilled Licensed Nurses (LPNs/LVNs) providing compassionate patient care.   Responsibilities:     Assess patients and take vital signs \t Administer medications and treatments \t Assist the attending Physician or RN in performing specialized procedures    Qualifications:    Graduate of an accredited school of nursing \t Valid LPN license   Consider joining our center so that you can make the difference. We make it our goal to support you and provide you with opportunities to impact the lives of patients and residents while you continue to grow in your career. It?s not a job. It?s your future with us.  ?",
			Company = "Monaco Parkway Health and Rehabilitation Center",
			City = "Denver",
			State = "CO",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 46000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "673ee1772a06657ec8b7d2dfad87f309",
			Title = "LPN Licensed Practical Nurse - $750 SIGN ON BONUS!",
			Description = "$750 SIGN ON BONUS!   You?re one in a million. You know that being a Licensed Nurse means being someone who is entirely committed to the care and well-being of your patients. You do more and we do more to give you the support and the opportunities you deserve. Let?s talk about your future.  Our center?s success is dependent on our skilled Licensed Nurses (LPNs/LVNs) providing compassionate patient care.   Responsibilities:     Assess patients and take vital signs \t Administer medications and treatments \t Assist the attending Physician or RN in performing specialized procedures    Qualifications:    Graduate of an accredited school of nursing \t Valid LPN license   Consider joining our center so that you can make the difference. We make it our goal to support you and provide you with opportunities to impact the lives of patients and residents while you continue to grow in your career. It?s not a job. It?s your future with us.",
			Company = "Brian Center Health & Rehabilitation/Spruce Pine",
			City = "Spruce Pine",
			State = "NC",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 84000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "611439fda8d9ac971ccecc7a81b03a98",
			Title = "Data Architect (ETL/DWH)",
			Description = "Data Architect  Location : SFO CA  Looking for a Data Architect to help lead data engineering team. This   person should be able to lead the folks in the team in terms of task   assignment, and also provide technical expertise in terms of data   design and architecture, and also represent the team during   discussions with the Data Science and Analytics teams.  Specializations: ETL/DWH development - AWS   (EMR/Redshift/Kinesis/Lambda/Glue/Athena),  Databases - Amazon   Redshift, DynamoDB, PostgreSQL, Oracle 11g/12c, SQL   Server; Workload automation - AWS (Data Pipeline/CloudWatch/Step   Functions), Rundeck/Airflow/Cron, Control-M 8.x; DB Languages -   PL/SQL, T-SQL, HiveQL; Scripting - Unix /Linux Shell;   Programming: Java/scala Data modeling - MySQL Workbench 6.3,     ERwin 7, Visio 2007, Power Designer 12; API formats - XML,     JSON, YAML; Version control - GitLab, SVN.",
			Company = "SIGNin Solutions Inc.",
			City = "San Francisco",
			State = "CA",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 72000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d52a39794118f95b1ec4d256a4bbf54a",
			Title = "Marketing / Sales Consultant Intern",
			Description = "Job Description Our firm is currently filling entry level / internship positions in marketing and sales. We provide an opportunity for entry levels and college graduates to get their foot in the door and jump-start their career. We are looking for talented candidates that we can develop from the ground up. We train our Marketing and Sales Consulting Interns in the following areas: - Marketing and sales - Customer service - Account acquisition and retention - Business development - Account management - Human resources and talent scouting - Team leadership and management - Coaching and accountability We proudly represent our clients in the Pittsburgh area and look to hire our representatives to represent them with integrity and character. Our firm is growing, how many businesses do you know that can say the same? This position is entry level or an internship with paid training, so no prior experience is necessary. To learn more about our management training program, our exciting corporate culture, our people, and growth opportunities within our firm, please submit your resume immediately. We are hiring immediately and looking to fill our May Graduate and Summer Internships as well. We have recently added a new member of our management staff and are looking to expand the team to continue to grow for our clients. Job Summary Location Pittsburgh, PA 15298 Posted Today Reference code 9019_664d1e1f-e481-4c06-ae43-e12b93a1f075",
			Company = "Opus Business Consulting",
			City = "Pittsburgh",
			State = "PA",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 46000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "f947a691897637e6e25ae3b5bd273c5e",
			Title = "IT Tech Support Specialist",
			Description = "DCC Propane, LLC is a diverse retail propane and manufacturing business with operations in multiple states. We are looking for a detail-oriented, thorough, and organized IT professional to join our growing team. In this position, you will be responsible for providing technical assistance and support to employees with desktop/laptop computers, tablets, email, software applications, phone, hardware and printers. EOE DUTIES The IT Technician position will include duties such as: Provide technical assistance and support for incoming concerns and issues related to systems, software and hardware Assist staff with installation, configuration, and ongoing usability of desktop computers, peripheral equipment, and software Responsible for PC's, Printers, Servers and related equipment (monitor, keyboard, mouse, hard drive, etc.) Performing remote troubleshooting through diagnostic techniques and pertinent questions Ensure the optimum customer experience and satisfaction through relationship building QUALIFICATIONS Education - BSc/BA in IT, Computer Science or related field Certifications - CompTIA A+, or other recognized certification Good communication and organizational skills KEY SKILLS & COMPETENCIES Oral and written communication skills Customer service orientation Problem analysis and problem solving Team interaction Job Summary Location Roberts, IL 60962 Posted 10 Days ago Reference code 2365_0d5834a06235ab9a5d2c36e7bed9b74e",
			Company = "DCC Propane, LLC",
			City = "Roberts",
			State = "IL",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 83000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "538d7fd962b51e3714347e7c6dffac3b",
			Title = "Technology Support Specialist",
			Description = "Major Los Angeles law firm is seeking a Tech Support Specialist to join its team. Ideal candidate will have hands-on Level 2 IT support along with administrative/asset management experience in a large corporate setting. Must be proficient with Windows 10, Mac OS, MS Office, MS SCCM, Exchange, Active Directory, Cisco VPN, Citrix RSA Tokens, and Ticketing/Tracking Systems. Advanced troubleshooting skills with hardware issues (desktops, laptops, printers, phone devices, VoIP and related peripherals) and software issues (primarily Microsoft Word, Excel, PowerPoint, and Outlook; and Desktop Applications) required. Qualified applicants will have strong communication skills and the ability to provide superior customer service. A college degree in IT or computer systems and/or MOS Certification desired. For prompt and confidential consideration, please submit MS Word version of resume along with compensation requirements.   ",
			Company = "Busby Park Recruiting LLC",
			City = "Los Angeles",
			State = "CA",
			PostedDate = new DateTime(2020,1,8),
			MinimumSalary = 39000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "9eddf292568b7f5438437c115471893f",
			Title = "Adjunct Physics Instructor",
			Description = "Provide students with course syllabus, grading/attendance policy, and other relevant information in a timely manner; relate instructional materials, discussions, and examples and illustrations; pace the instructor over the academic term; provide students with timely assessments; return assessment results in timely manner; relate assessments to course objectives; follow acceptable department and college grading policies; utilize appropriate instructional technology; maintain a positive environment for optimum student performance.? Submit reports in timely manner; practice effective class management; prioritize duties and use time wisely; adhere to class schedules and meeting times; provide effective classroom/lab supervision; maintain accurate records; handle students' work and records in professional manner; perform other duties as required. Job Type:  Temporary - Part-Time   Location:  York County  , South Carolina   Agency:  York Technical College",
			Company = "State of South Carolina",
			City = "York County",
			State = "SC",
			PostedDate = new DateTime(2020,1,10),
			MinimumSalary = 45000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "ce510e68b37a811e7514cabd5eb8b84c",
			Title = "Junior Financial Analyst",
			Description = "Overview VT Group is a leading technology integrator with close to 50 years? experience delivering technology and C4ISR solutions to solve the complex challenges faced by our government and commercial customers in the Defense and National Security markets. We do more than provide technical expertise and operational support to our government partners and commercial customers. We help America?s leaders make the best possible decisions for our country?s future. Responsibilities Primary Responsibilities: ? The Junior Financial Analysts/Intern shall provide on-demand timely professional support services to the Navy Shipbuilding Program Offices within Team Ships at the Naval Sea Systems Command in Washington DC as assigned during a 2 year program from the summer of 2020 to the summer of 2022. The requirement is for the junior financial analyst/intern to be exposed to Teams Ships financial management and the DOD/Navy budget process, learn Financial Management competencies, develops skill sets, provide value to the program offices, and contribute to our future workforce. Qualifications Required: Earn a Bachelor's Degree by May 2020 Ability to Obtain a SECRET Clearance - U.S. Citizen MS Suite Skills ? Specifically Power Point, Word, Access, and Excel Proactive and excellent customer service Desired: Prefer degree pursuing in an area related to Business, Accouting, or Finacial Management Job Summary Location Washington, DC Posted 15 Days ago Reference code 2422",
			Company = "VT Group, Inc.",
			City = "Washington",
			State = "DC",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 37000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "9d71c4b992764ccae4b025e11392876e",
			Title = "Junior Account Manager/Full-charge Bookkeeper",
			Description = "Department:  Business Management    Successful candidates should have the following:    Experience in a Business Management firm or Public Accounting field;  Bachelor?s Degree (Accounting, Finance, or Business-related field) or similar certifications preferred;  Computer literate, with a working knowledge of MS Word, MS Excel, and MS Outlook;  Ability to handle confidential information and interactions with the highest level of security and tact;  Datafaction experience highly desirable;  Commutable distance to Century City office.     Responsibilities:    A/P Processing  Credit Card coding  Account research to resolve billing discrepancies  Month/Year end Reporting  Year end processing/1099 prep  Strong knowledge of debit/credit double entry system   Bank runs and deposits     Something that should be noted: we offer market-leading benefits, and lots of fun, intangible perks (Quarterly Socials, Annual Ski/Camping trips, Catered breakfast, etc.).  ",
			Company = "DirectedLINK",
			City = "Century City",
			State = "CA",
			PostedDate = new DateTime(2020,1,17),
			MinimumSalary = 62000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "1dfec7174442f07be79eb37f34609d89",
			Title = "Librarian II - T11338-202001",
			Description = "Librarian II positions perform professional librarian work in a branch library or a service area of the Central Library; assist the public in the use of library resources; provide services to children and young adults; review and evaluate the library collection and make recommendations for collection development and maintenance; catalog library books and materials; and perform other duties as assigned. ? ????? NOTES: \t Work schedules may include evenings and weekends.\t The list established for these positions may be used to fill full-time, half-time and/or limited, hourly vacancies.\t Employees in the Librarian series who obtain a Master of Library Science or Master of Library and Information Science Degree are eligible for 5% additional pay.\t Some Librarian II positions may require bilingual communication skills for which an additional $0.70 per hour may be paid.  Job Type:  Varies by Position   Location:  City of San Diego  , California   Agency:  1713 - Library  ",
			Company = "City of San Diego, CA",
			City = "City of San Diego",
			State = "CA",
			PostedDate = new DateTime(2020,1,10),
			MinimumSalary = 89000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Library"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "affb4bf64267925a7605ad3628d2a9e0",
			Title = "Entry Level Scientist",
			Description = "Job Description Naval Nuclear Laboratory seeks highly motivated scientists to join our team. As a scientist at the Naval Nuclear Laboratory, you will work in a mission-driven, dynamic environment with a strong, interdependent technical team. We develop the world's best nuclear propulsion systems, train the Sailors to operate them, and provide full lifecycle support, from technology development through design to disposal. We are accepting applications from candidates with education and experience in the following fields of study: Mathematics Chemistry Physics Materials Science Data Science Computer Science Job Requirements Associate: Bachelor?s degree in a science-related field from an accredited college or university Intermediate: Bachelor?s degree in a science-related field from an accredited college or university and a minimum of two years of relevant experience; or Master?s degree in a science-related field from an accredited college or university and a minimum of one year relevant experience Job Preferred Skills Cumulative GPA 3.2/4.0 Department of Energy (DOE), Department of Defense (DOD) or Naval Nuclear Program experience Demonstrated leadership experience Demonstrated experience working with group projects or teams Involvement with professional societies Prior internship or work experience Fluor Marine Propulsion, LLC is an Equal Opportunity Employer and is Committed to Workforce Diversity. Job Summary Location Schenectady, NY Posted 1 Days ago Reference code 25101/6",
			Company = "Naval Nuclear Laboratory",
			City = "Schenectady",
			State = "NY",
			PostedDate = new DateTime(2020,1,30),
			MinimumSalary = 95000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "6191b7a00af4736cf88e6586704aa9b4",
			Title = "LPN Licensed Practical Nurse - $3,000 SIGN ON BONUS!!",
			Description = "$3,000 SIGN ON BONUS!    NOW HIRING FULL TIME AND PART TIME, DAY AND NIGHT SHIFTS!   You?re one in a million. You know that being a Licensed Nurse means being someone who is entirely committed to the care and well-being of your patients. You do more and we do more to give you the support and the opportunities you deserve. Let?s talk about your future.  Our center?s success is dependent on our skilled Licensed Nurses (LPNs/LVNs) providing compassionate patient care.   Responsibilities:     Assess patients and take vital signs \t Administer medications and treatments \t Assist the attending Physician or RN in performing specialized procedures    Qualifications:    Graduate of an accredited school of nursing \t Valid LPN license   Consider joining our center so that you can make the difference. We make it our goal to support you and provide you with opportunities to impact the lives of patients and residents while you continue to grow in your career. It?s not a job. It?s your future with us.   ",
			Company = "Heritage Harbour Health and Rehabilitation Center",
			City = "Annapolis",
			State = "MD",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 72000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "2c3eaf38c56415e47c74e051b36f8115",
			Title = "American Sign Language Interpreter (ASL)",
			Description = "The Stepping Stones Group is currently interviewing American Sign Language Interpreters for the remainder of the 19/20 SY in Burien, WA! Start ASAP! Job Requirements EIPA Score Full Time; Elementary and PreK Positions Available As a company with a strong value system and a social conscience, we invest in your future through mentoring, clinical support, continuing education, professional development, wellness benefits and a variety of resources that will empower you as a clinician throughout your career. As part of the Stepping Stones Group team you can receive: Competitive compensation and a comprehensive benefits package that includes student loan repayment options, travel options, professional development stipend, license and CEU reimbursement, health benefits, 401k wellness stipend and much more! Unparalleled national clinical support by some of the nation's foremost experts in school-based-services Pathways to Success which includes (Foundations Mentoring Program & Bloom) $1000 Referral bonus for every full-time, school-based friend you refer, that we hire Robust corporate Giving-Back-Program - Stepping Up for a Cause! Access to Bridge Academy with CEU courses offered at no cost to you - All year long! We believe in putting the needs of children first. We achieve that by making sure we put you in positions that are just right for you, and we know what it takes to thrive in your career, so call us today! Job Summary Location Burien, WA Posted 18 Days ago Reference code 47427",
			Company = "Cumberland Therapy",
			City = "Burien",
			State = "WA",
			PostedDate = new DateTime(2020,1,13),
			MinimumSalary = 68000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Communications"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "00d4ea57c52b7fc0ab5b2a6f737e5246",
			Title = "Chief Technology Officer",
			Description = "SUMMARY The Chief Technology Officer (CTO) is responsible for all Information Technology functions within the Automotive Group. The CTO will lead the information technology teams responsible for software development/engineering and architecture; in addition to technology infrastructure. The CTO will direct the information and data integrity for all Information Technology functions of the work groups. This includes software development, web development, computer systems operations, technical service centers, production scheduling functions, help desks, and communication networks (voice and data). The CTO will be responsible for the conceptualization of how technology is to be used. They will set strategy for the company. REQUIRED EXPERIENCE, SKILLS AND EDUCATION Minimum of 7 years CTO experience preferably in the Automotive Software or a similar SaaS based industry. Bachelor 's Degree in Computer Science or Engineering: or similar field. Experience with technology relative to the automotive industry preferred. Excellent leadership, team building and management skills. Strong communication, documentation and presentation skills. Proven experience with analysis, design, coding, software development, conversion and implementation of cloud base (AWS) applications. Ability to lead the design and implementation of technology initiatives, including software, hardware, operating system software and productivity tools. Job Summary Location San Diego, CA Posted 7 Days ago Reference code 604034",
			Company = "National Credit Center NCC",
			City = "San Diego",
			State = "CA",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 39000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "0969133513619fbbc10a2d84c0358187",
			Title = "QA Automation Engineer (Temporary)",
			Description = "WB Games Boston is seeking a QA Automation Engineer (temporary) to help extend our library of automated test scripts for our mobile game, Game of Thrones: Conquest. What part will you play? Suggest and implement improvements to our automated testing framework Add to our library of automated test scripts Identify existing manual testing processes that would benefit from automation Work closely with feature teams to improve product quality What do we require from you? 2+ years' experience working on games or mobile applications Proficiency working with automated testing tools, such as Appium or Selenium Experience working with Jenkins or other continuous integration software Familiarity with the Unity game engine Self-motivated, interested in pro-actively identifying and dealing with issues before they arise Experience playing mobile games is not necessary but is a huge plus! The Warner Bros. Entertainment Group of Companies is an equal opportunity employer and considers all candidates for employment regardless of race, color, religion, sex, national origin, citizenship, age, disability, marital status, military or veteran's status (including protected veterans, as may be required by federal law), sexual orientation, gender identity or any other category protected by law. Requisition # 168004BR Area of Interest Game Development/Publishing, Game QA/Localization Industry Games - Development & Publishing Job Summary Location Needham, MA 02494 Posted 13 Days ago Reference code 2365_5578f52ede26d7aebfdadbb7819eff9c",
			Company = "Warner Media Group",
			City = "Needham",
			State = "MA",
			PostedDate = new DateTime(2020,1,9),
			MinimumSalary = 66000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "4fb862145b75b6587d4eebafbf037462",
			Title = "Information Technology Applications Analyst",
			Description = "Title: IT Applications Analyst Level    Location: Sacramento, CA    Duration: 06 month contract        Job Description:    General duties of this position include:    * Provide break-fix and software support for PC and printer fleet    * End user support for County/VRE desktop applications    * Installation/de-installation of PCs and related equipment    * Support of VRE system Vote Center devices    * Add and maintain user accounts in Active Directory    * Set up for elections and tear down after which includes     placing VoIP phones and PCs at volunteer    stations.        This position will report to the Department of Technology     Senior IT Analyst, Donald Morrison, on site    for day to day tasking. The primary responsibility of this     temporary position will be to take the day to    day duties of supporting the IT infrastructure for VRE off the     County IT staff assigned to VRE so that    they may focus on preparing for, conducting and concluding the     Primary election.    - provided by Dice  Job Summary \r                  \r                      \r                          Location \r                              Sacramento, CA 94203 \r                      \r                  \r                              \r                      \r                          Posted \r                          2 Days ago \r                      \r                  \r                              \r                      \r                          Reference code \r                          6874_b51607f8e2fc274af51d8d25c30c16ff",
			Company = "Agile Global Solutions, Inc",
			City = "Sacramento",
			State = "CA",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 76000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a970cb29e458394536a966891130facc",
			Title = "Biomedical Equipment Tech I, Clinical Engineering, University of Louisville Hospital, Days, Full Time",
			Description = "Overview  Under general supervision, this position provides medical equipment repair and maintenance, performing substantial maintenance, safety testing and routine repairs.   ?   Responsibilities  1. Performs basic preventative maintenance/safety tests, training provided.2. Assist with equipment repair throughout responsible area.3. Completes all necessary record keeping for work orders received and/or finished.4. Promotes the safe effective use of clinical equipment.5. Assists in the ordering of parts and supplies necessary for the servicing of equipment.6. Performs other duties as assigned.  Qualifications   Education & Training: ? Associate degree in a related field required.  ?   Experience: ??Entry level to three years of related experience. Must keep up-to-date on technological and medical advances. Must maintain up-to-date understanding of The Joint Commission, NFPA and other regulatory agencies/standards. Must have the ability to repair and maintain a wide variety of equipment.  ?   License & Certification: ? BMET certification preferred.",
			Company = "University of Louisville Physicians",
			City = "Louisville",
			State = "KY",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 75000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "e1728c156c61a1a01ff69d18545c1161",
			Title = "Residential Counselor (3rd Shift) - Oxford House",
			Description = "YOU, Inc.  is currently searching for a talented professional to join our team as an  Overnight Awake Residential Counselor (3rd Shift)  at our Oxford Group Home in Oxford, MA!   Do you have a passion for working with school age children?  Join us!          RESPONSIBILITIES:          Provide quality clinical and residential services within the therapeutic milieu.            Remain awake and alert throughout the shift.                Provide crisis management.            Responsible for ongoing safety and supervision of youth within the program setting.                Responsible for maintenance and implementation of program policies and program development.                   EDUCATION / EXPERIENCE:          High school diploma or HiSET required.            BA/BS in Social Work, Psychology, Sociology, Human Services, or related field is preferred.            Experience working with children and/or adolescents preferred.            Candidate must have a valid driver?s license.            Candidate must be at least 21 years of age.              PM19    PI117283712   ",
			Company = "You, Inc.",
			City = "Oxford",
			State = "MA",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 49000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "e4398b5545d11bf88d1124999e930969",
			Title = "Dental Hygienist - Part Time",
			Description = "Overview  We are looking for a Dental Hygienist  ?  The Dental Hygienist at 42 North Dental partners with the Dental Director and general dentist in direct patient care as an important part of the healthcare team promoting better oral health for patients.? Become part of our dedication to providing excellence in comprehensive dental care with a focus on quality, service and patient satisfaction.?  Responsibilities    Adhere to clinical policies procedures and protocols   Perform oral healthcare and risk assessments   Performs preventative and therapeutic procedures   Provide patient education   Assist other dental professionals in communicating patient care   Ensure proper patient record and documentation   Interact with patients in a positive professional manner   Perform other related job duties as assigned   Qualifications    Dental Hygiene License   Local Anesthesia Permit   Positive attitude and energetic personality   Excellent interpersonal and organizational skills   Passionate about Dental Hygiene and the service you provide",
			Company = "Gentle Communications, LLC",
			City = "Malden",
			State = "MA",
			PostedDate = new DateTime(2020,1,21),
			MinimumSalary = 95000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "52ca478270a1539e226df9598a1c6eb2",
			Title = "Ultrasound/Echo Tech",
			Description = "Performs diagnostic ultrasound and echo exams. Performs a variety of imaging procedures and is responsible for patient safety protocols.  Requires graduate from a school of Ultrasound Technology, either college affiliated or hospital-based training program.  Must be registered or be eligible for registry by the American Registry of Diagnostic Medical Sonographers (ARDMS).  Echo sonographer must be able to produce high-quality images that show the heart's chambers, valves and vessels and must be able to perform two-dimensional and Doppler procedures, document abnormal Doppler sounds and take accurate blood flow measurements.  Must be registry eligible as a Diagnostic Cardiac Sonographer by the American Registry of Diagnostic Medical Sonographers (ARDMS).   Day Shift. Position on-call every other week for 5 days and every third weekend at this time.   Job:   *Please select a valid job field      Organization:   *Colorado Plains Medical Center      Title:   Ultrasound/Echo Tech      Location:   Colorado-Fort Morgan      Requisition ID:   7456-1600",
			Company = "LifePoint Health",
			City = "Fort Morgan",
			State = "CO",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 74000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "66639e77e82c3b22a937b3c854b968da",
			Title = "Audiologist or Hearing Instrument Specialist",
			Description = "Overview We are a growing hearing healthcare practice in Elmira, NY and currently seek an Audiologist or Hearing Instrument Specialist who is driven, self-motivated, and passionate about helping patients hear well again. The ideal candidate must be strong clinically and have the ability to effectively counsel while building patient rapport.? Mixture of diagnostics and dispensing, working with kids and adults. ? Open to part time or full time. Also open to someone working out of other locations and floating.? (Cortland, Binghamton, Ithaca) Relocation assistance and other incentives available for the right candidate! ? ? Daily tasks and responsibilities Establish rapport with, and gather history from, patients; conduct audiometric testing; counsel patients; and make recommendations for hearing aids. Make ear impressions, ear molds, and order instruments. Diagnostic testing for pediatrics through adults Program hearing aids using a computer. Fit hearing aids and assist with any adjustments, questions or problems. Maintain documentation and patient files. ? ? Qualifications Masters Degree in Audiology but Au.D. is preferred. Active and current hearing aid dispensing license. ? The successful Audiologist will also possess the following: Strong interpersonal and organizational skills The ability to work in a team environment The ability to interact professionally at all times with patients, physicians, and team members. ? We offer an attractive compensation package and a lucrative commission program, plus a benefits package Job Summary Location Elmira, NY Posted 1 Days ago Reference code 5844",
			Company = "American Hearing Aids Associates",
			City = "Elmira",
			State = "NY",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 69000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "ce57f126fb6ea825a16a90657404fe0c",
			Title = "Microsoft BI Stack Developer - Indianapolis, IN",
			Description = "Key skills required:  5+ years of exp  Microsoft BI stack (SSRS, T-SQL, PL-SQL, SSAS, SSIS, Azure)  Job Description:          Participate in Support and Enhancement of current systems   inside of the client s ecosystem. The consultant will be responsible   for all tiers of support for each application. Interact with clients   to understand the enhancements they would like to carry out, whether   it be new reports, new data flows and reports, Azure work, snowflake   work, etc. Also, respond to general task tickets and incident tickets   that the customer puts into the ticketing system.  Skills Required:   SSRS, T-SQL, PL-SQL, SSAS, SSIS, Snowflake, Azure Data Factory,     Azure Storage, MDX, DAX, Data Warehousing, Master Data Services,     Power BI Service, VBA  Consultant with the client about work they want done.  Plan, document and maintain current and new data systems that are integrated.  Troubleshoot and issues that arise in the BI stack.  Enhance the current engine integration project by using Visual     Basic for Applications coding.     Rashmi Gupta",
			Company = "Apeiron Securities & Investments LLP",
			City = "Indianapolis",
			State = "IN",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 69000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "6c0497fbf7a7627fc6ab460e9e12c258",
			Title = "LVN Licensed Vocational Nurse",
			Description = "The caring. The compassion. The healing. It starts with you.     WHO YOU ARE:    You are a hands-on Licensed Practical Nurse (LPN) or Licensed Vocational Nurse (LVN) eager to provide quality continuous care to your patients. In addition, you have a heart to serve others by caring for the patients individualized needs the way you?d care for the needs of your own family.   WHAT THIS ROLE CAN OFFER YOU:    In this role, you will provide direct patient care within a skilled nursing facility. You?ll follow the plan of care, assessing patients, administering medications and treatments, preparing supplies and equipment for treatments, and assisting the attending physician or registered nurse in performing specialized procedures.  ?  Each LPN/LVN must possess a current state licensure for consideration.   WHO WE ARE:    We focus on people, our residents, their lives, their health and their families. At our client centers, our goal is to provide compassionate, family oriented short-term and long-term care that respects the dignity and rights of each resident. Our aim is to care for everyone the way we would care for our family members.",
			Company = "Greenview Manor",
			City = "Waco",
			State = "TX",
			PostedDate = new DateTime(2020,1,7),
			MinimumSalary = 92000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "98b1daca455dfed87bd922041212f84d",
			Title = "LPN Licensed Practical Nurse",
			Description = "The caring. The compassion. The healing. It starts with you.     WHO YOU ARE:    You are a hands-on Licensed Practical Nurse (LPN) or Licensed Vocational Nurse (LVN) eager to provide quality continuous care to your patients. In addition, you have a heart to serve others by caring for the patients individualized needs the way you?d care for the needs of your own family.   WHAT THIS ROLE CAN OFFER YOU:    In this role, you will provide direct patient care within a skilled nursing facility. You?ll follow the plan of care, assessing patients, administering medications and treatments, preparing supplies and equipment for treatments, and assisting the attending physician or registered nurse in performing specialized procedures.  ?  Each LPN/LVN must possess a current state licensure for consideration.   WHO WE ARE:    We focus on people, our residents, their lives, their health and their families. At our client centers, our goal is to provide compassionate, family oriented short-term and long-term care that respects the dignity and rights of each resident. Our aim is to care for everyone the way we would care for our family members.",
			Company = "Pendleton Health and Rehabilitation Center",
			City = "Mystic",
			State = "CT",
			PostedDate = new DateTime(2020,1,7),
			MinimumSalary = 59000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "8c5d72e04e3a159b156a98f2d9d6035a",
			Title = "Network Operations Technician",
			Description = "Network Operations Technician will receive, analyze, monitor and resolve network problems in a timely fashion with minimal guidance from more senior technicians or supervisor. Responsibilities will include opening trouble tickets for various customers, answering incoming telephone calls, responding to network alarms and customer emails, and documenting/updating customer account data. Education: High school or equiv. plus 2 years formal electronics training or equivalent knowledge through experience. Associates Degree in related field preferred. Minimum 2 yrs related telecommunications experience or 1 yr as NOS with satisfactory or better performance. Industry certifications, related experience in the military and physical line or protocol experience is preferred. Basic knowledge of UNIX operating system is a plus. AdditionalRequirements: Microsoft Office software suite...emphasis in both Excel and Outlook. Positionrequires shift work based on days of the week or hours. This is for either the Sunday through Thursday shift 3pm-11pm or Tuesday through Saturday shift 3pm-11pm. US citizenshiprequired.   Required Skills   Required Experience   ",
			Company = "Avacend, Inc.",
			City = "Reston",
			State = "VA",
			PostedDate = new DateTime(2020,1,17),
			MinimumSalary = 40000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "f9b628f91e068a1b99803bd4661498a1",
			Title = "LPN Licensed Practical Nurse",
			Description = "The caring. The compassion. The healing. It starts with you.     WHO YOU ARE:    You are a hands-on Licensed Practical Nurse (LPN) or Licensed Vocational Nurse (LVN) eager to provide quality continuous care to your patients. In addition, you have a heart to serve others by caring for the patients individualized needs the way you?d care for the needs of your own family.   WHAT THIS ROLE CAN OFFER YOU:    In this role, you will provide direct patient care within a skilled nursing facility. You?ll follow the plan of care, assessing patients, administering medications and treatments, preparing supplies and equipment for treatments, and assisting the attending physician or registered nurse in performing specialized procedures.  ?  Each LPN/LVN must possess a current state licensure for consideration.   WHO WE ARE:    We focus on people, our residents, their lives, their health and their families. At our client centers, our goal is to provide compassionate, family oriented short-term and long-term care that respects the dignity and rights of each resident. Our aim is to care for everyone the way we would care for our family members.  ",
			Company = "Newport Health and Rehabilitation Center",
			City = "Newport",
			State = "TN",
			PostedDate = new DateTime(2020,1,7),
			MinimumSalary = 37000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "076bf0a0e57eba46ae1c35a13560de37",
			Title = "LVN Licensed Vocational Nurse",
			Description = "The caring. The compassion. The healing. It starts with you.     WHO YOU ARE:    You are a hands-on Licensed Practical Nurse (LPN) or Licensed Vocational Nurse (LVN) eager to provide quality continuous care to your patients. In addition, you have a heart to serve others by caring for the patients individualized needs the way you?d care for the needs of your own family.   WHAT THIS ROLE CAN OFFER YOU:    In this role, you will provide direct patient care within a skilled nursing facility. You?ll follow the plan of care, assessing patients, administering medications and treatments, preparing supplies and equipment for treatments, and assisting the attending physician or registered nurse in performing specialized procedures.  ?  Each LPN/LVN must possess a current state licensure for consideration.   WHO WE ARE:    We focus on people, our residents, their lives, their health and their families. At our client centers, our goal is to provide compassionate, family oriented short-term and long-term care that respects the dignity and rights of each resident. Our aim is to care for everyone the way we would care for our family members.  ",
			Company = "Levelland Nursing & Rehabilitation Center",
			City = "Levelland",
			State = "TX",
			PostedDate = new DateTime(2020,1,7),
			MinimumSalary = 33000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "72f1c1373ae2d2f6b54811a45ecc0dac",
			Title = "Senior Superintendent",
			Description = "Title: Sr/Lead?Superintendent??  Location:?Los Angeles, CA (Los Angeles County)?  Industry:?Commercial/Largescale?Residential?  Type:?Large-Scale Multifamily 250+ Unit - Mix-Use 3/4/5 over 1 - Woof Frame - Podium - with Subertanean?(underground) parking.?  Category:?Ground up??  Project Budget:?75-300 million?  Must have skills and Requirement Quick Facts:?  - 15+ years of experience  - Manage 50-300 million Dollar projects onsite  - Manage 2-3 supers onsite and other field staff?  - Full responsibility & ownership for field staff on his or her project  - A history of managing Multifamily 250+ Unit - Mix-Use 3/4/5 over 1 - Woof Frame - Podium Projects in densely populated areas  - Create and manage projects schedules  - manage all sub-trades accordingly? ??  - Read and interpret blueprints?  - Leadership capabilities?  - Clear and concise?communications skills?  - Job Stability  - Must have a project list and references?  - Ideally coming out?of a reputable and recognizable GC/Design-biuld firm?  Base Compensation:? 150k-225k? ?  Truck allowance?  Full benefits  Employment Type: Full Time Years Experience: 15+ years Bonus/Commission: Yes",
			Company = "Diamond Peak Recruiting LLC",
			City = "El Segundo",
			State = "CA",
			PostedDate = new DateTime(2020,1,3),
			MinimumSalary = 46000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "72a6dcff6702c273fdf857473c4f198a",
			Title = "LVN Licensed Vocational Nurse",
			Description = "The caring. The compassion. The healing. It starts with you.     WHO YOU ARE:    You are a hands-on Licensed Practical Nurse (LPN) or Licensed Vocational Nurse (LVN) eager to provide quality continuous care to your patients. In addition, you have a heart to serve others by caring for the patients individualized needs the way you?d care for the needs of your own family.   WHAT THIS ROLE CAN OFFER YOU:    In this role, you will provide direct patient care within a skilled nursing facility. You?ll follow the plan of care, assessing patients, administering medications and treatments, preparing supplies and equipment for treatments, and assisting the attending physician or registered nurse in performing specialized procedures.  ?  Each LPN/LVN must possess a current state licensure for consideration.   WHO WE ARE:    We focus on people, our residents, their lives, their health and their families. At our client centers, our goal is to provide compassionate, family oriented short-term and long-term care that respects the dignity and rights of each resident. Our aim is to care for everyone the way we would care for our family members.  ",
			Company = "Retama Manor Nursing Center/San Antonio West",
			City = "San Antonio",
			State = "TX",
			PostedDate = new DateTime(2020,1,7),
			MinimumSalary = 45000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "db7c332feb849c822666e0ac336dbab3",
			Title = "LPN Licensed Practical Nurse",
			Description = "The caring. The compassion. The healing. It starts with you.     WHO YOU ARE:    You are a hands-on Licensed Practical Nurse (LPN) or Licensed Vocational Nurse (LVN) eager to provide quality continuous care to your patients. In addition, you have a heart to serve others by caring for the patients individualized needs the way you?d care for the needs of your own family.   WHAT THIS ROLE CAN OFFER YOU:    In this role, you will provide direct patient care within a skilled nursing facility. You?ll follow the plan of care, assessing patients, administering medications and treatments, preparing supplies and equipment for treatments, and assisting the attending physician or registered nurse in performing specialized procedures.  ?  Each LPN/LVN must possess a current state licensure for consideration.   WHO WE ARE:    We focus on people, our residents, their lives, their health and their families. At our client centers, our goal is to provide compassionate, family oriented short-term and long-term care that respects the dignity and rights of each resident. Our aim is to care for everyone the way we would care for our family members.  ",
			Company = "Aspen Living Center",
			City = "Colorado Springs",
			State = "CO",
			PostedDate = new DateTime(2020,1,7),
			MinimumSalary = 90000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "4d33f8c297e64694c16459a820998ca7",
			Title = "LPN Licensed Practical Nurse",
			Description = "The caring. The compassion. The healing. It starts with you.     WHO YOU ARE:    You are a hands-on Licensed Practical Nurse (LPN) or Licensed Vocational Nurse (LVN) eager to provide quality continuous care to your patients. In addition, you have a heart to serve others by caring for the patients individualized needs the way you?d care for the needs of your own family.   WHAT THIS ROLE CAN OFFER YOU:    In this role, you will provide direct patient care within a skilled nursing facility. You?ll follow the plan of care, assessing patients, administering medications and treatments, preparing supplies and equipment for treatments, and assisting the attending physician or registered nurse in performing specialized procedures.  ?  Each LPN/LVN must possess a current state licensure for consideration.   WHO WE ARE:    We focus on people, our residents, their lives, their health and their families. At our client centers, our goal is to provide compassionate, family oriented short-term and long-term care that respects the dignity and rights of each resident. Our aim is to care for everyone the way we would care for our family members.  ",
			Company = "Grande Prairie Health and Rehabilitation Center",
			City = "Pleasant Prairie",
			State = "WI",
			PostedDate = new DateTime(2020,1,7),
			MinimumSalary = 67000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "00ff9937578d38efb7eebce811be8210",
			Title = "Activity Assistant",
			Description = "Activity Assistant Description    Summary     Assists the Activity Manager in providing an ongoing program of activities designed to meet the interests and physical, mental, and psychosocial well being of each patient.         Essential Duties & Responsibilities       \t Assists and works with individual volunteers and volunteer programs at the request of the Activity Manager.   \t Conducts activity programs as planned to meet the functional levels, needs and interests of each patient as assigned by manager.   \t Completes appropriate records indicating patient's attendance and participation in individual and group activities in an accurate and timely manner.   \t Completes assessments, MDS, care plans and gathers information to design activities that are multi-faceted, meet patients' functional levels, and reflect needs and interests of each patient as assigned by supervisor.   \t Assists with escorting patients to and from activities.   \t Assists in the development of the Activity calendars.   \t Completes required forms and documents in accordance with company policy and state and/or federal regulations.    \t Performs other duties as assigned.      Job Summary \r                  \r                      \r                          Location \r                              Rome, GA 30165-1307 \r                      \r                  \r                              \r                      \r                          Posted \r                          Today \r                      \r                  \r                              \r                      \r                          Reference code \r                          00703326",
			Company = "Rome Health and Rehabilitation Center",
			City = "Rome",
			State = "GA",
			PostedDate = new DateTime(2020,1,13),
			MinimumSalary = 44000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "2b0052d19cc5508faa761d470850b7a4",
			Title = "Sr. NativeScript and Angular Mobile Developer",
			Description = "Required Skills: Angular, NativeScript, Rest, NodeJS, Mobile  This role also requires you to demonstrate leadership as a mobile   developer and have a strong knowledge of end to end mobile   development, testing and deployment process with iOS and Android Apps.  It is advantageous to have working knowledge of application security,   test driven development, code quality best practices and performance,   and have the ability to problem solve to maintain the high-quality experience our clients have come to expect.  Requirements:   Solid hands on experience with NativeScript and Angular 6+  Experience with Typescript and ES6 standards  Desire to learn new technologies quickly and work in a fast-paced environment  Excellent verbal/written communication skills.  Experience with mobile development and testing toolchains  Familiarity with native build tools, like XCode, Gradle  Knowledge of NodeJS and/or NPM plugins (i.e..GruntJS Or Gulp)  Understanding of REST APIs, the document request model, and     offline storage  Experience with automated testing suites  Experience with Java/Springboot stack is a plus",
			Company = "Right Source Technologies Inc",
			City = "Jersey City",
			State = "NJ",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 81000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "2c80aed47377bf3cbc99dba0173bb43c",
			Title = "SAP SCM Consultant",
			Description = "Hi,   I have an urgent requirement for  SAP SCM Consultant @ Boston,   MA . Please let me know if you would be interested and get   back to me with your updated resume.   Given below is the job description. Please feel free to reach me   @  408-512-2044.  Here is some background on the   position: I look forward to speak with you!!!   Position    :   SAP SCM Consultant   Location  :  Boston, MA   Job Type  :  Contract      Job Description:  Scope/ Description of Services:    Develop and optimize existing Supply Chain Management process for     best operational practices  Train Supply Chain team on sequencing job instruction  Develop Supply Chain Standards with best practices and experience  Communication with internal and external sources  Support cross-department improvements activities WPS, Workshops ect.  Lead/Support SCM plant layout activities  Support all improvement activities with appropriate summaries     provided to management, support with MMOG and support with all     customer audits    Regards,    Prasanna   Sr.Technical Recruiter  408.512.2044   57 West 38th Street,  New York, NY 10018, United States ",
			Company = "TVS Infotech Inc.",
			City = "Pittsburgh",
			State = "PA",
			PostedDate = new DateTime(2020,1,13),
			MinimumSalary = 38000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "ea621c1f038f28e1e1ae1ea03bf7db4b",
			Title = "Audiologist or Hearing Instrument Specialist",
			Description = "Overview  We are a growing hearing healthcare practice in Salinas, CA and currently seek an Audiologist or Hearing Instrument Specialist who is driven, self-motivated, and passionate about helping patients hear well again. The ideal candidate must be strong clinically and have the ability to effectively counsel while building patient rapport.?  ?  ?    Daily tasks and responsibilities      Establish rapport with, and gather history from, patients; conduct audiometric testing; counsel patients; and make recommendations for hearing aids.   Make ear impressions, ear molds, and order instruments.   Program hearing aids using a computer.    Fit hearing aids and assist with any adjustments, questions or problems.    Maintain documentation and patient files.    ?  ?    Qualifications      Masters Degree in Audiology but Au.D. is preferred.   Active and current hearing aid dispensing license.   ?   The successful Audiologist will also possess the following:     Strong interpersonal and organizational skills    The ability to work in a team environment    The ability to interact professionally at all times with patients, physicians, and team members.",
			Company = "American Hearing Aids Associates",
			City = "Salinas",
			State = "CA",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 86000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d1cbee0fb48c0b19b96c3bad1e6f246c",
			Title = "CAD Electrical Design Engineer",
			Description = "Engineer-Electrical III Start: ASAP Work Location: Sterling Virginia USA Need PC Board Layout Design Experience (MUST HAVE) Digital and Analog design experience Experience in Axium preferred (will take any CAD experience Schematic Capture Experience designing from the development stage Support Production Troubleshoot with the Engineering team Aviation is only a plus not a must have Experience in lieu of a degree is fine Non-Local candidates can be considered Description: Job Summary: Manage and coordinate projects for products using sound technical engineering and project management principals to ensure robust, airworthy designs and accomplishing project and business objectives. Duties: Able to work independently to support engineering efforts; Provides input to programs and projects; Independently owns, or leads a team for small/medium size projects; Leads and owns all aspects of product design life cycle including research, proposal, development and production phases; Takes responsibility (technical and project management) small/medium projects with support from management and/or higher level engineers on activities. Experience: 6+ years ? Requires in-depth knowledge and experience ? Solves complex problems; takes a new perspective using existing solutions ? Works independently; receives minimal guidance ? Acts as a resource for colleagues with less experience ? Represents the level at which career may stabilize for many years or even until retirement Education: Bachelor's Degree in Engineering (or equivalent) from a recognized institution. - provided by Dice Job Summary Location Sterling, VA 20166 Posted Today Reference code 6874_e74b576710715b6f643d4434b8bbf109",
			Company = "Modis",
			City = "Sterling",
			State = "VA",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 31000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "bd90a4d295a4cbe54fca0c16f03ef134",
			Title = "Preschool Photographer",
			Description = "Join our team as a Preschool Photographer!   Part-time positions available.    As a Photographer, you:       Have the opportunity to  capture  several hundred  smiles  every week!   Use a complete mobile studio and  professional photography equipment !   Enjoy  traveling  to assigned Picture Day locations in the comfort of your own vehicle!   Participate in training to  increase  your  photography   skills  and experience!   Will  start your work   day early  and end about the same time as the average school day.   Have  summers off , between spring and fall season Picture Days!      Our Preschool Photographers Enjoy      Competitive hourly wage   Paid drive-time   Seasonal schedule flexibility (with summers off)   Comprehensive paid training      Requirements/Qualifications      Eager to learn and deliver excellent customer service skills   High School diploma or GED, strongly preferred   Ability to work early morning hours   Reliable, insured vehicle and valid U.S. driver's license      Apply today!    Lifetouch, a Shutterfly Inc. Company is an Equal Opportunity Employer.  Employment with Lifetouch is contingent upon satisfactory results of a criminal background and driving record check. ",
			Company = "Lifetouch Preschool Portraits",
			City = "Eastvale",
			State = "CA",
			PostedDate = new DateTime(2020,1,9),
			MinimumSalary = 62000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "5c2928e81c9c61dd4a9a129579b7f8f5",
			Title = "Preschool Photographer",
			Description = "Join our team as a Preschool Photographer!   Full-time positions available.    As a Photographer, you:       Have the opportunity to  capture  several hundred  smiles  every week!   Use a complete mobile studio and  professional photography equipment !   Enjoy  traveling  to assigned Picture Day locations in the comfort of your own vehicle!   Participate in training to  increase  your  photography   skills  and experience!   Will  start your work   day early  and end about the same time as the average school day.   Have  summers off , between spring and fall season Picture Days!      Our Preschool Photographers Enjoy      Competitive hourly wage   Paid drive-time   Seasonal schedule flexibility (with summers off)   Comprehensive paid training      Requirements/Qualifications      Eager to learn and deliver excellent customer service skills   High School diploma or GED, strongly preferred   Ability to work early morning hours   Reliable, insured vehicle and valid U.S. driver's license      Apply today!    Lifetouch, a Shutterfly Inc. Company is an Equal Opportunity Employer.  Employment with Lifetouch is contingent upon satisfactory results of a criminal background and driving record check.",
			Company = "Lifetouch Preschool Portraits",
			City = "Northridge",
			State = "CA",
			PostedDate = new DateTime(2020,1,9),
			MinimumSalary = 83000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "27d27ad279f1dfcb97509128055e1091",
			Title = "Manager, IT Center of Excellence",
			Description = "Description:  Our client would like us to provide them with a     Manager, IT Center of Excellence. In this role, the successful     candidate will be in charge of IT Processes including Projects,     Change Control, SOX Control, Procurement, etc.     Responsibilities:    Focus and understanding of     the environment in which you will be working in.  Evaluate the big picture     and determine where and how much process to implement and where     process will give the best ROI.   Implementation of process.   Oversee and understand the     IT budgeting process.   Onboarding of Project Managers.    Required:    Experience running a PMO  A process-centric mind     with flexibility  Excellent communication skills  A methodical, thoughtful     and calm demeanor  Experience with project     management software (experience w/Workfront would be a plus)    Desired:    Experience running an IT     Center of Excellence would be a big plus  Experience with ServiceNow  Experience in the     manufacturing/distribution industry would be a plus  Experience with global     organizations would be a plus  Experience in     organizations that are involved in mergers and acquisitions is a plus",
			Company = "e-Primary",
			City = "Dunwoody",
			State = "GA",
			PostedDate = new DateTime(2020,1,13),
			MinimumSalary = 45000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "c3dc419365322474121b12bc2c5205c4",
			Title = "Research Fellow- Children's Anesthesia Association",
			Description = "Anesthesia Fellow  About Nationwide Childrens Hospital  Named to the Top 10 Honor Roll on U.S. News & World Reports 2019-20 list of Best Childrens Hospitals, Nationwide Childrens Hospital is one of Americas largest not-for-profit freestanding pediatric health care systems providing wellness, preventive, diagnostic, treatment and rehabilitative care for infants, children and adolescents, as well as adult patients with congenital disease. Nationwide Childrens has a staff of more than 13,000 providing state-of-the-art pediatric care during more than 1.5 million patient visits annually. As home to the Department of Pediatrics of The Ohio State University College of Medicine, Nationwide Childrens physicians train the next generation of pediatricians and pediatric specialists. The Abigail Wexner Research Institute at Nationwide Childrens Hospital is one of the Top 10 National Institutes of Health-funded freestanding pediatric research facilities. More information is available at NationwideChildrens.org.  Requisition ID: 2020-22447   External Company Name: Nationwide Children's Hospital   External Company URL: https://external-nationwidechildrens.icims.com/jobs/intro   Street: 700 Children's Dr",
			Company = "Nationwide Children's Hospital",
			City = "Columbus",
			State = "OH",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 37000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "0bf6299133571dfb6b822de748dd74ea",
			Title = "Information Systems Manager",
			Description = "REQ#: RQ45987 Travel Required: None   Responsible for management of all LVC personnel in the NTC TSC Simulations Room to operate and maintain the NTC JLCCTC 8.1 Federation and provide integrated LVC simulation support for every training evolution (includes: VUAV, TECH Control, NVIG/MUSE, BE Server, MCS GTWY/ADAPTER, ESS, SE Core) to include 24/7 rotational support as needed.  We are GDIT. The people supporting some of the most complex government, defense, and intelligence projects across the country. We deliver. Bringing the expertise needed to understand and advance critical missions. We transform. Shifting the ways clients invest in, integrate, and innovate technology solutions. We ensure today is safe and tomorrow is smarter. We are there. On the ground, beside our clients, in the lab, and everywhere in between. Offering the technology transformations, strategy, and mission services needed to get the job done.  GDIT is an Equal Opportunity/Affirmative Action employer. All qualified applicants will receive consideration for employment without regard to race, color, religion, sex, sexual orientation, gender identity, national origin, disability, or veteran status, or any other protected class. ",
			Company = "GDIT",
			City = "Fort Irwin",
			State = "CA",
			PostedDate = new DateTime(2020,1,15),
			MinimumSalary = 59000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "414bb3e1e6e86a21ec4d0d5ac4cb833b",
			Title = "Hospital Account Manager",
			Description = "A leading healthcare recruiting firm conveniently located in downtown Cleveland, OH is looking to add a talented, forward-thinking Healthcare Account Manager to their sales team.Clinical Management Consultants (CMC) is a contingency firm specializing in the placement of healthcare executives, nursing leadership and advanced practice providers within the healthcare industry.  In this full cycle Recruiting position, the Healthcare Account Manager is responsible for managing new and current client job orders while also recruiting to fill each position.This is a performance driven sales role so each Account Manager must be willing to drive business results.  To be successful, you must be goal oriented and have a successful track record of meeting and succeeding sales quotas.  Core responsibilities include:   Business Development including cold/warm calls  Maintaining client relationships  Team collaboration  Objection handling  Negotiations  Continued Learning  Creative writing   CMC Healthcare Account Managers are on a career path towards excellence.You must have a strategic mind set and a hard-working attitude.  The CMC compensation package is phenomenal: salary + uncapped commission + profit sharing + career growth.  ",
			Company = "Clinical Management Consultants",
			City = "Cleveland",
			State = "OH",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 43000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "e0cf0c998707dca60d43ad13aee816a7",
			Title = "Dental Hygienist w / Benefits",
			Description = "Are you sincere and caring? Do you appreciate working in a positive, enjoyable atmosphere where you can feel proud of the work you do and be recognized for your efforts? If so, look no further. Heartland Dental is seeking a full-time Dental Hygienists at multiple offices in the area.  South Western Family Dental: 6616 S Western Ave, Oklahoma City, OK 73139 Quail Springs Dental Care: 14221 N Pennsylvania Ave Ste C, Oklahoma City, OK 73134 Casady Dental Care: 9405 N Penn Place, Casady Ln, Oklahoma City, OK 73120 Dental Care of Norman: 1732 24th Ave NW C-107, Norman, OK 73069 Pebble Creek Dental: 1041 E, E State Hwy 152, Mustang, OK 73064  We have a beautiful modern dental offices, a wonderful patient population, an enthusiastic team, and sincere dentists dedicated to quality care. Our office provides Continuing Education Credit Opportunities annually for team members.  Full medical/dental benefits, life insurance,?paid time off, paid holidays, daily bonus opportunities, 401K, continuing education and opportunities to grow witht the company!  Open to discussing sign on bonuses ($2500-5000)  Comptetitive Hourly Pay: $35.00-48.00 (varies depending on experience level)  Employment Type: Full Time Salary: $40+ Hourly Bonus/Commission: Yes",
			Company = "Heartland Dental",
			City = "Oklahoma City",
			State = "OK",
			PostedDate = new DateTime(2020,1,8),
			MinimumSalary = 49000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "f39204390dcc92dfc7d8ed58b99e0708",
			Title = "Senior Desktop Engineer - trade floor support, MSP",
			Description = "Our direct client is a thriving Financial MSP that is looking for a   senior desktop engineer with extensive infrastructure experience to   directly support their clients  trading environments.  We are looking for a  seasoned veteran of the trade   floor    someone who is capable of supporting demanding users   at primarily the desktop level. Participate in project work and serve   as an escalation point for service desk issues that require an on-site engineer.   Requirements:    3+ years supporting hedge funds or similar financial services firms  Strong skills with Market data feeds, advanced Excel, trading     turrets, mobile devices, imaging.  Systems and network-level experience is desired    Company:  MSP that supports hedge funds in local NYC area   Salary:  90k to 105k + bonus and benefits   Location:  midtown. Client locations are local to Manhattan.  Those authorized to work in the United States without sponsorship are   encouraged to apply.s and those authorized to work in the United   States are encouraged to apply. We are unable to sponsor at this time.",
			Company = "Ascend It Staffing",
			City = "Purchase",
			State = "NY",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 93000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "3518ecd5f03aac289826f13396ca5e5f",
			Title = "QA Tester (Contractor)",
			Description = "Responsibilities      Run assigned test requests and identify game issues (bugs)   Enter accurate high-quality game issues based on department standards into bug tracking system   Test and verify bug fixes   Provide thoughtful and professional feedback on gameplay related issues in both written and verbal form.   Assist in assessing and escalating game issues and concerns with peers and to senior team members   Learn and apply testing and game industry terminology   Lean and become fluent in the rules of each game and apply knowledge to testing      Requirements      Good understanding of test processes   Ability to learn quickly and apply knowledge   Able to follow direction and complete assigned tasks in a timely manner   Strong verbal and written communication skills   Good organizational skills, ability to remain focused   Excellent interpersonal and conflict resolution skills   Broad knowledge of games across different platforms   Proficient with MS Office      Desired Skills and Pluses      Experience and understanding of console and PC game testing   Games Industry experience preferred but not necessary   6+ Months experience in software testing   Bachelors Degree or equivalent desirable",
			Company = "ZeniMax Media, Inc.",
			City = "Richardson",
			State = "TX",
			PostedDate = new DateTime(2020,1,13),
			MinimumSalary = 80000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "83f10e305546526bfa000473e7baccdd",
			Title = "Full Stack Software Application Developer/Analyst ( Chandler, AZ ) 9727055",
			Description = "Full Stack Software Application Developer/Analyst ( Chandler, AZ ) 9727055   12 Month Contract    New-hire candidate will act as a full-stack software developer developing innovative solutions that satisfy business requirements. Will work with multiple functional departments throughout the product life cycle utilizing an AGILE approach. Candidate will be responsible for evaluating and implementing different web based technologies such as JQuery, CSS, AJAX, SharePoint, and SQL for enterprise wide applications. Evaluates performance and provides support for existing applications. Will work on a collaborative team of software developers.  ?   Desired Skills:   Familiar with full stack web development (HTML,CSS, JavaScript, JQuery, AJAX)  Hands on programming knowledge of Share Point database development  Object Oriented Programming experience  Experience in developing front end interfaces, UX experience is a plus  Familiarity with ECMAScript versions for multi-browser support  ?   Education / Certification   High School diploma or equivalent and 4 years additional education and/or related experience  BS degree is desired  Active Secret clearance would be nice to have but all candidates need to have the ability to obtain secret clearance.",
			Company = "TalentPro",
			City = "Chandler",
			State = "AZ",
			PostedDate = new DateTime(2020,1,15),
			MinimumSalary = 70000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "f3eb169c452630cf920005c7c9b52936",
			Title = "Full Stack Web Developer",
			Description = "We are currently hiring a Senior Full Stack Developer who will be responsible for the front and back end development of a corporate website.  ?  RESPONSIBILITIES:   Utilize front end mark up and scripting languages to modify, build and maintain developments for our website  Maintain, develop and test server side code using C# and SQL  Build REST and SOAP API's  Collaborate with our development and marketing team to add/modify/test new features  Test software and databases  Review code and contribute to coding documentation   REQUIREMENTS:   At least 5 years working professionally as a full stack web developer  Must have ecommerce experience  5+ years experience writing and testing ASP.Net, C#, JavaScript, MVC and SQL  Bachelor's degree in CS, CIS, IT, MIS or related degree, or equivalent experience  Solid understanding of the fundamentals of development cycle and operations  Familiarity with Agile methodology  Git? experience  Pluses: Azure, AWS, Jira   ?   Employers Pro Advantage Inc. a Native Alaskan Women owned sdb specializing in the placement of highly skilled professionals in Accounting and Finance, IT/MIS and Biomedical.?Employers Pro Advantage Inc. has been in business since 1997 servicing New Mexico and the surrounding states with high results.",
			Company = "Employers Pro Advantage",
			City = "Albuquerque",
			State = "NM",
			PostedDate = new DateTime(2020,1,3),
			MinimumSalary = 66000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "581004f17fa52be3cff58f602e85180d",
			Title = "Software QA Engineer 2",
			Description = "RESPONSIBILITIES: Kforce has a client that is seeking a Software QA Engineer 2 in Plano, Texas (TX).   Responsibilities: * Collaborate closely with other team members and departments * Detect and track software defects and inconsistencies * Report defects or test results against project management tools  REQUIREMENTS: * Bachelor's degree in Engineering, Computer Science, ITS, or related to quality assurance/telecommunication engineering * Experience: 5~7 years of experience  Requirements/Qualifications: * Ability to tackle multiple tasks (5~10) simultaneously * Critical thinker and should be able to develop constructive/comparative analysis of two or more subjects * Experience in Data Science, Linguistics, Application Testing, or Machine Learning highly preferred * Experience working in Agile environment is a plus * Ability to conduct both manual/automation test for AI voice engine * Actively plan, execute, report, and close test plan against requested deadline   Kforce is an Equal Opportunity/Affirmative Action Employer. All qualified applicants will receive consideration for employment without regard to race, color, religion, sex, pregnancy, sexual orientation, gender identity, national origin, age, protected veteran status, or disability status.",
			Company = "Kforce Technology Staffing",
			City = "Plano",
			State = "TX",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 45000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "80557de1ed7f47bfe3fdd9e7bcb92641",
			Title = "Cardiac Interventional Technologist",
			Description = "There is an opening for Cardiac Cath Lab and Interventional Radiology Tech in a fast paced, reputable hospital located in the Greater Baltimore area. The Cardiac Cath Lab and Interventional Radiology Tech will have their ARRT and CRT certifications and will perform procedures with expertise and quality patient care. The Cardiac Cath Lab and Interventional Radiology Tech will have previous procedural experience. Cutting edge cardiac procedures including cardiac interventions via trans-radial approach and IMPELLA, large structural heart program including TAVR, Watchman, PFO closure/ASD repair, Valvuloplasty, and Mitra clip procedure. The unit also has a high focus on research and new procedures. Cardiac Cath Lab and Interventional Radiology Tech opening is at a large, nonprofit hospital. This short term acute care, teaching facility is dedicated to continuing to maintain up to date evidence based practice and patient centered care. All technology and medical equipment are the latest available for patients and this acute care hospital continues to be rated high in patient satisfaction and technical skill. Situated in vibrant Baltimore, the innovated hospital is surrounded by natural beauty and historic charm, just a short drive from the coast. Popular among young professionals and growing families, this city offers upscale crab shacks, trendy shops and historic attractions in the harbor. The Cardiac Cath Lab and Interventional Radiology Tech will enjoy fine dining, great shopping and entertaining night life all year round. This position offers the Cardiac Cath Lab and Interventional Radiology Tech competitive salary and excellent benefits. Apply today and join an award-winning facility! monsterboost9999 Job Summary Location Dundalk, MD Posted 1 Days ago Reference code 244552020-01-27",
			Company = "Clinical Management Consultants",
			City = "Dundalk",
			State = "MD",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 79000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "b69fedcf51071aa4a625dad0f1822c29",
			Title = "Entry Level Computer Programmer",
			Description = "As the fastest growing employer of emerging tech talent across the U.S, Revature looks to hire over 300 innovative Entry Level Computer Programmers in the next 4 weeks.  One day someone is going to ask you where you got your start?This is IT!  With a wide range of Fortune 500 enterprises, government organizations and top systems integrators as our clients, we not only provide you with the skills needed to succeed through an employer-paid training program? but will also give you the opportunity to put those skills to use, on projects that matter .     What We Are Looking For    College degree (Associates or Bachelors)  Must be authorized to work in the US  Strong desire to learn to code ? No prior professional experience required.?  A natural problem solver  Strong communication and interpersonal skills  Willing to relocate anywhere in the US ? Relocation assistance provided    What We Offer    Competitive salary  Relocation and housing assistance  Health, vision and dental insurance  Paid time off  Industry Certifications  Life Insurance Policy  401k  Mentoring program and ongoing support throughout your entire Revature career  Experience with the largest and most reputable companies in the US    Apply Today. Interviews are going on now.  #SoftwareEngineering ",
			Company = "Revature",
			City = "Sherwood",
			State = "OR",
			PostedDate = new DateTime(2020,1,8),
			MinimumSalary = 93000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d6317d10d634ac186430681797778c3c",
			Title = "EEG Tech I, Full-Time (Rotating)",
			Description = "Prepares and conducts various electroencephalographic examinations, basic EEG''s, extended epilepsy monitoring, extended monitoring, intra-operative monitoring, and evoke potentials. Conducts various electroencephalographic examinations and collects information pertinent to the interpretation of the test.    Evaluates the function and provisions of services to patients by use of equipment, effective communication skills within and between departments and the close coordination with the department director, Medical Director, and Medical Staff. Assures methods of compliance with JCAHO, Medicare, conditions of participation and other regulatory and practice standards. Provides care to patients along the age continuum, and provides care based on age appropriate interventions.   Required Skills  1. Effective oral communication skills.  2. Knowledgeable of or ability to learn various electroencephalographic procedures and processes.   Required Experience  A. Work Experience: One year experience in EEG. Previous knowledge of electroencephalography preferred.  B. License/Registration/Certification: CPR Certified  C. Education and Training: High School diploma or equivalent and graduate of an accredited electroneurodiagnostic technology program; Eligible for Part I (written) examination for registry by ABRET.",
			Company = "University Medical Center of El Paso",
			City = "El Paso",
			State = "TX",
			PostedDate = new DateTime(2020,1,4),
			MinimumSalary = 56000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "76d1560c11633ed3bb4ed049f3f030df",
			Title = "PORTUGUESE/CAPE VERDEAN  INTERPRETER / PER DIEM / ROTATING - BWH INTERPRETER SERVICES",
			Description = "Responsible for assessing the needs of non-English speaking and hearing impaired patients and providing assistance by interpretation of consent forms, diagnoses, discharge plans and any other type of patient-related information. Independently resolves most issues that arise in their daily responsibilities, answers questions about protocols and makes appropriate referrals without direct supervision. Serve as a resource to both patients and providers to contribute to successful outcomes. Comply with appropriate BWH policies and procedures.        Qualifications    1. Bachelors Degree with a concentration in a human relations field (i.e. Sociology, Psychology) highly preferable.  2. At least 2 years of college level education and 2 years of hospital and/or health care related experience in a position of direct patient contact.  3. Fluency of English, Portuguese and Cape Verdean, both written and verbal..  4. Prior training of medical terminology and interpreting skills.  5. Knowledge of culture-specific care.        EEO Statement      Brigham and Women's Hospital is an Equal Opportunity Employer.  All qualified applicants will receive consideration for employment without regard to race, sex, color, religion, national origin, sexual orientation, protected veteran status, or on the basis of disability.  ",
			Company = "Brigham & Women's Hospital(BWH)",
			City = "Boston",
			State = "MA",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 77000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Communications"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "fb6f2d85dd7992e5c3a1c53b66481977",
			Title = "General Manager",
			Description = "The General Manager, reporting directly to the Director of Hospitality, holds duties related to day to day operations of Exxir Hospitality.? The position entails a need for excellent communication skills; ability to multi-task, strong team leadership, client relations and ensures superior food quality and strong customer service skills.         Key Responsibilities :   ?\tOversees all P&L and budgeting as it pertains to the account   ?\tManages overall day to day operations of the concepts   ?\tConducts HR functions including hiring, progressive counseling, terminations   ?\tOversees scheduling, payroll and team training   ?\tMaintains excellent relationships with customers, guests and Client as well as other departments   ?\tWorks with the Chef and management team in creating menus and providing top quality food   ?\tRolls out new culinary programs in conjunction with Exxir marketing and culinary team       Preferred Qualifications:    ?\tBS, Hospitality or Culinary degree preferred   ?\t5-10 years of Experience in high volume restaurant as a general manager, required.   ?\tHigh volume production and catering experience is essential   ?\tPrevious experience managing a budget   ?\tDesire to learn and grow with a top notch foodservice company   ?\tMust have a flexible schedule to include nights & weekends  ",
			Company = "Paradiso",
			City = "Dallas",
			State = "TX",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 41000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "def73fc4c09044faf770b6cba2e5d379",
			Title = "Clinician (Master Level) - Oxford House",
			Description = "Are you looking for an opportunity to grow with an agency that provides excellent services to children and families? JOIN OUR TEAM! YOU, Inc. is currently seeking a talented and innovative Clinician or Social Worker to join our Oxford House Program working with adolescent aged males. Schedule for this position: Sunday (8am-4pm), Monday - Thursday (12pm ? 8pm) Some variability should be expected Tuesday ? Saturday schedule may be considered Responsibilities: Provides and coordinates direct clinical care services to program clients. These clinical services include providing individual, family, and group therapy sessions, conducting any necessary case management, intakes, assessments, risk evaluations, and crisis interventions. Act as a liaison and member of a multidisciplinary team to represent and coordinate services with internal and external agency programs, community agencies, referral sources, and schools. Attend all clinical meetings including DCF related meetings, treatment team meetings, and clinical training. Maintain electronic health records in accordance with program and state regulations. Act as a member of the program team by providing and contributing to training as part of clinical training series and weekly staff meetings, as well as other responsibilities designated by the supervisor. CANS Certification and TF-CBT webinar completion required and to be maintained throughout tenure in position. Qualifications: MA/MS in psychology, social work, counseling or related field is required LICSW, LMHC, LMFT or PsyD strongly is preferred Experience with adolescents in a residential setting Candidate must be at least 21 years of age Candidate must have a valid driver's license and reliable transportation PM19 PI117371929 Job Summary Location Oxford, MA 01540 Posted Today Reference code 117371929",
			Company = "You, Inc.",
			City = "Oxford",
			State = "MA",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 93000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "aafc5b0bb25d204ac1fc04d491fbe42a",
			Title = "Big Data Developer/Big Data Analyst",
			Description = "Job  Description:    Construct queries to gain an understanding of data sets, discover     data anomalies, and look for ways to leverage data in support of      regulatory mission.  Serve as the subject matter expert for specific surveillance products.  Analyze impacts of enhancements, issues, or changes to data or     surveillance products.  Interact with stakeholders to understand data cases, document and     review requirements, and elicit feedback.  Build strong relationships with stakeholders and develop an     understanding of stakeholder needs for advocacy and planning.  Use statistical and other advanced techniques to analyze and     interrogate data for business insights.  Assimilate and present results and conclusions to a variety of     business and technical stakeholders  Collaborate with the delivery team throughout the SDLC process.     Essential Skills:    Experience manipulating and querying large data sets with one or     more programming languages such as Scala, Python, or SQL.  Excellent written and verbal communication skills, including documentation.  Proficiency with Big Data and Cloud technologies.  Ability to work independently to solve complex problems involving     multiple stakeholders.  Innate curiosity about data and anomaly detection.",
			Company = "ApTask",
			City = "Rockville",
			State = "MD",
			PostedDate = new DateTime(2020,1,1),
			MinimumSalary = 68000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "2187829dc6c1e6ec5b392fa0cde230e5",
			Title = "Data Architect",
			Description = "Tuvli, LLC an Akima Company, is dedicated to providing our customers with superior, integrated technology and program support services and solutions. Our systems engineering, information technology, information assurance, program support and project management staff work closely with customers to ensure that our solutions are directly aligned with their business processes and desired program outcomes. We emphasize affordability, and delivering the best value for technology investments. Our personnel enjoy competitive benefits packages and challenging roles in work environments committed to innovation, diversity and opportunity for career growth. As an Alaska Native Corporation (ANC), 100% of our companys profits go back to our 14,300 Iupiat shareholders that have resided near and above the Arctic Circle for more than 10,000 years. Our business helps support their way of life and contributes to the survival of a culture that has thrived in a challenging environment. Tuvli seeks a Data Architect to: Responsibilities:? - Designs and builds relational databases. Performs data access analysis design, and archive/recovery design and implementation. Develops strategies for data acquisitions, archive recovery, and implementation of a database. Works in a data warehouse environment, which includes data design, database architecture, and metadata repository creation. Translates business needs into long-term architecture solutions. Defines, designs, and builds dimensional databases. Develops data warehousing blueprints, evaluating hardware and software platforms, and integrating systems. Reviews and develops object and data models and the metadata repository to structure the data for better management and quicker access. Job Summary Location El Paso, TX 88568 Posted 6 Days ago Reference code 2365_e0fecb68dc875df2e8d1e3ea11b5c4b5",
			Company = "Akima, LLC",
			City = "El Paso",
			State = "TX",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 54000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "8011948337950d29083cc6b3651f3500",
			Title = "Videographer/Video Content Creator (21702)",
			Description = "As a Videographer, you will be responsible for working with on-camera talent to create informative and engaging videos for the leading online retailer... \tSkill with cameras and lighting \tDesire to continually learn about new video production techniques \tExcellent attention to detail \tAbility self-motivate and stay on task with minimal supervision in a fast-paced environment \tStrong time-management and multi-tasking skills \tAbility to be a team player and embrace constructive feedback ? Day-to-day responsibilities include: \tResearching and reviewing product materials \tShooting installations of products on customer vehicles \tAssisting team in developing innovative video concepts \tTaking full responsibility for setting up and breaking down your work area daily ? Qualifications: \t2+ Years professional video production experience \tExperience with producing videos for the web is a plus \tAbility to operate necessary equipment - cameras, lights, tripods, cranes, gimbals, and computer systems \tPassion for outdoor activities (biking, boating, camping) is helpful ? Physical Requirements: \tWork is performed in a video studio or shop environment. You must be able to be on your feet for extended periods of time, lifting and carrying items such as hitches, bike racks, cargo carriers, and roof racks. Some overhead lifting is required. ",
			Company = "etrailer.com",
			City = "Wentzville",
			State = "MO",
			PostedDate = new DateTime(2020,1,2),
			MinimumSalary = 76000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d682d85c59786098d6a9349f1edb4ff6",
			Title = "Real Estate Closing Coordinator",
			Description = "Job Summary: Homie is looking for a full-time Real Estate Closing Coordinator. Homie has hundreds of new buyers and sellers every month who need your expertise, support, and ?eagle eye? to help our customers successfully get from under contract to closed. Attention to detail is key for this position. The Closing Coordinator position at Homie will coordinate with buyers, sellers, title companies, and lenders, etc. to ensure that every client?s file is perfect prior to close. You will work for a disruptive technology company that does hundreds of deals and is one of the largest brokers in the state. This is your chance to be part of the next big thing.? Primary Responsibilities: Oversee all aspects of buyer &amp; seller transactions leading up to the closing Coordinate title/escrow, mortgage loan, and appraisal processes leading up to the closing Regularly update &amp; maintain communication with clients, agents, title officer, lender, etc Input and manage all client information into CRM Qualifications: Current UT Real estate license preferred but not required Previous experience as a Transaction Coordinator preferred Real estate contract experience preferred Real estate CRM experience a plus Willingness to learn new tools, systems, and technologies People-oriented, positive, and customer-focused attitude Excellent verbal and written communication skills Outstanding organizational and time management skills Character Traits: Able to handle customers? concerns and issues diplomatically Excellent attention to detail Persistent and resilient when facing challenging situations Must be intellectually curious and problem solver Full Time - Weekdays, normal daytime working hours Salary: $32,500? Full company benefits package Job Summary Location South Jordan, UT Posted 23 Days ago Reference code 20200124_P_AAAAAAEAAADFOVNisygdrX",
			Company = "Homie",
			City = "South Jordan",
			State = "UT",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 70000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "6de177fedd29b0089d3a8c3879091850",
			Title = "Java J2EE Developer",
			Description = "Hi,  I have an urgent requirement for JAVA J2EE Developer with experience in Capital Market or BFS domain in Newport Beach, CA   Job Description:    Core Java, Spring, Oracle and at least a year of experience in Capital Market / BFS domain is a must.  Job Description:  Over 8 to 12 years of IT experience in Design / Development (mandatory), preferably in Financial Services / Capital Market area  Strong development experience in Java (Core Java), Spring, RESTful Web services, Maven, IBM MQ  Hands on experience in Oracle Database programming (SQL, PL/SQL, Optimization/Tuning) in Oracle.  Exposure to tools such as Eclipse IDE, Subversion, JIRA, SQL Developer    Hands on experience in Software System Design and Architecture using OOPS, Design Patterns, Datastructure and Algorithms  Strong Knowledge in Software Development Life Cycle  Experience with testing and production support  Should have excellent communication skills. Must be clear at expressing. (very important)     Nice to Have:    Good domain knowledge in Securities Trading, Collateral, Position, Cash and Margin management area  Good to have knowledge in financial instruments like ETF, Repo, Swap, Derivatives and Equities     Thanks &amp; Regards,   Navneet Dubey  Biztegy Analytics, Inc.  (224)-400-9034  (224)-757-8070 (C)  www.biztegy.com",
			Company = "Biztegy Analytics Inc",
			City = "Newport Beach",
			State = "CA",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 40000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "ad31ac448ca3ba84b96e029ea7ee3e6a",
			Title = "Nurse Manager of Emergency Department ED",
			Description = "An exciting and challenging career opportunity for a Nurse Manager of Emergency Department ED is now available at a reputable hospital in warmandsereneCentral Valley of California. The Emergency Room ERNurse Manager will work with a medical center dedicated to serving the surrounding community. For over 75 years, the hospital provides compassionate care using state-of-the-art technology in an inpatient and outpatient setting, as well as reaching out to the community with education, research, andhealthcareoutreach. The Nursing Manager of Emergency Services will be responsible for the financial management, staff management and development, day-to-day operations, and program development in the Emergency Department ED. The Nurse Manager of Emergency Department ED will be managing a 20 bed Emergency Unit with high stroke and cardiac cases. Reporting directly to the Nurse Director of Emergency Department, the Nurse Manager of Emergency Room ER will be supported by approximately 70FTEsand experienced Charge nurses. The Emergency Room ER Nurse Manager will be able to work with tenured andskillfulstaff members and reputable physicians. The team embraces positive work atmosphere with great team work. The Nursing Manager of the Emergency Room ER will work in one of the busiest and fast paced department that serves 40,000 patients per year for both adults and children. They also have more than 3,000 babies born in the Family Life Center with 400 babies cared in the state-of-the-art Neonatal Intensive Care Center. The hospital is located in a great strategic area ofCentral Valley in California. It also offers amazing salary range with comprehensive benefits package. Join a prestigioushealthcareteam that strives for patient care excellence. Apply Now! monsterboost5000 Job Summary Location Livingston, CA Posted 1 Days ago Reference code 232352020-01-14",
			Company = "Clinical Management Consultants",
			City = "Livingston",
			State = "CA",
			PostedDate = new DateTime(2020,1,15),
			MinimumSalary = 40000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "12a152baeff5b239ec00002a2d52d6b5",
			Title = "Telecomm Project Coordinator - Locals Only",
			Description = "Role and Responsibilities    Responsible for the Arizona Department of Transportation (ADOT)     Information Technology Group s (ITG) telecommunications service     requests and project coordination.  Coordinates small to medium-sized telecommunications projects and     service requests based on repeatable standards and practices.  Supports Arizona Department of Transportation telecommunications services.  Acts as a liaison to the state s telecomm provider (AZNet).  Obtains quotes and processes telecomm equipment orders.  Monitors service requests and projects, provides status updates     and escalates as appropriate.  Provides assistance to other team members or project managers as needed.  Any other duties as assigned.        Qualifications and Education Requirements    Customer service principles and processes  Basic to intermediate project coordination  Telecommunications Expense Management  Incident Tracking &amp; Problem Management Tools or Systems        Preferred Skills    Strong customer service  Excellent interpersonal, written and oral communication  Excellent problem-solving/analytical skills and attention to details  Ability to balance, prioritize and organize multiple tasks  Ability to work collaboratively in teams and across organizations  Ability to accept feedback and adjust plans accordingly ",
			Company = "TexcelVision Inc.",
			City = "Phoenix",
			State = "AZ",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 57000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "2494a9ca6a03e082c56019a5c11ca306",
			Title = "BILLING & CODING REP -St Mary's Hospital Labs",
			Description = "This position will be responsible for the review and maintenance of the Hospital and Professional charge documents, charge capture processes for accuracy and completeness, as well as ongoing communication of changes in third-party payer and government payment rules to departmental and clinical staff. This position is responsible for facilitating proper charge capture, billing, clinical documentation practices, and CPT/HCPCS and ICD-9-CM/ ICD-10 coding through the use of the hospital's electronic information systems and manual processes. REQUIREMENTS Required certification in CCS, CCS-P, CPC, or specialty coding. Two to five years experience in Hospital charge capture process review, medical record review, and claims auditing experience with hospital background and in working with regulatory and policy Three years experience in hospital working with electronic patient financial management and medical records information systems and manual processes outside of these electronic systems, with significant exposure to healthcare coding/billing/reimbursement. Strong analytical skills with attention to detail and high degree of accuracy in order to produce reports, analyses, and other detail as requested experience in reviewing medical records for medical necessity, charging and coding. A strong understanding of HIPAA laws and requirements as they relate to review and reporting of documentation. Knowledge of managed care and third-party payer benefits designs and reimbursement requirements. Proficient in Microsoft Office applications including Outlook, Word, and Excel. Apply Job Number: 00188016 Location: Waterbury, CT Organization Name: Trinity Health Of New England Facility: NESM - Saint Mary's Hospital Employment Type: Full time Shift: Day Shift Hours: 40 Job Summary Location Waterbury, CT 06720 Posted 6 Days ago Reference code 2365_42150473cecea1e7eec0254ef090a8b3",
			Company = "Trinity Health",
			City = "Waterbury",
			State = "CT",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 42000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "489a544c82d743fd9e4bd8e467a58b6b",
			Title = "Licensed Mental Health Counselor",
			Description = "A great hospital in beautiful Northeast Wyoming is now hiring for a Licensed Mental Health Counselor. The Licensed Psychiatric Counselor will work full time, day shift, with outpatient behavioral health patients, families, and in group setting.  The Mental Health Counselor will report to the Supervisor Clinical Behavioral Health and the Director Behavioral Health and will have prior Mental Health Counseling experience. The Counselor Psychiatric will perform consults, educational services, and psychotherapy for both adult and adolescent patient populations.  The Mental Health Counselor will join a great community hospital in a great area of Northeastern Wyoming. This town has been rated as one of the top cities to live in Wyoming. Enjoy year round beautiful four seasons, all year outdoor activities, great community, low commute times, and more.  The Counselor Mental Health will work in a tight-knit small psychiatric facility with a great Behavioral Health clinical team. The Behavioral Health Counselor will have their Master?s degree and will be licensed as a mental health professional.  The Licensed Mental Health Counselor will work a great Monday ? Friday, 8 am ? 5 pm schedule and will work with a multidisciplinary treatment team. This Northwest Wyoming hospital will offer their Licensed Psychiatric Counselor a competitive salary and full suites of benefits!   ",
			Company = "Clinical Management Consultants",
			City = "Wright",
			State = "WY",
			PostedDate = new DateTime(2020,1,21),
			MinimumSalary = 69000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "82d81f72072d2669116cb1bdcbbc8033",
			Title = "Pharmacy Technician - Full Time",
			Description = "SUMMARY Provide integrated support under the direct supervision of a pharmacist to HealthCare Partners clinicians and patients by managing prescription refill requests.   ESSENTIAL FUNCTIONS   Consistently exhibits behavior and communication skills that demonstrate HealthCare Partners? (HCP) commitment to superior customer service, including quality, care and concern with each and every internal and external customer.  Performs and supervise clerical and administrative duties as directed.  Process medical refill requests per protocol, facilitating non-protocol refill requests, and resolving other medication refill related issues or problems.  Documents pertinent patient information in the electronic medical record as it relates to job functions.  Constantly meet established productivity, schedule adherence, and quality standards.  Actively participates in process improvement initiatives.  Participates regularly in staff and departmental meetings  Uses, protects, and discloses HCP patients? protected health information (PHI) only in accordance with Health Insurance Portability and Accountability Act (HIPAA) standards.  Performs additional duties as assigned.    EXPERIENCE REQUIREMENTS   High School Diploma or GED  Minimum: 1-3 years of experience.  Current Nevada State Board of Pharmacy Technician license  (Pharmacy Technician Certification Board) PTCB certification  ",
			Company = "DaVita Medical Group",
			City = "Las Vegas",
			State = "NV",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 94000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "903d05ccf5b0b89682f6fb4b7520cf2b",
			Title = "DevOps Developer - AWS (API Gateway, ElastiCache, EC2, S3, SNS, SQS), AngularJS, Node.js",
			Description = "Helping build and support a fully DevOps/ChatOps pipeline and modern technology stack (MEAN) for a high traffic website CarandDriver.com.   Focus on Automation. Build tools that will help automate as much of the process as possible. DRY.   Supporting auto scaling, high-traffic web applications on Amazon Web Services.   Help educate developers on how to program to scale.   Help with stories/scenarios. Actively participate in the scrum/Agile process.   Help monitor traffic and suggest new technologies that may result in cost savings.      WHAT YOU SHOULD KNOW      How to support a site that needs to scale for high traffic volumes.   Familiarity with the Agile Scrum software development methodology.   Knowledge of TDD and continuous integration.      WHAT YOU NEED TO HAVE      Excellent communication skills, both written and verbal   Must have a good sense of urgency and feeling of ownership over what you are assigned to.   Must have a strong desire to do great things, as a team.   Must have an open mind and be willing to learn new things.   3+ years in a development / systems administrator / devops role.   Must have experience in some of the following: Amazon Web Services (API Gateway, ElastiCache, EC2, S3, SNS, SQS), AngularJS, Node.js, GitHub, CircleCi, New Relic/DataDog, Terraform, Docker, NoSQL / MongoDB, CDNs (ex: Fastly)     #RecruitPS - provided by Dice",
			Company = "Recruit Professional Services",
			City = "Atlanta",
			State = "GA",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 72000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "5a529bdd2da1bd4c246823c2affd8f96",
			Title = "President & Chief Operating Officer",
			Description = "We are looking for someone to be the right hand to our company?s Owner and Visionary. This is a key role that will be the glue that holds the people, processes, systems, priorities and strategies together. The successful candidate will have wisdom from previous executive level business experiences, be decisive and assertive, an analytical thinker, strong as a people leader and developer, and be a strategic forward-thinking problem solver. This is an incredible opportunity for someone who knows how to delegate and elevate a leadership team.?    KEY Responsibilities:    L MA:?  Leads, ? manages ?and holds the executive team? accountable ?for achieving commitments. Demonstrates a passion for value alignment, and fosters team unity.?   Financial Performance and Growth: ?Drives others to execute on the business plan while being accountable to the company?s profit and loss.?   Be a Steady Force:? Provides organizational clarity, manages big organizational projects to resolution, provides a cadence and consistency, and creates organizational lucidity.?    Minimum Qualifications:    10+ years as President or CEO and COO experience?  Exceptional competency in strategic planning and business development?  Advanced knowledge of data analysis and performance/operation metrics?  Demonstrated organizational and leadership abilities?  BS/BA in Business Administration or relevant field; MSc/MBA is a plus?  ",
			Company = "DCA Outdoor",
			City = "Kansas City",
			State = "MO",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 32000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "aff5e2e03684bd4f6a88c8a204878de1",
			Title = "School Psychologist",
			Description = "The Stepping Stones Group is currently interviewing School Psychologists for the 19/20 SY in Oakley, CA!      Job Requirements      CA PPS Credential   Full Time - Start ASAP     As a company with a strong value system and a social conscience, we invest in your future through mentoring, clinical support, continuing education, professional development, wellness benefits and a variety of resources that will empower you as a clinician throughout your career.    As part of the Stepping Stones Group team you can receive:      Competitive compensation and a comprehensive benefits package that includes student loan repayment options, travel options, professional development stipend, license and CEU reimbursement, health benefits, 401k wellness stipend and much more!    Unparalleled national clinical support by some of the nation's foremost experts in school-based-services    Pathways to Success which includes (Foundations Mentoring Program & Bloom)    $1000 Referral bonus for every full-time, school-based friend you refer, that we hire    Robust corporate Giving-Back-Program - Stepping Up for a Cause!    Access to Bridge Academy with CEU courses offered at no cost to you - All year long!      We believe in putting the needs of children first. We achieve that by making sure we put you in positions that are just right for you, and we know what it takes to thrive in your career, so call us today!",
			Company = "My Therapy Company/Cumberland Therapy",
			City = "Oakley",
			State = "CA",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 60000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "8005415980f519a9b88c11402acba831",
			Title = "Technician (PRN) - South AR Ortho and Sports Medicine PT - El Dorado, AT",
			Description = "South AR Ortho and Sports Medicine PT is searching for a Physical Therapy Technician for our outpatient clinic in El Dorado, AR. The Physical Therapy Technician is responsible for assisting physical therapists with non-clinical tasks while caring for individuals. Physical therapy techs help move patients, keep treatment areas organized and clean, assist patients with light exercises and record progress for therapists. Responsible for all physical therapy equipment, the Physical Therapy Technician will set up and take down relevant equipment for Physical Therapist use during treatment sessions. They will also manage inventory and care for and maintain equipment. They must also maintain patient confidentiality at all times. Summary The physical therapy technician will report to a physical therapy manager. The PT Technician will assist with patient prep and carrying out various non-clinical task. The PT Technician is responsible for preparing treatment areas, cleaning treatment areas and obtainment of supplies. The PT Technician is responsible for laundering and changing linens The PT Technician may also be assigned routine clerical support tasks in support of the patient care process. The PT Technician also performs other duties assigned by the physical therapist. Requirements include: Participation in high school vocational program or high school diploma or equivalent. Obtaining CPR and certifications. Proficiency in the use of office equipment and computer programs, such as Microsoft Word and Excel. Experience outpatient orthopedics and/or sports medicine preferred but not required. We offer a comprehensive health benefits package, 401K, PTO, Short and Long Term Disability, Life Insurance and AD&D. Upstream Rehabilitation is an Equal Opportunity Employer. Required Skills Required Experience Job Summary Location El Dorado, KS 71730-6700 Posted Today Reference code 17096-6679",
			Company = "Integrity Rehab",
			City = "El Dorado",
			State = "KS",
			PostedDate = new DateTime(2020,1,31),
			MinimumSalary = 37000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "e88bf4055ac8a7cbb0c3a52dc93a55ab",
			Title = "Audiologist or Hearing Instrument Specialist",
			Description = "Overview  We are a growing hearing healthcare practice of twenty five years in Bremerton, WA and currently seek an Audiologist or HIS ?who is driven, self-motivated, and passionate about helping patients hear well again. The ideal candidate must be strong clinically and have the ability to effectively counsel while building patient rapport.? ?This person would also need to travel to branch location in Gig Harbor.  ?  ?    Daily tasks and responsibilities      Establish rapport with, and gather history from, patients; conduct audiometric testing; counsel patients; and make recommendations for hearing aids.   Make ear impressions, ear molds, and order instruments.   Program hearing aids using a computer.    Fit hearing aids and assist with any adjustments, questions or problems.    Maintain documentation and patient files.    ?  ?    Qualifications      Masters Degree in Audiology but Au.D. is preferred.   Active and current hearing aid dispensing license.   ?   The successful Audiologist will also possess the following:     Strong interpersonal and organizational skills    The ability to work in a team environment    The ability to interact professionally at all times with patients, physicians, and team members.    ?  We offer an attractive compensation package and a lucrative commission/bonus ?program, plus a benefits package including health insurance and 401K",
			Company = "American Hearing Aids Associates",
			City = "Bremerton",
			State = "WA",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 57000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "ecc1b8ce14efdc8fd2c4b38c76daf54c",
			Title = "School Psychologist",
			Description = "The Stepping Stones Group is currently interviewing School Psychologists for the 19/20 SY in Bel Air, MD!      Job Requirements      MD School Psychologist Certificate   Full Time - Start ASAP     As a company with a strong value system and a social conscience, we invest in your future through mentoring, clinical support, continuing education, professional development, wellness benefits and a variety of resources that will empower you as a clinician throughout your career.    As part of the Stepping Stones Group team you can receive:      Competitive compensation and a comprehensive benefits package that includes student loan repayment options, travel options, professional development stipend, license and CEU reimbursement, health benefits, 401k wellness stipend and much more!    Unparalleled national clinical support by some of the nation's foremost experts in school-based-services    Pathways to Success which includes (Foundations Mentoring Program & Bloom)    $1000 Referral bonus for every full-time, school-based friend you refer, that we hire    Robust corporate Giving-Back-Program - Stepping Up for a Cause!    Access to Bridge Academy with CEU courses offered at no cost to you - All year long!      We believe in putting the needs of children first. We achieve that by making sure we put you in positions that are just right for you, and we know what it takes to thrive in your career, so call us today!",
			Company = "Cumberland Therapy",
			City = "Bel Air",
			State = "MD",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 75000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "065b15ea26013fd46ca00288e37be676",
			Title = "Anticipated School Psychologist - 2020-2021 School Year",
			Description = "School Psychologist   ?  Provide psychological services to students grades K-12. Responsible for assessment, eligibility and placement of identified students. Participate in eligibility, child study, discipline and IEP meetings.  ?  School psychologists are uniquely qualified members of school teams that support students' ability to learn and teachers' ability to teach. They apply expertise in mental health, learning, and behavior, to help children and youth succeed academically, socially, behaviorally, and emotionally. School psychologists partner with families, teachers, school administrators, and other professionals to create safe, healthy, and supportive learning environments that strengthen connections between home, school, and the community.  ?   Responsible for but not limited to the following:    Data collection and analysis  Assessment  Progress monitoring  School-wide practices to promote learning  Resilience and risk factors  Consultation and collaboration  Academic/learning interventions  Mental health interventions  Behavioral interventions  Instructional support  Prevention and intervention services  Special education services  Crisis preparedness, response, and recovery  Family-school-community collaboration  Diversity in development and learning  Research and program evaluation  Professional ethics, school law, and systems   ?  Note Scale shown is 2019-2020 scale ",
			Company = "Greene County Public Schools",
			City = "Greene County School Board Office Stanardsville",
			State = "VA",
			PostedDate = new DateTime(2020,1,14),
			MinimumSalary = 87000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "6c8ba5ac6fcb93884f3ce7a699f6b25a",
			Title = "Junior SEO Specialist",
			Description = "Job Summary Our client is looking for a Junior SEO Specialist to join their dynamic New Providence, NJ, team! This is an entry level role that will allow you to learn SEO best practices and become familiar with effective communications with lawyer clients. This role's primary responsibility will be to support the SEO team in optimization for law firm clients, for clients' online performance and customer retention.  1. SEO experience or interest or passion 2. Experience with Search Console 3. Experience with Google Analytics 4. Excellent communication, organized, a quick learner, proactive, patient and willing to work with challenging clients.  Candidates must provide a domain to showcase their SEO hands-on experience. Candidates coming from agency setting with large client load - good client facing skills - patience and how to work as a team and be pro-active is a huge plus!       The company is an equal opportunity employer and will consider all applications without regards to race, sex, age, color, religion, national origin, veteran status, disability, sexual orientation, gender identity, genetic information or any characteristic protected by law.    If you would like to request a reasonable accommodation, such as the modification or adjustment of the job application process or interviewing process due to a disability, please call 888 472-3411 or email accommodation@teksystems .com for other accommodation options.",
			Company = "Tek Systems",
			City = "New Providence",
			State = "NJ",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 65000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "8df11bba862df5705cae95e2683750fa",
			Title = "Computer User Support Specialists, Senior",
			Description = "Citizenship:  Must be a U.S. Citizen   Required Clearance:  SECRET   Required Education:  Senior - MA/MS degree. Allowable Substitutions: Bachelors Degree plus two (2) years additional work experience performing duties described in the functional description of the labor category may be substituted for a Masters Degree OR Associates Degree plus four (4) years additional work experience performing duties described in the functional description of the labor category may be substituted for a Masters Degree OR Six (6) years additional work experience performing duties described in the functional description of the labor category may be substituted for a Masters Degree.   Required Experience:  Senior - over 10 years of combined experience performing duties described in the functional description with at least 5 of those years demonstrating experience providing technical assistance to computer users.   Desired Experience:  At least 5 years of experience using NMCI, SharePoint and Share Drives; and certified as a SharePoint Site Collection Administrator.   Functional Description:  Provide technical assistance to computer users. Answer questions or resolve computer problems for clients in person, or via telephone or electronically. May provide assistance concerning the use of computer hardware and software, including printing, installation, word-processing, electronic mail, and operating systems.   ",
			Company = "Tekla Research",
			City = "Lexington Park",
			State = "MD",
			PostedDate = new DateTime(2020,1,9),
			MinimumSalary = 30000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "9896fe3640b35426d5e8d73d751d14c2",
			Title = "Tax Accountant",
			Description = "We have Job Opportunity for Tax Accountant at Des Moines IA with direct client. Please go through Detailed Job description below.  Duration: 4-6 months. Contract only   Here is a brief Job description:  Please note specific requirements as follows: Bachelor's degree in accounting. Four or more years of related work experience, two of which are in income tax accounting with a certified public accountant designation or a graduate business degree. If no CPA designation or graduate business degree, six or more years of related work experience, two of which are in income tax accounting is required for the tax accountant level. Six or more years of related work experience, four of which are in income tax accounting with a certified public accountant designation or a graduate business degree. If no CPA designation or graduate business degree, eight or more years of related work experience, four of which are in income tax accounting is required for the senior tax accountant level. Strong knowledge of tax law and procedures, tax research skills, familiarity with various tax returns and schedules. Strong accounting and financial statement knowledge. Strong computer software skills. Effective oral and written communication skills.    If you have the above qualification and interested to apply please reply with your updated resume, contact no. and expected pay rate and I will contact you to discuss further.",
			Company = "APN Software Services Inc.",
			City = "Des Moines",
			State = "IA",
			PostedDate = new DateTime(2020,1,21),
			MinimumSalary = 52000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "46abf15dad787388c5d88b3c61de5fb4",
			Title = "Software QA Engineer",
			Description = "The ASD IT division of SSI Schaefer specifies, designs, and implements software solutions for automated material handling and equipment in warehouses and distribution centers. The Software QA team ensures that quality standards are met for software and software development. The QA Engineer is responsible for designing and implementing tests to ensure systems meet requirements.     Participate in creation and review of test cases    Design and/or delegate design of test cases    Assist in test environment setup    Prepare, acquire, and verify test data and test tools    Create software testing documentation    Test implementations at all stages of the project (planning to documentation)    Participate in other project activities such as integration planning    Troubleshoot system issues in 1st, 2nd or 3rd level depending on project requirements    Support IT CSS engineers and on-site Software Support Engineers    4-year degree in Computer Science or Engineering or equivalent combination of education and experience in similar work.    1 year of experience with Java or other object-oriented programming languages    1 year of experience with SQL databases (Oracle, MySQL, SQL Server)    Experience with operating and debugging of Windows and Linux preferred    External Company Name: Schaefer Systems International, Inc.   External Company URL: www.ssi-schaefer.us   Street: 10021 Westlake Drive",
			Company = "Schaefer Systems International, Inc.",
			City = "Charlotte",
			State = "NC",
			PostedDate = new DateTime(2020,1,13),
			MinimumSalary = 37000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "903952b34ad89410825c2b255a1834b2",
			Title = "UX/UI Designer",
			Description = "What you will do:          Scope, design, develop and test content, experiences and     interfaces on our custom software  Design wireframes, mockups, prototyping, process flows for new     custom software to be utilized for marketing purposes  Demonstrate a healthy balance of creative, editorial and     development skills  Sourcing input content from existing materials,     subject-matter-expert interviews, and other external resources  Managing and communicating with external partners and maintain     source repositories which align with the objectives of the marketing     strategy and technical protocols.  Coordinate content development strategy with internal and external stakeholders     Minimum Education and Experience Required:    Experience with User Interface designs, User-centric designs, User     Interface designs and User Interaction Designs  Designing wireframes, mockups, prototyping, process flows, journey     maps and style and testing guidelines  Experience working in a warehouse execution system or warehouse     management system  Sound understanding of HTML, CSS/SASS/LESS, JavaScript, Angular,     vectors, backlinking and microdata formats  Experience with quality assurance, testing, change control and     release schedules.  Experience managing and coordinating 3rd party vendors.  BA/BS in Computer Science, Digital Graphics Design, Computer     Programming or related field.",
			Company = "EDIS",
			City = "Cincinnati",
			State = "OH",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 78000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "6ab5fc85443c8ee635d892c4fd2f52ed",
			Title = "Junior Accounting Analyst",
			Description = "Job Description    SUMMARY   The primary function of this position is to research, analyze and make decisions on business transactions and contracts. Frequent independent judgments are essential. The incumbent is also required to perform all tasks in observance of Rite Aid's brand and strategy and adhere to our core values and service attributes.   ESSENTIAL DUTIES AND RESPONSIBILITIES   The associate is responsible for the functions below, in addition to other duties as assigned:   Make decisions on business transactions and contracts, based on experience and knowledge of concepts, practices and procedures and make recommendations to management  Responsible for managing relationships with key business partners  Run reports on an ad-hoc and recurring basis as and has the ability to independently analyze the results and discuss with management when necessary  Process approved business transactions in appropriate systems, when necessary obtain approvals from appropriate levels of management in accordance with accounting policies  Identify ways to enhance processing efficiency and communicate the related suggestions for improvement to management  Assist with writing and updating departmental policies and procedures when necessary     Experience / Requirements       Two (2) years' of experience in an Accounting environment required     Education       Bachelor's Degree in Arts/Sciences (BA/BS) Business, Accounting or Finance required",
			Company = "Rite Aid",
			City = "Goldsboro",
			State = "PA",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 30000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "fe8cca71a80dcd274474a140b3fc6f3c",
			Title = "Recruitment & Retention Coordinator",
			Description = "Do you have a desire to positively influence growth for our next generation?      Do you love learning and motivating others to see the opportunities ahead of them??       Does being out in the community and sharing your mission inspire you?      Are you a team player who thrives in a collaborate dynamic culture?      Do people naturally look up to you as a highly responsible and dynamic leader?      Is it easy for you to communicate and connect with children and adults-both written and verbally?      Do you thrive in a fast-paced environment where you manage many things?      Do you maintain a balance of persistence and patience that allows you to achieve your goals?    ?   If you answered ?YES? to the questions above, the NorthStar Recruitment & Retention Coordinator fulltime role may be the perfect fit for you. The Coordinator is responsible for leading student recruitment, enrollment, and retention efforts for the afterschool and athletic programs primarily for boys in the 3 rd  to 8 th  grades.    ?   The ideal candidate is the main point of contact for new families enrolling with NorthStar Foundation. Additional responsibilities entail creating/overseeing programming, planning/attending events, giving tours, and other related duties. This role requires someone who can flex their schedule seasonally as needed; with afterschool hours and weekends. Individual must maintain a valid driver?s license and provide own transportation",
			Company = "NorthStar Foundation",
			City = "Omaha",
			State = "NE",
			PostedDate = new DateTime(2020,1,2),
			MinimumSalary = 40000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "cd50abd22764cc555ff7251a1aabcbb9",
			Title = "School Psychologist",
			Description = "The Stepping Stones Group is currently interviewing School Psychologists for the remainder of the 19/20 SY in York, PA!       Job Requirements       PA Psych Certification and PA Clearances   Full Time; K-8; For Remainder of SY and Possible Extenstion for Next SY     As a company with a strong value system and a social conscience, we invest in your future through mentoring, clinical support, continuing education, professional development, wellness benefits and a variety of resources that will empower you as a clinician throughout your career.     As part of the Stepping Stones Group team you can receive:      Competitive compensation and a comprehensive benefits package  that includes student loan repayment options, travel options, professional development stipend, license and CEU reimbursement, health benefits, 401k wellness stipend and much more!    Unparalleled national clinical support  by some of the nation's foremost experts in school-based-services    Pathways to Success which includes  (Foundations Mentoring Program & Bloom)    $1000 Referral bonus for every full-time, school-based friend you refer, that we hire    Robust corporate Giving-Back-Program -   Stepping Up for a Cause!    Access to  Bridge Academy  with CEU courses offered at no cost to you - All year long!      We believe in putting the needs of children first. We achieve that by making sure we put you in positions that are just right for you, and we know what it takes to thrive in your career, so call us today! ",
			Company = "Cumberland Therapy",
			City = "York",
			State = "PA",
			PostedDate = new DateTime(2020,1,6),
			MinimumSalary = 50000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "1e3ab2dd23c5cde80a3727b386b6ee92",
			Title = "Behavioral Health Chief Financial Officer",
			Description = "An exciting opportunity for a Clinical Chief Financial Officer is now available for an experienced healthcare professional. This progressive facility is prepared to add a dynamic leader to their Leadership Team.   Located in Central Massachusetts, this 100+bed facility is prepared with the latest safety features designed to provide patients with a comfortable environment. Additionally, the hospital offers inpatient and outpatient servicesfor children, adolescents, adults and older adults.   Reporting to the Chief Executive Officer, the Hospital CFOwill be responsible for the overall financial and fiscal management aspects of company operations, which includes monitoring, analyzing and directing the administrative and fiscal functions of the organization. The Chief Financial Officer will manage accounting, budget management, purchasing, compliance auditing and financial reporting in accordance with all facility and corporate policies and procedures. This ideal candidate will come with a Behavioral Health background, is Master?s prepared and is a Certified Public Accountant.   The Clinical CFO will live in an ideal part of Central Massachusetts, just a short drive from Boston. Everything you need from fine dining, great shopping and entertaining night life can be enjoyed all year round.   This position will offer the Hospital CFO a generous compensation package including a competitive salary, PTO, and a full suite of benefits for career enhancement and development. ",
			Company = "Clinical Management Consultants",
			City = "Springfield",
			State = "MA",
			PostedDate = new DateTime(2020,1,3),
			MinimumSalary = 57000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a1e3d803ff596ebbfc488e87540e814c",
			Title = "General Manager",
			Description = "About the Role As a General Manager, you will play a critical role in leading the strategic direction of your market, managing operations and overseeing personnel while acting with urgency and purpose to achieve inspiring goals. You will lead a distributed team and partner with cross-functional stakeholders to increase growth and meet our goals. What You'll Do Directly manage and build a world-class Operations organization embodying Companys ' leadership principles Deliver a world-class patient experience in your markets that motivates patients to come back time and time again Own and manage the P&L for your market Closely manage key market metrics to drive growth by pulling appropriate levers around hiring, scheduling and scaling Partner with cross-functional stakeholders to drive growth initiatives in your market Communicate product and process needs to cross-functional stakeholders Support all safety programs and OSHA compliance to ensure a safe work environment for all associates and managers Partner in development and ensure quality control policies and standard work procedures are effectively executed by your Operations team Partner with other General Managers to share best practices What You 'll Need 7-10 years of professional services (i.e., consulting, investment banking) and operations management experience MBA preferred Analytical and data driven decision making mentality- excel is a must, SQL preferred Previous experience with or strong excitement for a startup environment Proven track record of managing high performance teams Excellent team player with strong written and verbal communication skills Comfortable working cross-functionally to make your market successful Out-of-the-box thinker who will find creative ways to hit growth targets Ability to thrive in a remote market in an autonomous way Eligibility to work in the US without Company sponsorship for a work visa or employment-based green card Job Summary Location New Orleans, LA Posted 3 Days ago Reference code 604322",
			Company = "Ready Responders",
			City = "New Orleans",
			State = "LA",
			PostedDate = new DateTime(2020,1,18),
			MinimumSalary = 49000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "86cba58ce98402dea0d993d8eab4b3a8",
			Title = "Retirement-Business-Analyst",
			Description = "Job Description Summary Are you a detailed oriented professional? Have experience working with Excel and managing projects? Join Transamerica as a Business Analyst! This is an Operations back-office position, focused on resolving escalated issues and managing projects related to Operations. In this position, you will be speaking with stakeholders and acting as a business stakeholder yourself to understand our current processes and how those processes could be improved for the benefit of our customers. You will also be working to resolve escalated issues and provide exceptional customer service Job Description Responsibilities Plan, execute, and finalize projects according to deadlines Research issues by speaking with stakeholders and reviewing existing processes Coordinate and liaise across functional teams to resolve issues impacting Transamerica's customers Manage a variety of projects by gathering requirements, delegating responsibilities and tracking team tasks Provide exceptional customer service to internal and external customers Provide status updates on various projects to key stakeholders Act as an escalation point for the team and assist in resolving complex customer issues Provide guidance and leadership to team on issue resolution and the prioritization of work Qualifications Bachelor's degree in accounting or equivalent work experience Two years of related work experience. Completion of computer coursework. Analytical and problem-solving ability. Proficiency in MS Office (Word, Excel) and multiple computer systems. Proficiency in ten-key calculator Ability to work under pressure of deadlines. Preferred Qualifications Experience working in the retirement planning industry Knowledge of P3/P-Plus, Pegasus or similar Retirement systems Experience managing projects and/or teams Intermediate or Advanced experience with Microsoft Excel Working Conditions Office environment. Job Summary Location Cedar Rapids, IA 52404 Posted 6 Days ago Reference code 2365_519fe8c9a6a66ac559d4e5870c5aab09",
			Company = "Transamerica",
			City = "Cedar Rapids",
			State = "IA",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 39000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "0099856471f5051f4a44902d4d91adab",
			Title = "Mobile Developer",
			Description = "For a financial client we need Mobile Developer . This position is based in Durham, NC. WE ARE Primarily looking for W2 Candidates and not looking for Third Party Candidates The Expertise You Have Overall 4-7 years IT experience with 2-3 years specific to the skillset listed below. Strong mobile hybrid technology knowledge or knowledge of iOS or Android native development. Experience with hybrid technology frameworks like Cordova or Phonegap, Ionic and Angular is preferred. Strong experience in Javascript. Good communication and interpersonal skills. Ability to think analytically and solve problems. Previous experience in benefits outsourcing industry/Health &amp; Insurance is preferred. Effectively work with offshore teams to delegate and take handoff on project work. The Skills You Bring Your passion building amazing hybrid and native experiences on iOS and Android platforms Hybrid mobile application development using Ionic, Cordova/Phonegap, Angular, HTML5, CSS, Typescript, JS, Java and Spring Knowledge of consuming HTTP based APIs/RESTful JSON APIs is required DevOps CI/CD, QA Automation, uDeploy, Jenkins Advanced GIT, hands on command line and shell script development experience Your desire to delight our clients with the latest mobile technologies using your knowledge of iOS design patterns including MVP and MVC Karma and Jasmine experience are a plus, but not required Familiarity with Test driven development, static code analysis and secure code scan Performs good unit testing and peer reviews before delivering code to QA Passion for writing readable, maintainable and well-tested code and supporting technical design documentation Excellence in communication and interpersonal skills Exposure to Agile development methodology is required. Candidate will participate in daily scrums, effectively communicate status during standup and brings attention to issues for resolution. - provided by Dice Job Summary Location Durham, NC 27701 Posted Today Reference code 6874_3b239e07718a763cd492c1f191403222",
			Company = "Adroit Software, Inc.",
			City = "Durham",
			State = "NC",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 34000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "69bb94af85e72b175ba97d11f6bad247",
			Title = "American Sign Language Interpreter (ASL)",
			Description = "We are offering a $1500 referral bonus for any colleagues for the state of GA, send us your referrals today!           The Stepping Stones Group is currently interviewing American Sign Language Interpreters for the 19/20 SY in Roberta, GA!      Job Requirements      SLI EIPA Score of 3.5   Full Time; Elementary Caseload     As a company with a strong value system and a social conscience, we invest in your future through mentoring, clinical support, continuing education, professional development, wellness benefits and a variety of resources that will empower you as a clinician throughout your career.    As part of the Stepping Stones Group team you can receive:      Competitive compensation and a comprehensive benefits package that includes student loan repayment options, travel options, professional development stipend, license and CEU reimbursement, health benefits, 401k wellness stipend and much more!    Unparalleled national clinical support by some of the nation's foremost experts in school-based-services    Pathways to Success which includes (Foundations Mentoring Program & Bloom)    $1000 Referral bonus for every full-time, school-based friend you refer, that we hire    Robust corporate Giving-Back-Program - Stepping Up for a Cause!    Access to Bridge Academy with CEU courses offered at no cost to you - All year long!      We believe in putting the needs of children first. We achieve that by making sure we put you in positions that are just right for you, and we know what it takes to thrive in your career, so call us today! ",
			Company = "Cumberland Therapy",
			City = "Roberta",
			State = "GA",
			PostedDate = new DateTime(2020,1,10),
			MinimumSalary = 83000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Communications"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "884063ca02daa5ce35fda7e876343b33",
			Title = "Content Production Fellow",
			Description = "We are hiring a production fellow to join the growing Insider Picks product reviews team. The fellowship entails working behind the scenes to help the editorial team with building, maintaining, and updating new and existing Insider Picks articles. This is not a writing position.      Assist the Insider Picks reporters and editors in their goal of making great product recommendations that make shopping online easy and useful for our audience.   Build articles and slideshows in the custom Insider Inc. CMS so that they?re properly formatted for publication.   Update existing Insider Picks stories with new affiliate links, prices, images, and formatting so that they are accurate and adhere to current standards.   Crop and resize product images for stories, crediting sources and adding captions where needed.   Knowledge of SEO best practices is a plus.?        In short, we?re looking for someone who thrives in a fast-paced environment, is detail-oriented, and has experience working in a CMS. This person also works well independently and has an eye for spotting and correcting errors and inconsistencies.       Our fellows are an integral part of our team. We seek out self-starters and people who are enthusiastic about collaborating with editors, producers, analysts, and other team members.    This fellowship position is at our headquarters in New York City. It will run for six months, and fellows are encouraged to work full-time (40 hours a week) if their schedule allows.",
			Company = "Insider Inc",
			City = "New York",
			State = "NY",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 88000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "58e6e47d3d955f4bfd5e6f512ec1bf48",
			Title = "Manager Clinical Resource Mgmnt / Supply Chain -NJ license in clinical field is required",
			Description = "Job Description Job Summary: Reviews opportunities and implements clinical Supply Chain initiatives including product standardization, product value analysis, and contract compliance and utilization management. Focus is Medical/Surgical, Pharmacy, Emergency Departments, ICU's; Respiratory, Radiology, Physical Therapy, other ancillary departments and Maternal Child Health. Position Responsibilities: Work with physicians, clinicians, etc. in reviewing opportunities for clinical integration, contract compliance and utilization management as Facilitator of Product Value Analysis Committee for Virtua. Manages Product Recall Communication Process and Product Backorder Communication Process. Assist with standardization and integration of products and equipment and standards across continuum of care network, including VMG. Works with external customers, such as manufacturers, suppliers, other Integrated Delivery Health Networks to identify clinical standardization opportunities. Continually strive to achieve high product and equipment standardization and committed volume. Assists with pre qualification of products in conjunction with Clinical services and physicians. Position Qualifications Required : Required Experience: 5 years healthcare experience; minimum one year management or supervisory experience preferred. Required Education: Bachelor's degree in clinical field; Master's degree preferred Training / Certification / Licensure: Current NJ license in appropriate clinical field is required",
			Company = "Virtua",
			City = "Marlton",
			State = "NJ",
			PostedDate = new DateTime(2020,1,15),
			MinimumSalary = 80000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "99ad72cbd77c24c10d6f5abd9157db50",
			Title = "POLICY ANALYST, HEALTH",
			Description = "The American Academy of Actuaries (Academy) is seeking a public policy analyst to oversee a portfolio of issues related to health insurance at the federal, state, and international levels. The Health Policy Analyst will:   ?     Act as the lead staff representative interacting with public policymakers on issues of key concern to the Academy in the area of private health insurance, Medicare, Medicaid and other public and private health programs/systems.   Build relationships with policymakers and regulators to expand the Academy's role in health insurance policy issues.   Develop and maintain relationships with key stakeholders, congressional and administration offices, relevant congressional committees of jurisdiction, and the National Association of Insurance Commissioners (NAIC).   Monitor and facilitate Academy interactions with agencies such as the Center for Medicare and Medicaid Services (CMS), Center for Consumer Information and Oversight (CCIIO), Congressional Budget Office, and Government Accountability Office.   Proactively identify initiatives to increase the effectiveness of the Academy's health insurance public policy efforts.   Working with Academy volunteers and staff, assist in the development of Health Practice Council statements, comment letters, issue briefs, and other public policy content.   Develop webinars and briefings for internal as well as external audiences on relevant Academy health policy work.   PandoLogic. Category:Healthcare, Keywords:Healthcare Policy Analyst, Location:Washington, DC-20036",
			Company = "American Academy of Actuaries",
			City = "Washington",
			State = "DC",
			PostedDate = new DateTime(2020,1,10),
			MinimumSalary = 66000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "10148673328ff3e9c455dd122d341382",
			Title = "Special Education Teacher (Moderate/Severe)",
			Description = "Make a difference in the lives of children! We are currently seeking a qualified Special Education Teacher for a position in E. Palo Alto, CA. This is a full-time position to start ASAP-June 12, 2020. 37.5 hours per week, 8-4 daily, working with a preschool caseload so needs to have the ECCE. We are an award winning, fastest growing school-specific agency that is committed to optimizing student?s outcomes. Staff Rehab?s 90% school retention rate allows for greater yearly growth. We are offering fantastic pay plus benefits for these positions and would love to discuss details with you at your convenience. Requirements for the Special Education Teacher: *A passion for working with pediatrics *State of California Moderate/Severe Credential in Special Education *Must be able to provide proof of current TB Test (within 1 year) *Requires Mandated Reporter Training Certificate Perks and Benefits for the Special Education Teacher: *Medical, Dental, Vision *401K *$750 Continuing Education Units (CEU) Reimbursement *Paid Time Off & Holiday Pay *Mentoring and dedicated support on staff *$5,000 loyalty bonus at 10 year anniversary *$750 referral bonuses Staff Rehab is privileged in representing the very best candidates and carries one of the most highly respected names in rehabilitation services. As a member of our team, we provide a benefits package (medical, dental, and vision) with outstanding coverage for those who elect to participate. Our knowledgeable staff members provide an unparalleled support system. Are you ready to make a difference? Testimonial: ?I've been working for Staff Rehab for a year and all I could say is that I love the company. Since day one they have been supportive. If you ever email or call them they will respond to you within a few hours or right away. They care about their employees. They offer GREAT benefits.? Staff Rehab is an Equal Opportunity Employer, drug free workplace, and complies with ADA regulations as applicable. Job Summary Location East Palo Alto, CA Posted Today Reference code 12933",
			Company = "Staff Rehab",
			City = "East Palo Alto",
			State = "CA",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 64000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d7ca385d6988acbbb454d68223220fc4",
			Title = "Psychiatry Chief Medical Officer (CMO) - Outpatient Clinic - Wyoming-148772",
			Description = "COMPENSATION AND BENEFITS Psychiatry Chief Medical Officer (CMO)  ? $300,000 - $335,000 Guaranteed Salary ? Sign On Bonus and Relocation ? Full Benefits including a matching retirement plan  RESPONSIBILITIES AND FACILITY DETAILS Psychiatry Chief Medical Officer (CMO)  ? 60% Admin 40% Clinical (Flexible Schedule) ? Help Build and Expand an Organization ? Monday-Friday Practice (NO WEEKENDS) ? Outpatient Only (NO CALL and NO HOSPITAL WORK) ? 1 Hour New Patient Visits and 30 Minute Med Checks  QUALIFICATIONS AND SKILLS Psychiatry Chief Medical Officer (CMO)  ? Board Certification Preferred; Board Eligibility Required ? J1 and H1B Visas Welcome to Apply ? Experience and/or Passionate about Building and Growing an Organization  COMMUNITY Psychiatry Chief Medical Officer (CMO)  ? Large City with airport and small community feel ? Entertainment Venue with A-List Performers (Luke Bryan, Flo-Rida, Post Malone, Toby Keith) ? Easy Driving Distance from Denver  REFERENCE NUMBER:148772  ABOUT DELTA PHYSICIAN PLACEMENT  Delta Physician Placement (DPP), the permanent staffing division of The Delta Companies, identifies qualified Physicians, Advanced Practitioners, Allied Health, and Therapist on behalf of healthcare facilities nationwide. A single point of contact assists you with coordinating communication with the hiring manager, negotiating contractual details, and coordinating any necessary travel. The company has been recognized with several Best of Staffing? Awards. Visit www.deltaplacement.com for more information. ",
			Company = "Delta Physician Placement",
			City = "Jackson",
			State = "WY",
			PostedDate = new DateTime(2020,1,15),
			MinimumSalary = 64000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "80f8df08a3edf0013f0c6e8f029dfabb",
			Title = "Nurse Practitioner - Hospice Part Time (20hrs)",
			Description = "Job Description Description Heartland Hospice supports the patient and family wherever they are in their health care journey, and upholds the patient's and family's wishes, goals and values. The Hospice Nurse Practitioner provides clinical practice oversight and management in accordance with state specific nurse practice law for patients in the hospice and palliative care setting. Working under a collaborative practice agreement with the hospice Medical Director and team physicians the Nurse Practitioner collaborates with the attending physician, specialists and non-physician providers as applicable for the purpose of coordination of care to effectively meet the medical, psychological and spiritual needs of the patient. This enables patients to live life as fully and comfortably as possible in an atmosphere where patients and families are able to share their thoughts, hopes and concerns. We offer: Continuing medical education, Comprehensive benefits (Medical, Dental, Vision) including company paid Malpractice, DEA and Licensure Monday-Friday positions with flexible hours-no on-call, weekends or nights. Be a part of the Heartland team making a difference. Location 4629 - Heartland Hospice - West Branch Office - Serving Northern Michigan Educational Requirements Currently licensed as RN in state; Masters Degree in Nursing and certification through a national Nurse Practitioner licensing board. Position Requirements At least one year in Hospice or Palliative care Prior Nurse Practitioner experience, preferred.  ",
			Company = "Heartland Hospice",
			City = "West Branch",
			State = "MI",
			PostedDate = new DateTime(2020,1,15),
			MinimumSalary = 45000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "86d92c54f41af1aef7c4056fd4951a80",
			Title = "Monitor Tech FT Nights Saint Francis Bartlett",
			Description = "This is a full-time (40 hours/week) position on an inpatient telemetry unit.     Candidates with previous experience as a Monitor Tech will be given priority consideration.            Performs duties related to the cardiac telemetry monitoring of patients and care and maintenance of equipment.  Observes monitors without distraction.  Possess knowledge of basic medical terminology, basic computer skills, basic telephone skills, English, BLS and high school diploma.      Summary  Responsible for the set up of telemetry on physician orders by ensuring proper placement of electrodes, running strips, and replacing batteries as needed.   Responsibilities   Performs general clerical duties by preparing, compiling and maintaining records in a hospital nursing unit.  Maintains current and orderly chart files.  Answers telephone.  Records and relays messages.  Prepares routine, confidential, and/or special reports, documents, and records.  Assist with quality improvement activities.      Qualifications:    Education   Required:  High school diploma or equivalent  Experience   Required: Previous experience as a monitor tech in an acute care setting is strongly preferred.  Successful completion of EKG class.  Familiar with Medical Terminology.       Licensure/Certification:      BLS.  Completion of EKG course within 60 days of employment.      Job:     Laboratory and Clinical Technicians      Primary Location:     Bartlett, Tennessee",
			Company = "Saint Francis Hospital - Bartlett",
			City = "Bartlett",
			State = "TN",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 95000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "5682e507b7ec7b24d13941ebce786987",
			Title = "MRI Technologist",
			Description = "Operates imaging equipment to produce images of the body for diagnostic purposes, as directed by the Radiologist, Clinical Coordinator or Lead Imaging Technologist in area worked most.   Education & Experience:    One of the following is required:    a) Associate's Degree or equivalent from a two year college or technical school     b) Six (6) months to one (1) year related experience and/or training     c) Equivalent combination of education and experience required.     Must be a radiographer with at least one year of additional training in MRI.     Knowledge of anatomical positioning and human physiology (as appropriate to modality) required.     Knowledge of radiation protection as warranted.     Licensure & Certification:     Current CPR certification required.     Current licensure as a Radiographer in the state of Maryland required.     National Board certification in Radiology required.     National Board Advanced MRI Certification is preferred.     One year of experience in a modality that does not required advanced certification by regulation may be substituted for the advanced certification.     The additional modality must be practiced at UM Charles Regional Medical Center by the technologist.    UM Charles Regional is an equal opportunity/affirmative action employer. All qualified applicants will receive consideration for employment without regard to sex, gender identity, sexual orientation, race, color, religion, national origin, disability, protected veteran status, age, or any other characteristic protected by law.  ",
			Company = "UM Charles Regional Medical Center",
			City = "La Plata",
			State = "MD",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 33000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "62c3c7dded8b7f5e282d779046bc6aed",
			Title = "Accounting Intern - Deltek Vision + Coding",
			Description = "Education: Current enrollment in a Bachelor or Master of Science degree program at an accredited university is required.    GPA: 3.0 or above  Generally responsible for assisting the Finance and Accounting Team with routine assignments. Support for Deltek Vision and software coding also is involved with this opportunity. Work will be performed under direct supervision.   Primary responsibilities will include but are not limited to:    Familiarity with and utilization of department standards.    Scanning and filing paper and electronic documents.     Data entry of budgets and other information.    Organizing Certificates of Insurance and contracts.    Scheduling meetings.    Assisting with special projects.     Knowledge and application of company standards.    Knowledge of office administration procedures.    Extreme attention to detail.    Ability to work in a fast paced environment, and extreme multi-tasking.     Ability to analyze data, make judgments and develop reports.     Ability to maintain effective working relationships with teammates, clients, and vendors.    Ability to be discreet in dealing with sensitive situations and maintain confidentiality in all areas.     Excellent organizational skills.    Excellent communication skills, both verbal and written.    Ability to listen and ascertain the needs of teammates.    Working knowledge of Microsoft Word, Excel, Powerpoint, Outlook, Adobe Acrobat and other software as needed.     ID: 2020-2638   External Company Name: Hargrove Engineers + Constructors   Street: 20 South Royal Street  ",
			Company = "Hargrove and Associates, Inc.",
			City = "Mobile",
			State = "AL",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 94000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "0047ca2a5a592c10818ad1fcde50d454",
			Title = "Cardiovascular Radiology Tech - FT - Days",
			Description = "This Cardiovascular Radiology Tech position is full-time - day-shift position . Great opportunity to work with a cohesive team in a friendly Cath Lab department.    Up to $5,000.00 sign on bonus for qualified, experienced Cardiovascular Radiology Techs.    Summary:    Performs complex, invasive cardiac, interventional radiology, vascular and EP procedures in the role of scrub tech, recording/monitoring tech, and circulator tech.  Is a part of a specialized health care team collaborating to provide invasive diagnostic and therapeutic invasive procedures.  Northwest Medical Center is a 300-bed hospital offering a full range of healthcare services including emergency services, accredited chest pain and heart failure programs, neurology and neurosurgery, outpatient imaging, a nationally accredited surgical weight loss program, total joint program, spine program and stroke center (recognized with Gold Seal designations by The Joint Commission), robotic surgery, GI lab, a free-standing women's center, inpatient rehabilitation facility, wound care center, five urgent care facilities, and three ambulatory surgery centers. NMC also has several affiliated physician practices including Northwest Allied Physicians offering primary care and a wide range of specialists, Desert Cardiology of Tucson, Heart Center of Southern Arizona and Northwest Heart & Vascular.  NMC is accredited by The Joint Commission and is an equal opportunity employer:  race, gender, disability and Veteran status, and VEVRAA Federal Contractor - priority referral Protected Veterans requested.  ",
			Company = "Northwest Medical Center Tucson",
			City = "Tucson",
			State = "AZ",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 92000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "68e66015ff4ede326a93f630f38b2001",
			Title = "Radiology Tech Mary Bridge - per diem",
			Description = "Radiology Tech Mary Bridge - per diem    Job Number:  72074    Location:    Tacoma, WA      Job Category:  Imaging / Radiology   Employment Type:  On-Call/Per-Diem   MultiCare Entity:  Mary Bridge Children's Hospital   FTE:  0.001   Specialty:  Pediatrics   Department:  Radiology MBCHC MBH   Shift:  Variable   Work Schedule:  as needed, as you are available  The reasons to work at MultiCare are as unique as the people who do. Join us for the professional challenges you seek. In the settings you prefer. With schedules that fit your life. Learn more at www.multicarejobs.org   Position Summary:  This pediatric Radiologic Technologist is responsible for performing radiologic procedures. Work situations are a variety of technical procedures that require independent judgment, initiative, and ingenuity in order to apply prescribed ionizing radiation for radiologic diagnosis. External contacts include patients, family members, and physicians. Internal contacts include nursing service staff and management.    Minimum Requirements:  Previous Radiology Tech experience preferred.   Education/Licenses/Certifications:  Graduate or eligible for graduation with an AA degree from accredited Imaging program or equivalent Certified with the State of Washington Department of Health Registered with the American Registry of Radiologic Technologists required. If registry is pending, must complete within 6 months from date of hire into this job classification.   With opportunities at Tacoma Mary Bridge location, as well as in Federal Way, Olympia and Gig Harbor Mary Bridge locations. ",
			Company = "Radiology MBCHC MBH",
			City = "Tacoma",
			State = "WA",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 90000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "e9458296b524a0aea4468f2c0c70829e",
			Title = "CFO",
			Description = "Chief Financial Officer Early Stage Health Food Company Los Angeles, CA Salary + Bonus + Equity Potential We are in search of a Chief Financial Officer with strong financial experience in the CPG arena who enjoys the journey of growing a small business into a billion+ dollar enterprise. Specific responsibilities will include financial reporting, budgeting & forecasting, month-end close, variance analysis and financial systems oversight. The role will work closely with an outsourced finance consultant to assist with the plan to migrate the finance function in-house in 2020. The position will manage, train and mentor a Controller and be responsible for building a finance team over time. Successful candidates will have approximately 10-15 years of related experience, strong analytical skills and the desire to collaborate with a small, entrepreneurial team. Food/CPG experience is a must and start-up experience is a plus. Prior fundraising experience strongly preferred. Salary is up to $250,000, based on experience. There is an opportunity to earn equity and a performance bonus as well. Responsibilities: Prepare financial statements, weekly reports, financial dashboards and margin analysis Develop and manage financial and pricing models Growth, cost projections and profitability reports Collaborate on long-term growth plans Review broker commission calculations Partner with outsourced finance consultant on finance function Plan for migrating the finance function in-house for 2020 Review monthly accounting transactions for accuracy Research for ERP system conversions Build a finance team as needed and train/develop department staff HR functions including on-boarding, expense reporting and creating a handbook Qualifications: Bachelor's Degree required, CPA/MBA/CFA preferred. 10-15+ years relevant CPG or food experience Start-up experience a plus Quickbooks and ERP experience Creative thinker with the ability to work in an entrepreneurial, dynamic environment Equal opportunity employer. Job Summary Location Angels, CA Posted 3 Days ago Reference code 2365_71de575042a4184731eba63246237f13",
			Company = "BridgePoint Associates",
			City = "Angels",
			State = "CA",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 56000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "f7243d437a94115d5410a9f244833c29",
			Title = "Vice President Marketing",
			Description = "Overview The VP of Marketing has responsibility for worldwide marketing for the Circulation Business, which currently includes ZOLL?s Temperature Management Business and ZOLL?s TherOx business. ? Report to the President. Overall leadership of Circulation Business Marketing Direct and indirect reports include approximately 10 people globally Drive revenue growth and market share by creating customer preference for the Company?s brand. Set tone and agenda for commercial sales activities globally Design compensation structures that rewards team for achieving sales growth goals Cultivate relationships with key clinical opinion leaders, customers (internal and external) and industry peers Thought leader/contributor for new product designs, basic research, clinical and regulatory strategy, new business development Responsibilities An outstanding track record of driving business growth and developing marketing strategies to support innovative products Has managed groups of at least 10-20 people, and revenue of $100M Experience in medical device capital equipment, with a strong preference for candidates with experience in the cardiac catheterization lab. Experience in digital marketing best practices is desirable. Natural, intuitive grasp of marketing fundamentals International re-imbursement experience is desirable Strategic thinker Flexibility to handle full marketing continuum from top-level strategy to hands-on demand creation and messaging Low-ego team player Active listener, ability to learn through probing Q&A Passion and enthusiasm to develop deep understanding of customer needs Qualifications Succeeds through influence and persuasion rather than control Strong oral and outstanding written communication skills High intelligence Minimum of a bachelor?s degree. An MBA is preferred, but not required.? Ten or more years of marketing experience, including at least five years at the Senior Director or VP level. Ability to travel up to 40% of the time ? EQUAL OPPORTUNITY EMPLOYER - DISABILITY AND VETERANS ? #Li-BJ1 ? ? Job Summary Location San Jose, CA Posted 21 Days ago Reference code 1237",
			Company = "Zoll Circulation Inc.",
			City = "San Jose",
			State = "CA",
			PostedDate = new DateTime(2020,1,10),
			MinimumSalary = 42000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "515712a2592d1616a22dc7236527717a",
			Title = "School Psychologist",
			Description = "The Stepping Stones Group is currently interviewing School Psychologists for the remainder of the 19/20 SY in Blackwood, NJ! Travel packages available for out of state candidates.            Job Requirements       NJ School Psych License (Active or Eligible), NJ DOE Cert and NASP Certification   Full Time; Experience Working with Child Study Team Required     As a company with a strong value system and a social conscience, we invest in your future through mentoring, clinical support, continuing education, professional development, wellness benefits and a variety of resources that will empower you as a clinician throughout your career.     As part of the Stepping Stones Group team you can receive:      Competitive compensation and a comprehensive benefits package  that includes student loan repayment options, travel options, professional development stipend, license and CEU reimbursement, health benefits, 401k wellness stipend and much more!    Unparalleled national clinical support  by some of the nation's foremost experts in school based services    Pathways to Success which includes  (Foundations Mentoring Program & Bloom)    $1000 Referral bonus for every full time, school based friend you refer, that we hire    Robust corporate Giving - Back - Program -   Stepping Up for a Cause!    Access to  Bridge Academy  with CEU courses offered for our  School Psychologists at no cost to you - All year long!     We believe in putting the needs of children first. We achieve that by making sure we put you in positions that are just right for you, and we know what it takes to thrive in your career, so call us today! ",
			Company = "Cumberland Therapy",
			City = "Blackwood",
			State = "NJ",
			PostedDate = new DateTime(2020,1,17),
			MinimumSalary = 39000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "cf72334779fc8c6c0adbbd9c7a9179be",
			Title = "Adjunct - Librarian",
			Description = "Cabrillo?College is accepting applications for temporary, part-time faculty assignments that may become available in?Fall 2020: Library 10 Information Research In addition,?Cabrillo?College is accepting applications in order to establish an eligibility pool for temporary, part-time faculty assignment(s) for other Librarian instructors that may become available in Fall 2020. This adjunct position is open through the deadline date as noted above OR until the position has been filled. The?ideal?candidate will share?Cabrillo's?commitment to educating its racially and socioeconomically?diverse student population.?Cabrillo?College serves approximately 11,500+ students per term, including?LatinX?(46.82%), Multi-Ethnic (5.14%), Asian (2.53%), African-American (1.08%), Filipino (0.79%), American Indian or Alaskan Native (0.30%), and Pacific Islander (0.16%) as of Fall 2019. At?Cabrillo, 56.66% of students are students of color and 54.91% are economically disadvantaged. In 2006,?Cabrillo?College was designated a Hispanic-Serving Institution, reflecting the great responsibility that the College has to the educational attainment and economic well-being of the surrounding community. About the College: Situated on Monterey Bay in the county of Santa Cruz, California, Cabrillo?College is highly regarded for its success of transfer and career education, and currently serves over 11,400 students each semester.?Cabrillo?College transfers many of its students to three nearby universities ? the University of California at Santa Cruz (UCSC), San Jose State University (SJSU), and California State University at Monterey Bay (CSUMB).? Cabrillo's?career education is closely connected to the nearby agricultural and farming industries and well as the Silicon Valley business environment. Faculty at?Cabrillo?College actively participate in curriculum development, program planning, and serve on participatory governance committees.?Cabrillo?provides an excellent opportunity to learn, collaborate, create, and make a difference in the lives of its diverse student body and community. Job Summary Location Aptos, CA Posted 3 Days ago Reference code 2676495",
			Company = "Cabrillo College",
			City = "Aptos",
			State = "CA",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 70000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Library"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "0a5a2bbd47d88ab6e098854874b5e8f4",
			Title = "Operations Manager",
			Description = "Why a Great Opportunity  Fortune 500 company.? Awesome relocation package and strong salary!? Opportunity for advancement into Plant Manager.?   Job Description  Our client is a fortune 500 industry leader in the packaging industry and is seeking to hire highly qualified and successful operations professionals to manage facilities throughout North America.? This Operations Manager is responsible for the safety, employee engagement, productivity, quality and customer service associated with a multi-shift, 24/7 operation in East Central Illinois.? Reporting to the Plant Manager, the Operations Manager will have seven direct reports with over 550 hourly employees.  ?   Essential Duties and Responsibilities:    Ensure production aligns with the requirements of sales, quality and customer service.  Understand product requirements then establish manufacturing standards, methods, policies and procedures and manpower levels to meet those requirements.  Organize the plant?s operations function to achieve business results, assigning responsibilities as necessary.  Utilize data to understand trends and make changes prior to issues.  Engage with the workforce and coach and develop managers.  Be responsible for making sure his/her team is focused on key performance indicators (Safety, Quality and Productivity).   ?   Qualifications   Qualifications:    B.S. Degree - Master?s degree strongly preferred.  15-20 years of experience in a manufacturing environment with at least 5 years in a senior leadership position.  Six Sigma Certified.  The person placed in this role must be willing to relocate.? This is considered a development role for a plant manager position.",
			Company = "NPAworldwide Recruitment Network",
			City = "Mattoon",
			State = "IL",
			PostedDate = new DateTime(2020,1,5),
			MinimumSalary = 43000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "b349384996129063a293336cb49891c7",
			Title = "PROGRAM COORDINATOR / 40 HOURS / DAY SHIFT - BWH INTERPRETER SERVICES",
			Description = "Under the general direction of the Director of Interpreter Services and with oversight from the Operations Manager, the Interpreter Coordinator will assist in coordinating the needs of non-English speaking and hearing impaired patients, their families, and take a proactive role in the efficient operation of the department. This role will also be responsible for following up on urgent matters assigned by the Director or Operations Manager. The Interpreter Coordinator will work cohesively as a member of the Interpreter Services Team, and will take a supporting role in ensuring the smooth and efficient operation of the department. The Interpreter Coordinator will also be responsible for the coordination and monitoring of schedules and language requests, will assist the Operations Manager with payroll, p atient related needs, statistical reports and other systems to support the department.          Qualifications     1. Associate's Degree preferred. High School Diploma or equivalent required.    2. 1-2 years of experience in medical, customer service setting preferred, but not required.    3. Knowledge of Medical Terminology    4. Computer knowledge in windows-based environment strongly preferred.    5. Demonstrated customer service skills   6. Fluent in English and Spanish (Written and Verbal)   7. Medical Interpreter Certificate preferred      .         EEO Statement     Brigham and Women's Hospital is an Equal Opportunity Employer. All qualified applicants will receive consideration for employment without regard to race, sex, color, religion, national origin, sexual orientation, protected veteran status, or on the basis of disability. ",
			Company = "Brigham & Women's Hospital(BWH)",
			City = "Boston",
			State = "MA",
			PostedDate = new DateTime(2020,1,17),
			MinimumSalary = 55000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Communications"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d747a580963fd54dc7d40d1281d893f2",
			Title = "Business Analyst with Tableau experience",
			Description = "Why a Great Opportunity Salary in the $85-95,000 range Comprehensive Benefit and Retirement Programs Full Time / Direct Hire Location: North Metro Boston The client is?a large billion-dollar firm. Job Description Our client has a need for a Business Analyst who will be the essential link between technology and the financial management team. This position will concentrate on gathering/validating business requirements and take part in the delivery of reporting solutions. You will be involved with documenting financial data flows, reporting processes, and business intelligence infrastructure in conjunction with the finance department. ? Examples of Key Duties in this Position: Assist in developing the documentation and procedures required to identify current business objectives to meet organizational needs. Create project reports, documentation, and deliverables Document systems through object models, data definitions, and naming conventions Acts as a liaison between finance and business groups during analysis, requirements definition and design activities for financial reporting solutions and/or integration projects. Acts as a liaison between the Tableau users in Finance and the IT team. Participate in business requirements gathering sessions with the client, and assist in creating Activity Diagrams and Functional specifications Profiles the data/information gathered from multiple sources and creates source documents ? Qualifications 4+ years of experience as a Business Analyst in creating Activity Diagrams and Functional specifications Must have experience in Tableau and Tableau Prep. Strong experience gathering and analyzing data from a variety of data sources. Must have experience in financial modeling. Must have experience in process flow documentation. Solid experience in writing SQL queries, and utilizing Excel. Experience with business intelligence Ability to explain information regarding tableau in a simple way to non-technical audiences. Excellent written and verbal communication skills. Great analytical, critical thinking and problem-solving abilities. Job Summary Location Wilmington, MA Posted 3 Days ago Reference code 29537",
			Company = "NPAworldwide Recruitment Network",
			City = "Wilmington",
			State = "MA",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 60000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "030edddc6b175ff2ab7fa45d5535c9ee",
			Title = "Cath Lab Technologist - Cardiovascular Tech",
			Description = "Job Description Cath Lab Technologist - 12 wk contract,requires 2 yrs exp We offer the highest quality benefits in the healthcare staffing industry. Here are a few: ? Higher pay than the industry average ? Medical, Dental and Vision coverage beginning Day 1 of your contract for you and your family ? Short Term Disability ? Life and Pet insurance DISRUPTING THE TYPICAL AGENCY MODEL Managed by Nurses we think a little differently from the normal staffing structure out there. Our team members are Career Counselors, Mentors, and Friends that truly have your best interest in mind. The days of the middle man are over. We have direct relationships with most of our partners and run numerous Managed Service Provider fulfillment centers across the Country. Work with knowledgeable agents that truly examine what is important to you in your Career Path. Money? Location? Benefits? All of the above? Throwing you to as many open positions as possible is a thing of the past, finding you the perfect fit is our goal and purpose. After all, if you aren't happy, we have failed. Our efforts to provide growth opportunities both for our clinician and internal employees allowed Accountable to be singled out and recognized as an outstanding employer in the healthcare industry. This recognition is a testament to the level of commitment each member displays. From awards that recognize performance to parties that celebrate teamwork, birthdays and anniversaries, to a focus on giving back through charitable deeds and donations, Accountable thrives thanks to a culture focused on teamwork, talent, and trust. Finally an agency that Cares for the Caregiver",
			Company = "Accountable Healthcare Staffing",
			City = "Shreveport",
			State = "LA",
			PostedDate = new DateTime(2020,1,15),
			MinimumSalary = 30000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "76aaebe3de4607de8642bfee5e3461e1",
			Title = "Eyewear Dispenser/ Optician",
			Description = "Pearle Vision of Brandonis seeking part time Eyewear Dispenserand licensed optician.We are searching for dynamic individuals who work well in a fast paced environment and are excellent multitaskers. Prospective candidates must have at least 1 year of optical experience, a go with the flow attitude and isan upbeatteam player. Keeping our customers happy is our number one priority. World class customer service is the name of our game We areoffering extremely competitive compensation and schedule flexibilityfor the right candidate   Our team istalented, experienced and growth oriented. We are looking for like minded, emotionally intelligent people to grow with us.    MAJOR DUTIES & RESPONSIBILITIES:    Sell, fit and dispense prescription eyewear.  * Answer telephone and direct calls or take messages  * Check voice mail and email messages  * Monitor text messages and in store messagingconsistently for messages/tasks  * Schedule appointments  * Confirm appointments via text.  * Enthusiastically greet incoming patients.  * Verify vision benefits and bill claims for eyewear.  * Adjust and repair eyeglasses.  * Work closely with optomtertists to keep patient flow moving efficiently.  * Scan documents into point of sale system.  * Any other tasks requested by supervisors.       KNOWLEDGE & SKILLS:  EDUCATION:  High school diploma or equivalent, or comparable experience typically achieved with a minimum of 1-2 years in an opticalenvironment.  A successful candidate must meet the position requirements above in order to perform the essential functions of this position and achieve the outcomes/results indicated in this position description",
			Company = "Pearle Vision",
			City = "Brandon",
			State = "FL",
			PostedDate = new DateTime(2020,1,21),
			MinimumSalary = 37000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "917ecb4c40be05040479067c93794fe8",
			Title = "Experienced Trader, High Frequency Trading - G",
			Description = "Experienced Trader, High Frequency Trading   Rapidly growing proprietary trading firm with offices in Chicago,   London, and New York City is seeking experienced high volume Traders.    The Trader will be charged with developing new strategies utilizing   proprietary software and customizing current strategies.  Unlike a lot   of other firms, traders work closely with dedicated technology team in   developing and enhancing existing strategies.  This position will be   located in the Chicago office.   Candidates must have HFT (High     Frequency Trading) experience.    Qualifications:   -Must have 5+ years of High Frequency Trading (HFT) experience.  -5+ years working experience of high volume trading.  -Has demonstrated the ability to use sound judgment while trading.  -Proven ability to develop new, profitable trading strategies.  -Preference to those with the ability to do light programming work   using multi-dimensional arrays, nested loops, complex conditionals and   simple file I/O.  -Preference to those who are fluent in Excel Programming with   experience in VBA Programming and C++ Programming.  -Strong mathematical aptitude.  -Values teamwork and is capable of thinking independently.  -Can communicate effectively while under pressure.  -Can adapt to changing situations with ease.  -Bachelor s Degree from a 4-year university.  -Electrical Engineering, Computer Science or related technical field.  -Strong GPA (3.5 or higher).   Keywords:  Chicago IL Jobs, Trader, Excel Programming, VBA   Programming, C++ Programming, Experienced Trader, Chicago Recruiters,   Information Technology Jobs, IT Jobs, Chicago Recruiting",
			Company = "Next Step Systems",
			City = "Chicago",
			State = "IL",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 30000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "05a67a43ddea7f7016423bbf01e507bc",
			Title = "Operations Manager - Geoscience",
			Description = "Why a Great Opportunity This is a great role for for anyone who is looking for the next step in their career. Someone who has experience within a laboratory setting and as well as having knowledge of sales as well.? Job Description Our client around the Houston area is now hiring for a Operations Manager to bring on to their growing team! MUST have experience in the Geoscience industry. Duties and Responsibilities: Manages all of Fulid and Solid labs to ensure growth & profitability via: Working closely with Sales and in-house Subject matter experts to promote growth Managing lab supervisors to ensure quality service delivery to our customers, that a teamwork environment is maintained and optimal utilisation of our equipment and personnel resources Fostering cross training among the team members to enhance efficiency Working collaboratively with overseas labs to promote increased utilization of our resources towards the benefit of the company Works with Sales team to build accurate Quarterly and annual forecasts Develop and communicate effective staffing and capex plans to support the financial plan Monitor financial performance versus budget and forecast adjusting operational plans as required to achieve the established financial goals Maintains the highest ethical standards, strictly adhere to company policies and always lead by example Upholds the company values of excellence and teamwork keeping the customer at the center of all activities Establishes and maintains a strong QHSE culture. Monitor QHSE performance, apply accountability and remedial action plans as needed in a timely fashion and ensure the required training is kept up to date by all team members. Qualifications Requirements/qualifications: ? Must have a Bachelor of Science within the Geoscience field, with experience managing a Geochemical or PVT lab Have a minimum of 10-15 years experience in the Oil and Gas industry with a minimum of 3-5 years in Sales or business development and a minimum of 3-5 years in a managerial role (running a P&L). Please send your resumes to Philip to be considered for this role today! Job Summary Location Houston, TX Posted 5 Days ago Reference code 29492",
			Company = "NPAworldwide Recruitment Network",
			City = "Houston",
			State = "TX",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 77000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "f94d99a1949d255cc4696fa2aa23b3e2",
			Title = "Interpreter - Language Services (Arabic)",
			Description = "Overview   Overview    In this role you will facilitate patient care by providing Arabic interpreter services between patients and physicians, nursing staff or other hospital personnel. You will be relied upon to assist Arabic-speaking patients and family members with the completion of required forms and surveys. You will also conduct structured phone interviews with Arabic-Speaking patients and maintain statistics on interpreter services provided.  The Arabic Interpreter must be flexible, able to work well under pressure, multi- task assignments, and react quickly to solve complex linguistic and ethical problems as they arise. The interpreter should interpret in an accurate and complete manner; and should follow the Code of Ethics and the National Standards of Practice for Medical Interpreters. The interpreter should have an extended knowledge of specialty medical terminology and be able to perform independently in a fast pace environment. Medical interpreters will translate written materials from source to target language in a precise way. Interpreters will effectively identify cultural differences as potential communication barriers that could interfere with the exchange of information between providers, patients and their families.  QUALIFICATION:  ?  The successful candidate must have a minimum of 40 hours of coursework/certification for interpreting in the healthcare profession (i.e. ? Culture Smart or Bridging the Gap). Minimum 2-5 years of translation/interpretation field work experience required. Written and oral proficiency in English and?Arabic language also required. Well versed on code of ethics and protocols for interpreting in a healthcare facility is essential.",
			Company = "Hospital for Special Surgery",
			City = "New York",
			State = "NY",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 57000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Communications"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "da052ce5b451033f1995e222e90d7091",
			Title = "Healthcare Purchasing Financial Analyst",
			Description = "A prestigious academic medical center with a level I trauma center in one of the boroughs of New York City is currently seeking a new Hospital Financial Analyst  This 500-bed facility prides itself on providing high quality care in a compassionate and positive environment. Research and education are very important to the hospital system; employees are continually developing new lifesaving treatments and therapies and participate in continuing medical education programs. This hospital has continuously been on the cutting edge and up to date on the latest evidence base practice procedures.  The Hospital Financial Analyst will oversee the evaluation of financial data generated by the hospital?s medical practice group. The incumbent will report their findings in the areas of revenue and cost data, profit and loss statements, and incentive models to the most senior levels of management within the hospital. The ideal candidate will bring 2-3 years of experience working in healthcare finance and have experience using the healthcare information system Meditech. Experience with budgets, accounting, physician compensation models, medical group practice income statements, and revenue cycle management are all highly preferred.  This facility is located in an area of New York City that is known for its thriving art, music, and restaurant scene. The Hospital Financial Analyst will find themselves in a safe area where people in the community are very welcoming and come from a diverse mix of backgrounds.  The Hospital Financial Analyst can expect a highly competitive starting salary as well as a comprehensive benefits package from the top New York City hospital.",
			Company = "Clinical Management Consultants",
			City = "New York",
			State = "NY",
			PostedDate = new DateTime(2020,1,7),
			MinimumSalary = 41000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "5fd5200cdd554eb0a8e363edaff19f82",
			Title = "Hospital Chief Financial Officer",
			Description = "An exciting opportunity for a Clinical Chief Financial Officer is now available for an experienced healthcareprofessional . This for-profit facility is prepared to add a dynamic leader to their Leadership Team in a beautiful part of southern Virginia! The Chief Financial Officer will be joining a 200+bed, educational hospital that offers high quality inpatient, outpatient, diagnostic imaging, medical, surgical and emergency services. As an acute care hospital, they have a Certified Primary Stroke Center, an Accredited Chest Pain Center and an Accredited Cancer Center. The medical center also features a Level III Trauma Center. Reporting to the CEO, the Chief Financial Officerwill be responsible for all financial and fiscal management aspects of company operations, which includes the management of accounting, budget management, purchasing, financial, compliance auditing and financial reporting to regulatory agencies and committees of the organization. The new Chief Financial Officer will oversee costs by identifying opportunities and taking action to eliminate non-value costs in union with the hospital's Chief Executive Officer and Chief Nursing Officer. The Chief Financial Officer will interact with other managers to provide consultative support to planning initiatives through financial and management information analyses, reports and recommendations. The ideal Chief Financial Officer candidate should be Masters prepared and a CPA. The new CFO should have five to seven years of progressive finance experience in an acute care environment as well as have the ability to define problems and maintain confidential information. The Hospital CFO will live in an ideal part of Virginia, just a short drive from the shore. Everything you need from fine dining, great shopping and entertaining night life can be enjoyed all year round. The Chief Financial Officerwill be a part of financially stablehealthcareorganization that offers the chance to work in a rewarding, team-oriented work environment, to earn a competitive salary and enjoy excellent benefits. Join the team now! monsterboost5000 Job Summary Location Petersburg, VA Posted 3 Days ago Reference code 238722020-01-27",
			Company = "Clinical Management Consultants",
			City = "Petersburg",
			State = "VA",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 51000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "33e6a1ed36ca08002a61f633b0114ef7",
			Title = "General Manager Position",
			Description = "Providing Legendary Service   Located in West Hollywood, on Sunset and La Cienega, This LA Landmark was founded in 1987, Pink Dot is a market and delivery service that offers liquor, deli, and groceries.?  Pink Dot is much more than a store Its a LA Staple- it's a lifestyle brand that stands for the perfect experience for the moment - Simply put, we're rooted in being Legendary and we're looking for our new team members to be the same.   We are looking for a tech-savvy and well organized General Manager   As the GM of Pink Dot you will be responsible for overseeing all business operations and managing the other employees. This unique position will challenge you and teach you a wide range of skills.   Compensation    $50k - 75k per year depending on experience  Performance-based?bonuses    Duties / Responsibilities    Managing employee schedules and hiring  Managing inventory and vendor relationships  Monitoring sales and cost of good and reporting to the Owner  Creating and executing strategies to increase sales  Creating new processes to increase efficiency  Must have a flexible schedule  Must be very organized    Qualifications    Highly organized and tech-savvy (ability to navigate Point of Sale systems and web applications)  Process-oriented - always thinking of new ways to increase efficiency?  Must have 3+ years experience in a management role overseeing 10+ other employees  Great communicator and ready to lead a team  ?Must be available 40+ hours a week  Must pass background check  Must be a Team Leader and good attitue    Schedule    5 - 6 days per week open the store @ 8:30am?  Might need to work night shifts as needed in special situations",
			Company = "Pink Dot",
			City = "West Hollywood",
			State = "CA",
			PostedDate = new DateTime(2020,1,8),
			MinimumSalary = 65000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "22f71d131412929afb6ac7436e63ec51",
			Title = "Executive Director Ambulatory Surgery Center Operations",
			Description = "An exceptional opportunity is available for a Regional Ambulatory Surgery Center Administrator. The Regional Administrator will oversee multiple outpatient surgery centers and surgical hospitals in Northern California.  The surgery centers are affiliated with a large healthcaresystem with multiple ASCs, acute care hospitals and clinics throughout the West Coast. The Regional Administrator will hold a valuable role as this company continues growing, expanding and building lasting relationships with physicians in the region. The RVP is supported by local Surgery Center Administrators at each outpatient center; the Regional Administrator also recruits, selects, directly supervises, and counsels ASC Administrators and or surgical hospital CEO. This position will report to the Senior Chief of Operations and CEO.  The Regional Surgery Center Administrator's task may include but are not limited to:   Monitors quality, service, finance and growth performance of individual ASCs and or surgical hospital works with ASC Administrators to meet goals.  Assists Surgical Hospital CEOs in developing the annual operating and capital budgets.  Monitors business processes and outcomes, recommending corrective actions to ensure effective implementation  Identifies and develops new programs and sources of revenue.   This exceptional Regional Director opportunity will provide professional growth, daily challenges and learning opportunity for even experienced ASCAdministrators.  Located in Northern California, the Regional ASCDirector will be supported with a high base salary with bonus potential. Additionally, there is potential for relocation assistance for out of area candidates.",
			Company = "Clinical Management Consultants",
			City = "San Jose",
			State = "CA",
			PostedDate = new DateTime(2020,1,10),
			MinimumSalary = 83000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "54984ff503d1943caf8cd241dab73a4e",
			Title = "Cloud Software Developer",
			Description = "Title         : Cloud Software Developer    Location  : Cookeville, TN    Duration  : Contract to hire     Qualifications:    BS degree in Engineering, Computer Science, Information     Technology, Computer Engineering or related field  0-2 years' experience in testing, software development, quality     assurance, and troubleshooting  Experience in at least one of the following areas:  Front-end Web Development: Using a JavaScript library, plus HTML 5     and CSS3  React  Angular  Vue  Back-end Web Development with Java: Using Java for web application     development, including associated tooling  Spring Boot  JUnit  Pipeline Development: Continuous Integration/Continuous Deployment     (CI/CD) pipeline tools  Helm  Jenkins  Cloud Native Development (Nice to have): Cloud services from AWS     or Azure  Automated Testing: Automating unit, integration, performance, or     end-to-end testing.  JUnit  JMeter  Selenium  Jest  Required Clearance :Ability to obtain and maintain a Secret     Security Clearance    Desired Qualifications:    Git: Experience using Git in a team environment, including     branching strategies.  Agile/Scrum: Familiarity with Kanban, Scrum, or Extreme     Programming (XP).  Knowledge of how Agile Toolsets like JIRA and Confluence work, how     Scrum is done, standard Scrum ceremonies.  Containers: Exposure to Docker.  Linux: Familiarity with common Linux commands and system     configuration used.  Enjoy solving challenging problems well by using all available     resources including collaboration with teammates, internet search,     tools and libraries  Willingness to appear on webcam in remote team meetings",
			Company = "Zolon Tech Solutions Inc",
			City = "Cookeville",
			State = "TN",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 32000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "3114e404ca806dc3d6e7a621392fe506",
			Title = "Director of Inpatient Pharmacy PIC",
			Description = "A beloved community medical center is now looking for a Director of Inpatient Pharmacy PIC to join their experienced Acute Pharmacy team in beautiful, serene Washington State.  Reporting to the CEO and CMO, the Director of Inpatient Pharmacy PIC will be the only Pharmacist on staff and oversee one Pharmacy Technician. The hospital is contracted with a remote service that handles night and weekends. The Director of Inpatient Pharmacy PIC will often collaborate with hospital staff to answer questions and provide information regarding drug interactions, side effects, dosages, and storage of pharmaceuticals. The Director of Inpatient Pharmacy PIC should be a strong communicator with ample inpatient hospital pharmacy experience.  The Director of Inpatient Pharmacy PIC will work fastidiously to safeguard order and work persistently to improve processes and adhere to researched best practices and procedures. The Director of Inpatient Pharmacy PIC will participate in Quality Assurance and Drug Use Evaluation programs and complete drug utilization reviews for the Pharmacy and Therapeutics Committee.  Make your next home in beautiful Western Washington, where a wide array of recreational activities including skiing, kayaking and golfing will be right in your backyard. This area is known for its great school districts, unique restaurants, and proximity to vibrant city life.  This stable, respected medical center is prepared to offer the qualified Director of Inpatient Pharmacy PIC a competitive salary and a full suite of benefits, including relocation assistance. The area surrounding the hospital is fantastic for Hospital Pharmacists in Charge with a love for the outdoors.",
			Company = "Clinical Management Consultants",
			City = "Eatonville",
			State = "WA",
			PostedDate = new DateTime(2020,1,3),
			MinimumSalary = 44000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "69d9e26e4e6f6d8a3191bdd25e5685ad",
			Title = "X-Ray Technician-PD",
			Description = "ABOUT US      St. Joseph Hospital, located at 4295 Hempstead Turnpike, Bethpage, New York 11714, is a community hospital that provides comprehensive inpatient and outpatient medical, critical care and surgical services. Its Emergency Department cares for approximately 33,000 patients a year. Other vital services include an Ambulatory Surgery Unit, The Center for Sleep Medicine, Hyperbaric and Wound Healing Center, CHS Cancer Center that treats a full array of infusion therapies in a private six chair unit, The Center for Speech and Swallowing Disorders, a Diabetes Education Center and a full scope of outpatient radiology services, including Cardiac CT.   St. Joseph Hospital became a member of Catholic Health Services (CHS) of Long Island in early 2010. CHS is an integrated health care delivery system which includes six hospitals, three skilled nursing facilities, a regional home health agency, hospice and a multiservice, community-based agency for persons with special needs. Under the sponsorship of the Diocese of Rockville Centre, CHS serves hundreds of thousands of Long Islanders each year, providing care that extends from the beginning of life to helping people live their final years in comfort, grace and dignity.      Xray Technologist      Under the general supervision of a radiologist and/or appropriate physician, performs radiographic procedures. Operates x-ray equipment, fixed or mobile, develops film, prepares x-ray room, equipment, supplies and medications.    QUALIFICATIONS: Must be licensed/registered by the American Registry of Radiologic Technologists. Must have current licensure to practice in N.Y.S. Minimum of 1 year experience preferred.   ",
			Company = "CATHOLIC HEALTH CARE SERVICES",
			City = "Bethpage",
			State = "NY",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 95000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "f3266c36b9f1b84f719aaff916187f2b",
			Title = "Cardiac Sonographer / Ultrasound Tech III",
			Description = "Overview  Ultrasound Tech III  Full Time, 80 Hours Per Pay Period, Days  Will work in Fort Sanders Regional Medical Center's Cardiac Diagnostics Department. We are an IAC accredited facility that uses state of the art equipment and techniques to ensure excellent patient outcomes.   Our Cardiac Sonographers can expect to perform echocardiograms following IAC guidelines that will include transthoracic echocardiograms, transesophageal echocardiograms, and stress echocardiograms. Sonographers are responsible for completing preliminary reports for the interpreting Cardiologists, and they will provide support/assistance as needed in the Cardiac Diagnostics Department.  Position Summary: Performs physician-defined routine and specialized diagnostic imaging procedures.  Provides support assistance/activities as needed.  Performs all duties of Ultrasound technologists.  Minimum Education: None specified; however, must be sufficient to meet the standards for achievement of the below indicated license and/or certification as required by the issuing authority.  Minimum Experience: Clinical training appropriate to the specified modality and either:ARDMS registered in two (2) modalities;ORThree (3) years clinical ultrasound experience;pluseither:ARDMS registered in a single modality, orCCI registry-level credential, orAmerican Registry of Radiologic Technologist with ultrasound-specific registry: ARRT(S) or ARRT(VS)  Licensure Requirement: Must have and maintain Tennessee State ARDMS, ARRT(S), ARRT (VS), or CCI registry-level credential. CPR required.  ID2894630  FacilityFort Sanders Regional Medical Center  Job LocationUS-TN-Knoxville  Department NameCARDIAC DIAGNOSTICS",
			Company = "Covenant Health Inc.",
			City = "Knoxville",
			State = "TN",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 33000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "ea291b44b070e7981b70dc0e171a8a06",
			Title = "Radiologic Technologist",
			Description = "Looking for your next opportunity? If so, choose Parkland and discover what a meaningful job feels like. Whether you work directly with patients or use your talent to support our care, you?ll be part of a team that?s providing valuable health services to Dallas County residents. And here, you?ll have the opportunity to put all your skills to work, and the support to grow and advance in your job and your field. Step into a career that will make a substantial difference for our patients?and for you. We blend cultures, talents, and experience into an exemplary health and hospital system.? Parkland has earned distinction as one of America?s Best Hospitals by U.S News and World Report every year since 1994. PRIMARY PURPOSEResponsible for filming and developing radiographic films in assigned area of Radiology, meeting standards set by PHHS, State and Federal regulations.MINIMUM SPECIFICATIONS Education:- Must be a graduate of a Joint Review Committee on Education in Radiologic Technology (JRCERT) accredited Radiology Program.Experience:- None.Certification/Registration/Licensure:- Must have American Registry of Radiologic Technologists (ARRT) certification. - Must have a Texas Department of State Health Services (TDSHS) - Medical Radiologic Technologist (MRT) certification. - Must have a current Healthcare Provider CPR course completion card prior to hire and/or placement in job from one of the following: - American Heart Association - American Red Cross Rescuer - Military Training Network.Skills or Special Abilities:- Must be able to demonstrate time management, organizational, and interpersonal skills.- Must be able to demonstrate oral and written communication skills.- Must be able to demonstrate knowledge of Radiologic equipment.- Must be able to demonstrate patient centered/patient valued behaviors. Parkland Health and Hospital System prohibits discrimination based on age (40 or over), race, color, religion, sex (including pregnancy), sexual orientation, gender identity, gender expression, genetic information, disability, national origin, marital status, political belief, or veteran status. Job Summary Location Dallas, TX 75201 Posted 1 Days ago Reference code 7941_148377-en_US",
			Company = "Parkland",
			City = "Dallas",
			State = "TX",
			PostedDate = new DateTime(2020,1,30),
			MinimumSalary = 46000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "e8e776cc62f96d3648216fb98d9ec55c",
			Title = "Assistant Nurse Manager Emergency Services",
			Description = "A fantastic hospital in beautiful, sunny California is actively looking for a Nurse Supervisor Labor and Delivery and Post-Partum. Don?t miss this wonderful opportunity to join a dedicated team and a thriving hospital!   This200+ bed acute care facility is accredited by the Joint Commission and offers comprehensive acute and outpatient medical services including laboratory, pharmacy, and diagnostic imaging services.  The Assistant Nurse Manager Emergency Services ER will enjoy working in this active 5+ bed Emergency Department. The ideal candidate will have extensive leadership and clinical experience in emergency services. Reporting to the ER Nurse Manager, the RN Nurse Supervisor Emergency ED is responsible for triaging patient needs, providing after care information to patients and families, and being a mentor to other nursing staff. This is an exceptional opportunity for a motivated RN Nurse Supervisor Emergency ED to be a nurse leader, consultant, and patient advocate with room for growth in an excellent facility.  Located in a dynamic, growing part of Southern California, the Assistant Nurse Manager Emergency Services ER will have endless opportunities to relax and replenish after work. World-class dining, theater, and diverse cultural attractions abound. With sunny, temperate weather, hiking, water sports, and other outdoor excursions are available year-round. The RN Nurse Supervisor Emergency ED will enjoy a healthy work-life balance in this beautiful, exciting area.  This high-quality facility will move quickly to interview an Assistant Nurse Manager Emergency Services ER and will offer a competitive compensation with a full suite of benefits. Apply now",
			Company = "Clinical Management Consultants",
			City = "North Hollywood",
			State = "CA",
			PostedDate = new DateTime(2020,1,9),
			MinimumSalary = 75000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "072818b79620292ad6d56305bafb2d06",
			Title = "General Manager - Hometown Inn / Quality Inn & Suites",
			Description = "With a total of 90 rooms, the   Hometown Inn / Quality Inn & Suites   are within walking distance to shopping, restaurants and the Southwest Alabama Medical Center.?Located between Montgomery and Mobile, Thomasville provides all the comforts of home and exemplifies the true meaning of ?Southern Hospitality.? From locally-owned restaurants with award-winning menus, to the historical attractions and museums, to the recently restored Civic Center, to entertainment offered locally through annual festivals, theatrical productions, concerts, sports and more, Thomasville has something for everyone!?  We are looking for an energetic, hands-on General Manager to become part of our team to provide strong leadership and take this beautiful property to the next level!? The   Hometown Inn / Quality Inn & Suites   will benefit from a leader with strong customer service skills and a management style that includes detailed involvement with daily operations.? The General Manager will receive strong support and direction from Integral Hospitality Solutions, a Choice-approved management company.? Salary commensurate with experience.    Requirements:      GM experience preferred    Sales and marketing skills; sales experience a plus    Accessible at all times by cell phone    Available to work flexible schedule including nights and weekends    Represent the hotel in a professional manner in both appearance and actions    Excellent communication skills - verbal and written    Attention to detail and great organizational skills    Financial leadership to manage the hotel's budget   Ability to train and lead employees with a track record of motivating team members for optimal performance",
			Company = "Integral Hospitality",
			City = "Thomasville",
			State = "AL",
			PostedDate = new DateTime(2020,1,10),
			MinimumSalary = 43000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "1a630e8b500953b3e695b490954dea94",
			Title = "Desktop Support Specialist",
			Description = "DataStaff, Inc. is currently seeking a  Desktop Support   Specialist  for a long-term contract opportunity     in  Raleigh, NC .  The primary function of this   position will be to configure and upgrade laptop and desktop computers   from Windows 7 to Windows 10.      Responsibilities:    Strong written/verbal communication skills, critical thinking,     problem-solving and troubleshooting skills  Must possess excellent time management skills  Must possess strong customer relations skills.    Required Skills:    2 Years: Ability to relay technical information to both technical     and nontechnical personnel  Ability to lift/ move a minimum of 30 lbs.   Ability to work in a flexible environment based on customer     scheduling requirements                          2 Years: Microsoft - Windows Desktop Operating Systems versions 7     and 10           2 Years: Microsoft - Windows Server Systems and their component     roles (AD, DNS, File/ Print Services)     2 Years: Microsoft - Active Directory (AD)               2 Years: Microsoft - Office 365 Account Management       2 Years: McAfee Encryption and Antivirus Software          2 Years: Troubleshooting basic application issues such as Office     and other third-party software       Desired Skills:    Experience with Microsoft Deployment Toolkit (MDT) and LAN Desk a     plus          This opportunity is available on a corp-to-corp basis or as a W2   position with a  competitive benefits package .   DataStaff, Inc. offers medical, dental, and vision coverage options as   well as paid vacation, sick and holiday leave. As many of our   opportunities are long-term, we also have a 401K program available for   employees after 6 months",
			Company = "DataStaff, Inc.",
			City = "Raleigh",
			State = "NC",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 62000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "ef532c1ea70e98b8fbce17f75a709ef8",
			Title = "SAP Instructional Designer/Trainer",
			Description = "Job ID: NY-IDT (90090204) SAP Instructional Designer/Trainer with Treasury &amp; Risk Management (TRM), Consumer and Mortgage Loans (CML), Cash Management, Fiori, SharePoint, SAP Enable Now (WPB) and public finance/housing finance/government experience Location: 641 Lexington Avenue, New York, NY (NY HCR New York State Homes and Community Renewal) Duration: 6+ months Visa: Any Interview: In-person Qualifications: Prefer experience in the following SAP modules: o Treasury &amp; Risk Management (TRM) o Consumer and Mortgage Loans (CML) o Cash Management Fiori experience preferred Expert Level Experience with Excel, Word, PowerPoint; and SharePoint Knowledge in any of the following areas is a plus: finance, mortgages, bonds, affordable housing, public sector Must have solid oral and written communication skills Ability to adapt quickly and work well under pressure SAP Enable Now (WPB) Responsibilities Include (but not limited to): Work collaboratively with BAM team members to create course content, materials, and assessments that meet specified learning objectives/goals; including PowerPoint Presentations, SAP Enable Now Documents, Quick Reference Guides, Job Aids and Course Assessments Ensuring the instructional strategy that has been established for the project is applied to courses Ensure the design integrity of ILT courses is maintained by applying industry-standard instructional design principles and theories in the design process Revising all course materials according to course reviews by the client Collaborating with the Lead on schedules and deadlines Participate in facilitating Train-the-Trainer Co-facilitate end-user training with BAM appointed trainers where needed Job Summary: The Instructional Designer/Trainer is responsible for designing and developing effective and engaging instructional materials for instructor-led, web-based, expert-led and/or blending learning platforms. The Instructional Designer/Trainer will be tasked with performing curriculum design work consistent with sound instructional design principles and must be highly organized, detail-oriented, and meet deadlines. - provided by Dice Job Summary Location New York, NY 10001 Posted Today Reference code 6874_859e11f9855b90b8041caad297aa2d4c",
			Company = "Innosoul inc",
			City = "New York",
			State = "NY",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 47000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "f85ba92ec355426183ebc47d8f029145",
			Title = "Director Business Development and Public Relations",
			Description = "A Western Washington State Medical Center is actively seeking an Director Business and Public Relations to join their growing healthcare organization.  The Director Business and Fund Development will report to the Chief Executive Officer, and will oversee a team of employees.  The Business Development Director will be responsible for designing and implementing a comprehensive plan for creating and maintaining relationships with external entities by creating philanthropic support.  Ideally, the medical center has is seeking an individual with experience as a Chief Development Officer, or Major Gift Officer. The Executive Director will be responsible for creating a strategic plan to increase overall donations and philanthropic gifts for the organization. The Director will be responsible for Public Relations, Marketing, Community Development Projects, Foundation Board and all fundraising.  The Director will work for ahealth care organization which has been part of the community for over 50 years, and is known throughout the region for their high level of patient care. Annually the Medical Center sees over 20,000 visits in their emergency room, performs over 1,000 inpatient and 1,000 outpatient surgical procedures, and delivers over 700 newborns.  Located in Western Washington, the medical center is located just outside the heart of Seattle and Tacoma, surrounded by the natural beauty of the Pacific Northwest. The region is home to an affordable housing market,unparalleled natural beauty, a stable economy, and a charming community.  The medical Center is part of a large and stablehealthcareorganization, and is prepared to offer a generous salary, comprehensive benefit package, bonus incentive and relocation assistance.",
			Company = "Clinical Management Consultants",
			City = "Elma",
			State = "WA",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 86000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Communications"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "278e5bccf26eb3462707fa798c3dea2a",
			Title = "Senior IT Architect - Data Warehouse (DWH) Data Modeler",
			Description = "Title: Senior IT Architect - Data Warehouse (DWH) Data Modeler   Location: Baltimore, MD    Duration: 3-5 years    Preferred:  Knowledge of education data   Duties:  Provides expertise in the most current   principles and practices of architecture data management systems and   experience in large system designs, and with data modeling in the   information management arena. Provides expertise in modeling and   organizing information to facilitate support of projects or   information architectures. Provides guidance on how and what to data   and process model.  Primarily deals with transition planning from   legacy to modern systems by concentrating on information flows, data   exchange, and data translation standardization services.   Education:  Bachelor s Degree from an accredited   college or university with a major in Engineering, Computer Science,   Mathematics or a related field. Master s degree preferred. General   Experience: At least ten (10) years of experience planning, designing,   building, and implementing IT systems. Specialized   Experience:  At least five (5) years of the required   ten (10) years of experience must be in the direct supervision and   management of major projects that involve providing professional   support services and/or the integration, implementation and transition   of large complex system and subsystem architectures. Must have led or   been chief architect in major IT implementation efforts. Must   demonstrate a broad understanding of client IT environmental issues   and solutions and be a recognized expert within the IT industry. Must   demonstrate advanced abilities to team and mentor and possess   demonstrated excellence in written and verbal communication skills.",
			Company = "International Millennium Consultants, Inc. (IMC)",
			City = "Baltimore",
			State = "MD",
			PostedDate = new DateTime(2020,1,15),
			MinimumSalary = 37000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Communications"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "e4db52d7ea904fafa0372ba0f116434f",
			Title = "Optician - Terre Haute Optometry Practice",
			Description = "Dr. Tavel Family Eyecare has been family owned and operated since 1940. We provide Indiana families with an extensive array of high quality, yet affordable eyecare products and services.  At Dr. Tavel we pride ourselves on being one of Indianas largest eyecare providers and we accept hundreds of insurance plans at all 21 of our locations throughout the state. We believe in providing a transformational eyecare experience to every patient, every time.  We are seeking energetic, adaptable, and professional individuals for our fast growing Terre Haute location. As an Optician, you are integral to the success of the office by providing courteous and professional service, effectively communicating with patients and staff, and ensuring a quality patient experience.  Our staff believe Dr. Tavel Family Eyecare is great place to work because we provide the tools to grow and achieve success.  Be a part of our growing family, be a part of our vision!  Our Opticians have the following responsibilities:    Greet patients as they come into the office    Check-in and Check-out patient appointments    Run insurance eligibility    Help patients select the most fashionable eyewear for their prescription    Complete online and in store training to achieve promotion and advancement    Fit Frames and Contacts    Recommend Lens and lens add-ons    Requirements    Bilingual in Spanish is a plus    Medical experience is preferred    Reliable transportation to and from work    All applicants will be subject to a criminal background check. Dr. Tavel is an equal opportunity / affirmative action employer .  Benefits    Vacation/paid time off    Free eye exams    Free eyewear after 6 months and then yearly    Health insurance    Dental insurance    401K",
			Company = "Dr. Tavel Optical Group",
			City = "Terre Haute",
			State = "IN",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 84000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "b58a2660fdf8099849a045df729cc1a3",
			Title = "Assistive Technology Specialist",
			Description = "Position Summary Provide services for students with disabilities who require accommodations locally and abroad. Provide departmental and student assistive technology services, and implement accommodations. Convert classroom and university related materials into an accessible format. Inform students and faculty about disability services. Advise students of their rights and responsibilities; interpret federal policies and procedures. Qualifications Required Education: Bachelor's Degree in appropriate discipline (IT, Counseling, Psychology, Teaching and Learning, Education, Rehabilitation Counseling, Social Work, or related area) Required Experience: 2+ years directly related experience with appropriate adult population with disability(ies). Comprehensive, working knowledge of assistive technology (i.e. Jaws, Dragon, Zoomtext, Kurzweil, Read and Write, VoiceOver, (iOS and Mac) and NVDA. Working knowledge of Microsoft Office accessibility checkers and Adobe Acrobat Pro accessibility checker. Document remediation experience (i.e. PDF to Word doc remediation and PDF to Braille remediation). Working knowledge of Optical Character Recognition programs, such as ABBYY FineReader, OmniPage, INFTY Reader. Working knowledge of WCAG 2.0. Preferred Experience: 3+ years Experience within a higher education setting working with undergraduate and graduate level students. Experience evaluating disability documentation, arranging accommodations. Experience creating tactile graphics Required Skills, Knowledge and Abilities: Excellent interpersonal, listening, written and verbal communication skills. . Knowledge of federal and state regulations regarding ADA and compliance in higher education. Ability to learn new computer systems as advances in technology are made. Train individuals in the use of adaptive systems. Remain current on assistive technology trends. Effectively communicate technical and complex information both in writing and verbally. Analyze and resolve problems. Additional Information NYU aims to be among the greenest urban campuses in the country and carbon neutral by 2040. Learn more at nyu.edu/sustainability.EOE/AA/Minorities/Females/Vet/Disabled/Sexual Orientation/Gender Identity Job Summary Location New York, NY Posted 1 Days ago Reference code 7129",
			Company = "NYU",
			City = "New York",
			State = "NY",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 45000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "3e5756778d317714698cb0ce846b8e9c",
			Title = "Agile Project Manager with Health care experience",
			Description = "Requirements   Bachelor s degree or higher.   At least seven years of medium to large-scale project experience     in a project management role.  At least seven years of strong experience with project planning, resource planning, and work plan development, and project management processes.  Strong verbal and written communication skills, including the     ability to gather and provide information effectively when under     pressure, regardless of audience.  Must be able to work well within a team environment and have     exceptional collaboration skills with all levels of business and     technical staff.  Strong organization, planning, problem solving, and decision making skills. Comfortable prioritizing and managing multiple tasks with minimal direction.  Proficiency in Microsoft Office tools (Outlook, Word, Excel,     PowerPoint, and Visio).  Complete fluency in speaking and writing in the English language     is required.  Knowledge of the software development lifecycle (SDLC) including:     requirements gathering, design, development, testing, training,     quality assurance, development methods/techniques, testing methods/techniques and implementation planning and execution.  Experience with multiple project management methodologies (Waterfall, Agile, LEAN)    Preferred :   Bachelor s degree or higher.  At least ten years of medium to large-scale project experience in     a project management role.  At least ten years of strong experience with project planning,     resource planning, work plan development, and project management processes.  PMI certification.  Experience with enterprise project portfolio management development.  Experience with use of Workfront, Jira and Confluence.  Experience using SAFe Agile",
			Company = "NovaLink Solutions",
			City = "Lincoln",
			State = "NE",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 79000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d99cec869b0add0270bb108f4df3c00a",
			Title = "Fraud Monitoring Professional Developer - Investments & Capital Markets",
			Description = "At Freddie Mac, the Payment Modernization program team is responsible for a number of products and is part of the Investments and Capital Markets Business Technology Office (I&CM BTO). The team works closely with our customers in Enterprise operations to develop solutions that enhance and streamline payment processes, while reducing risk. The team is seeking a Professional developer to work with team members and business partners to design, develop, and implement innovative solutions in a dynamic and fast-paced business environment using Modern Delivery processes and techniques. Sound interesting? Keep reading! Your Work Falls into Three Primary Categories: Software Development: Developing software and automated tests in a SCRUM-based agile product team Prior experience with SAS and integrating vendor products will be beneficial Contributing in a Modern Delivery team Working collaboratively with the other team members to maximize productivity Prior experience with Docker and highly automated Continuous Integration environments using gradle will be an advantage Aligning with the business needs for the product Working closely with analysts and other team members to compose and refine user stories for the team's product Qualifications Qualifications 3-5 years of IT experience in design, development, integration and testing of software solutions based on Java, Python or SAS 3-5 years of experience with development of solutions using relational databases including Sybase, Oracle, SQL Server, PostgreSQL, and/or DB2 Experience with collaborative development using GIT Bachelor's degree in computer science or related field Keys to Success in this Role Excellent and efficient software development Collaborative working approach on technology and user story definition Ability to communicate effectively with analysts and other developers Today, Freddie Mac makes home possible for one in four home borrowers and is one of the largest sources of financing for multifamily housing. Join our smart, creative and dedicated team and you'll do important work for the housing finance system and make a difference in the lives of others. Freddie Mac is an equal opportunity and top diversity employer. EOE, M/F/D/V. Job Summary Location McLean, VA Posted Today Reference code 40697639",
			Company = "Freddie Mac",
			City = "McLean",
			State = "VA",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 65000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "2639da96d82bd8e7274d1d959a887f6c",
			Title = "Lead Oracle Apps (SCM) Programmer Analyst",
			Description = "*This position is with our direct end client and requires all applicants to be eligible to work in the US on a Full Time basis. No Visa sponsorship. Job Title: Lead Oracle Programmer Analyst (SCM) Description: JOB SUMMARY / GENERAL DESCRIPTION: Design, estimate, develop, document, and implement well tested solutions that satisfy the requirements of each application development request within the allocated time and budget for each request. ESSENTIAL JOB FUNCTIONS / PRINCIPAL ACCOUNTABILITIES: Other duties may be assigned. A teammate in this position must have the ability to: Create documentation where appropriate. Provide detailed status updates when needed. Log accurate information into the time-tracking system. Continuously learn new tools and environments and acquire new skills to maintain and enhance job performance. Ensure that the companies methodology is followed. Ensure that requirements and development deliverables match the design specifications. Ensure that the test plans match the requirements. Ensure that the test results match the test plans. Provide high-level and detailed estimates. Create an appropriate Test environment for the project team to work with and validate the delivered solutions. Create high-level and detailed developer specifications. Develop and tests solutions using the companies Development tools in our environment that meet the our standards. Provide the appropriate implementation documentation for installs. Manage and execute the system-testing process and UAT process. Support the implementation and post-implementation activities. MINIMUM QUALIFICATIONS AND REQUIREMENTS: A teammate in this position must have: 8+ Years Experience with Oracle EBS Oracle EBS 12.2.x development and implementation Technical experience with multiple Supply Chain Management modules including VCP- Demantra & ASCP, Purchasing, iSupplier, Inventory, SOM, Product & Customer Hub. Proficiency in Oracle PL/SQL, Oracle Forms, Oracle JDeveloper and Oracle Report Builder, OA Framework Strong SQL is a must. Unix, MQ, MQ FTE experience is a plus. Oracle SCM Functional knowledge is a plus. Bachelor?s Degree. 8+ years of IT related experience. - provided by Dice Job Summary Location Temple, TX 76501 Posted Today Reference code 6874_8d89a607b97a6b299076aa6af309c342",
			Company = "TITAN TECHNOLOGIES",
			City = "Temple",
			State = "TX",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 93000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "3c36a64ac426bb7b81009879af4781f5",
			Title = "BA Business Analyst JDE",
			Description = "Why a Great Opportunity My client is a well-known International Corporation based in Maryland, they have an excellent work environment and great benefits.? Work at Corporate Offices with a very progressive team of professionals.??? Client is growing and has numerous companies within their corporate structure.? Client is running JDEdwards EOne 9.2 and looking for a strong BA supporting current needs as well as creating new business processes. This is an excellent Company to work for, they are growing at a tremendous rate on a Global basis. Compensation Flex DOE Job Description Provide support for the integration of JDEdwards EnterpriseOne 9.x Participate in system upgrades by assisting in planning and testing those upgrades. Continuously gains an understanding of the customers? operations and how systems are used in support of their operations, transferring knowledge to users, programmers and IT support personnel. Stay abreast of new JDE releases and applications and present opportunities for improvement to the business units. Determine functional requirements and recommends workable JDE solutions to management and staff. Develop new, or modifies existing software solutions to satisfy ongoing company business needs.? Qualifications Bachelor?s degree preferred or equivalent. Minimum 3 years of experience in the in Distribution (SoM, Procurement, Inventory, Advanced Pricing) Modules / Applications of the Oracle - JD Edwards EnterpriseOne 9.x Strong business?process knowledge of the Distribution functional area. Ability to write functional specifications for custom JDE objects, work with technical consultants in custom object development and unit test. Strong verbal and written communication skills Strong organizational, coordination, facilitation, consultation and conflict resolution skills Ability to work well in a team environment Ability to prepare SQL statements using Oracle SQL or TOAD 3+ years of DSI integration or similar product Experience in BI, Microsoft Products a plus (Power BI) Understands JDE integration methodology and ability to understand and troubleshoot issues as they arise. Broad, in-depth knowledge of the manufacturing industry, including industry best practices and trends Job Summary Location Temple Hills, MD Posted 2 Days ago Reference code 29104",
			Company = "NPAworldwide Recruitment Network",
			City = "Temple Hills",
			State = "MD",
			PostedDate = new DateTime(2020,1,8),
			MinimumSalary = 95000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d5983e02b39cce6660f9eca61751dd8a",
			Title = "IT Manager/Systems Administrator",
			Description = "IT Manager/Systems Administrator    Thompson, CT    Full Time with Benefits         Are you looking for an opportunity to advance your career with     Medical Device Industry?   This exciting opportunity offers a competitive salary plus an     excellent benefits package including, medical insurance, dental     insurance, vision insurance, 401K, paid vacation, paid holidays, and     paid PTO. Does this position match your future career goals? Then     this opportunity could be the right fit for you.       We are looking for an IT Manager/Systems Administrator for our client   in the Medical Device Industry. This role will be responsible will   provide Support to the business through the use of Syteline Business   Applications including Insyte Ship Software for shipping.    RESPONSIBILITIES     Must have an understanding of manufacturing business practices as     well as how each business unit interacts.  The individual is required to provide technical support to     approximately 70 users and their PCs.  This position requires some understanding of the ISO certification     process and how it relates to the IT department.  Communicate regularly with internal customers and look to enhance     their ability to use existing software and tools.  Provide internal training was needed specifically as it relates to     Syteline ERP.  Consult and communicate regularly with ERP Administrators.    REQUIREMENTS     Bachelor of Science in MIS, Computer Science, Computer     Programming, or any business-related discipline.  7   10 years of equivalent work experience.  Must have extensive IT business support experience in a     manufacturing environment.  Excellent communicational and written skills.  Must have a strong customer service orientation. ",
			Company = "Ajulia Executive Search",
			City = "Thompson",
			State = "CT",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 48000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "8bb51e75a6a343c7bc19675a76b3e7bc",
			Title = "Dental Hygienist",
			Description = "Overview Under direct supervision of the Health Services Administrator (HSA), Program Manager (PM), or higher medical professional, the Dental Hygienist promotes dental health by completing dental therapy; performing procedures in compliance with the dental practice act. Additional Details This position is one day per month, 8 hours. Qualifications Education: ? ? Graduate from an accredited Dental Hygienist school ? Experience: ? ? Two (2) years? experience ? Previous correctional/detention facility experience? Five (5) years? experience ? Licenses/Certifications ? ? Unrestricted current Dental Hygiene license, certification or registration in state of practice - must maintain all certifications, educational requirements, licensing, etc.? Current (and must maintain) lifesaving BLS certification through AHA? Current (and must maintain) lifesaving ACLS certification through AHA Responsibilities Prepares treatment room for persons served by adhering to prescribed procedures and protocols Provides information to persons served and employees by answering questions Maintains instrumentation for dental hygiene treatment by sharpening, sterilizing instruments Selects materials and equipment for dental hygiene visit by evaluating persons served oral health Educates patients by giving oral hygiene and plaque control instructions and postoperative instructions Documents dental hygiene services and dental histories; Document all services provided and refused in persons served dental/medical records Maintains persons served confidence and protects operations by keeping information confidential Maintains safe and clean working environment by complying with procedures, rules, and regulations Protects persons served and employees by adhering to infection-control policies and protocols Ensures operation of dental equipment by completing preventive maintenance requirements; following manufacturer's instructions; troubleshooting malfunctions; calling for repairs; maintaining equipment inventories; evaluating new equipment and techniques Conserves dental resources by using equipment and supplies as needed to accomplish job results Perform other duties as assigned. Wellpath is an EOE/Minorities/Females/Vet/Disability Employer Job Summary Location Woodland, CA Posted 6 Days ago Reference code 75757",
			Company = "Wellpath",
			City = "Woodland",
			State = "CA",
			PostedDate = new DateTime(2020,1,31),
			MinimumSalary = 35000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "142f3a955baa0f134abafb29215934cb",
			Title = "Assistant Property Manager",
			Description = "Why Highmark Residential?   Because every position is considered critical to Highmark?s success and reputation, we take care to employ those who aspire to become the best in their field. Those who succeed at Highmark will do so because they enjoy an empowered, challenging, fulfilling and financially rewarding workplace!   Why we need you:    ?The Assistant Property Manager is responsible for community accounting functions and assists in the administration, leasing and supervision of the team.   What your day to day might look like:     Collect and secure rental payments  Prepare accounting records and reports, including deposit accounting and monthly closeout  Deliver late rent letters and notices to vacate, and contact those who have unpaid/owed rent  Assist in the eviction process and follow policies for local municipalities in a timely manner  Ensures excellent customer service to all residents and prospects  Assist the Property Manager in various tasks as needed  Achieves high resident retention and leasing expectations    We?re looking for you if:     Interested in the above  You have leadership and team-building skills  Excellent mathematical skills (high school level)  You strive for excellence    Some things we can?t live without:     Excellent verbal and written communication skills  High school diploma or equivalent  Valid driver?s license  Proficiency in property management software    What Highmark can do for YOU:    Help you achieve your goals by continuous professional development and regular career progression sessions  Competitive pay for the market  Medical, Dental & Vision benefits the 1 st  of the month following 30 days of full-time employment  401(k) eligibility after 90 days  Professional Certification & Tuition reimbursement  Vacation, Sick and Personal Time off",
			Company = "Highmark Residential",
			City = "Austin",
			State = "TX",
			PostedDate = new DateTime(2020,1,4),
			MinimumSalary = 61000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "24ae7d82ddbe5bd75bf4dbad374c4043",
			Title = "Nurse Educator NICU",
			Description = "A top hospital in the San Francisco Bay Area is looking for a NICU Nurse Educator to lead their NICU departments Nurse Education and Professional Development. This acute care facility is dedicated to quality care and are at the forefront of using evidence-based practice to maintain and improve their patient care.  The Neonatal Intensive Care Unit Nurse Educator will work collaboratively with the NICU leadership team, and the other members of the Advanced Nurse Practice team. The NICU RN Educator will evaluate needs for staff education based on clinical need and facilitate education programs.  This acute care hospital promotes strong nursing teamwork both in units and within the nursing leadership team. This healthcare organization places strong emphasis on staff career development, innovation, and dedication to the highest level of patient care.  The RN Educator NICU will oversee Nurse Education for a level II NICU and will require a Neonatal Nurse Educator with level II, level III, or level IV NICU nursing experience. The NICU Educator will act as consultant for staff for NICU clinical care questions and needs and will provide orientation and in service education programs.  Located in the Bay Area there are endless wonderful things to do and explore. Spend your days off by taking advantage of the beautiful nearby nature, beaches, and hiking opportunities that are perfect to spend time with friends and family. Downtown San Francisco is easily accessible to spend the day exploring the cities museums, sites, dining, picturesque sites, nightlife, and sports events.  The hospital is prepared to offer their Nurse Educator Neonatal a competitive salary and full suite of benefits. Apply today for a wonderful NICU Nurse Educator career opportunity in beautiful sunny California!",
			Company = "Clinical Management Consultants",
			City = "Saratoga",
			State = "CA",
			PostedDate = new DateTime(2020,1,7),
			MinimumSalary = 40000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "e5b2b4c43b6f181d084ec5915206d4ee",
			Title = "Dialysis Travel Patient Care Technician / PCT",
			Description = "Dialysis Travel Patient Care Technician / PCT     The Dialysis Travel Patient Care Technician provides dialysis therapy for patients under the direct supervision of a licensed nurse.   The Dialysis Travel Patient Care Technician duties include:   Setup and operation of hemodialysis machines  Welcoming of assigned patients and reporting any patient complaints about wellbeing to the nurse supervisor.  Monitoring of patient response to dialysis and reporting any unusual findings or issues to the nurse supervisor  Discontinuing of dialysis treatment according to clinic procedures and evaluation of the patient prior to discharge  Documentation of all information related to patient treatment   Assignment Detail for our Dialysis Travel Patient Care Technician in this location:   13 Week Travel Assignment  Chronic Setting  At Quik Travel Staffing, we think big when it comes to compensation for our Dialysis Travel Patient Care Technicians! We are committed to seeing that you receive the best possible wages and associated employment benefits.?   Benefits Provided to our Dialysis Travel Patient Care Technician    Travel and Housing Provided or Reimbursed  Rental Car or Car Allowance  Competitive Pay with Tax Advantages  Direct Deposit  One-on-one service  24/7 Support  Referral Bonus Available  Bonus Program  Health Insurance Available (Medical, Dental, Vision, Life)  401k Available  Opportunities in Locations throughout the country at the completion of the assignment    Job Requirements for our Dialysis Travel Patient Care Technician    1 year of experience as a Dialysis Patient Care Technician  Must meet state certification requirements as determined by clinic location  BLS certification required  Excellent Comprehension and Retention  Able to work independently while striving for the best in patient care",
			Company = "Quik Travel Staffing",
			City = "Anchorage",
			State = "AK",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 39000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "8c28dc5cda0ef00ae5090a9496f2cc8f",
			Title = "Risk and Governance Senior",
			Description = "Freddie Mac's Finance division is currently seeking a Risk & Governance Senior to be part of the Investments and Capital Markets CFO department. The Investments and Capital Markets CFO department is responsible for financial accounting and reporting, hedge accounting, portfolio risk and profitability analysis, pricing and valuation activities, and financial planning & analysis for Freddie Mac's Capital Markets segment. Your Work Falls into Two Primary Categories: Risk and Controls Managing risk and controls inventory for the Investments and Capital Markets CFO department Document risk and controls related to non-SOX processes such as DFAST, Capital Framework, forecast etc. Participate the Quarterly Business Area Risk and Control (BARC) assessments Acting as the department's liaison and managing the relationships with various stakeholders in I&CM and Finance Develop, enhance and streamline risk and control procedures and process flows Undertake ad-hoc risk and controls projects as needed Collaboration Collaborate with internal Self-Testing and Audit team, Internal Auditors and regulators Collaborate with I&CM and Finance departments on adhoc projects Qualifications Qualifications Minimum of 4 years of experience in Risk Management, Compliance, Audit and/or Capital Markets Bachelor's degree in Finance, Accounting or related degree Solid understanding of risk and controls environment and three lines of defense framework Excellent written and verbal communication skills Strong attention to detail Strong problem-solving capabilities Preferred: CFA, CPA or related certifications Keys to Success in this Role Self-starter with a positive outlook and desire to solve problems Strong analytical skills with an ability to understand complex process flows and pays attention to detail Ability to challenge status quo and drive change Ability to work independently and multi-task Today, Freddie Mac makes home possible for one in four home borrowers and is one of the largest sources of financing for multifamily housing. Join our smart, creative and dedicated team and you'll do important work for the housing finance system and make a difference in the lives of others. Freddie Mac is an equal opportunity and top diversity employer. EOE, M/F/D/V. Job Summary Location McLean, VA Posted Today Reference code 40688468",
			Company = "Freddie Mac",
			City = "McLean",
			State = "VA",
			PostedDate = new DateTime(2020,1,25),
			MinimumSalary = 76000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "6e425407a1e772c133c2f5f8112fed97",
			Title = "SERVICE PLANNER",
			Description = "Primary Purpose and Essential Functions: Receive red tags from drivers, process work orders; coordinate equipment with Driver Services and Customer Service; assign jobs to mechanics; and coordinate farmed out equipment with outside vendors.  Processes work orders.  Communicates with Safety/Service Providers about work order write-ups.  Coordinates with Driver Services and Customer Service regarding equipment in shop (time estimates, etc.).  Plan daily work load (repair orders/assign jobs) and coordinates with Shop Supervisor regarding work loads.  Inspect all repair orders for info on warranty repairs and make sure all repairs are put under the proper reason code,  Coordinate as required with the warranty department to ensure sure all units outsourced for repair are under warranty.  Maintain and update the shop DNR work log.  Handle all shop calls for units in and out of shop for repair.  Coordinate with the Onroad department and handle all road calls within 75 miles of the shop.  Provide all Owner Operators copy of a completed repair order when repairs have been completed.  Work with the Parts department and make sure all parts are ordered for units needing repair.  Maintain a positive work atmosphere by acting and communicating in a manner which facilitates the success of business operations in order to meet company demands and expectations.  Perform additional duties as assigned by leadership.    Skills: Mechanical knowledge of DOT approved equipment; demonstrated/proven superior customer service skills; computer keyboarding.  Education: High school diploma or GED.  Experience Required: One (1) year experience service planning, preferably in a heavy truck environment. Experience in warranty, service writer, technician, or administration in a mechnanical related field may be substituted for the one (1) year experience.",
			Company = "Swift Transportation",
			City = "Phoenix",
			State = "AZ",
			PostedDate = new DateTime(2020,1,14),
			MinimumSalary = 42000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "771733c830c267a68465987555ebcc56",
			Title = "Regulatory Clinical Trials Research Manager",
			Description = "An exciting new opening for a Regulatory Clinical Trials Research Manager has opened up in the Colorado Rocky Mountain Foothills.  The Regulatory Clinical Trials Research Manager opening is at a prestigious, magnet facility. This 400 plus bed hospital is recognized as a premiere hospital with high employee satisfaction as well as patient safety.  The Clinical Research at this facility specializes in Cardiology and Cardiothoracic Surgery, Gastroenterology and GI Surgery, Maternal and Fetal Medicine, Oncology and Hematology, Orthopedics and Orthopedic Surgery, Neonatology, Neurology and Neurosurgery, Pulmonary Medicine. The team works diligently focusing on prevention, early detection, and treatment. With 600 plus research studies, this department coordinates all phases and collaborates with maintains top research standards. The department provides rapid enrollment, data integrity and compassionate care.  The Clinical Trails Research Manager oversees a team of research professionals including regulatory affairs team, business analysts and research support team. As the Regulatory Clinical Trials Research Manager, you will be responsible for the day to day operations, compliance, budget development and management. This position is a specialist position in clinical trials research compliance and regulations.  Colorado is a great place to live with diverse and varied scenic landscapes. Denver is a large metropolitan capital with history dating back to the wild west. The town itself offers an exciting music and art scene, shops and boutiques, and noteworthy dining. The Rocky Mountains have destination ski resorts with scenic landscapes. The charming Colorado lifestyle includes all four seasons.  This role offers competitive compensation and benefits with a top-rated hospital in a beautiful location. Come join the team!",
			Company = "Clinical Management Consultants",
			City = "Englewood",
			State = "CO",
			PostedDate = new DateTime(2020,1,21),
			MinimumSalary = 68000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "60d690f3d0694358a60b17bbd12e8dfb",
			Title = "Veterinary Technician",
			Description = "Job Overview Covance?s work in developing new pharmaceutical solutions has an incredible impact on millions of lives worldwide. Be a part of this life-saving work. Help improve patients' lives while growing your career. ? We have a great opportunity for a? Veterinary Technician ?at our Somerset, New Jersey facility. Our ideal candidate has a background in veterinary services, and is? looking for an opportunity to apply those skills on a variety of animals in a research setting. ? In this role you will perform basic veterinary laboratory procedures including but not limited to; ? Perform veterinary treatments.? Monitor the health and welfare of animals currently under veterinary care, document observations and perform follow up observations Maintain and organize animal veterinary records and associate study data, with attention to details and to GLP and USDA compliant standards Observe the health and welfare of all facility animals and provide a proactive approach to veterinary care Collect diagnostic radiographs as needed Perform bi-annual RODAC and drinking water samples for analysis and maintain records Collect biological samples from various species for analysis as needed Coordinate rodent serology program with Rodent Toxicology group Integrate and work well with other departments Maintains veterinary supplies inventory Play a major role in the Environmental Enrichment program, which covers all species, including behavior and socialization of nonhuman primates Ensures that duties are performed according to protocol requirements and adheres to the guidelines of Standard Operation Procedures (SOP), Good Laboratory Practices (GLP), the USDA and the Guide for the Care and Use of Laboratory Animals Posting requires occasional weekend coverage, Overtime often available Education/Qualifications Bachelor degree in Life Sciences, Associate degree in Laboratory Animal Technology or Associate degree in Veterinary Technology. An equivalent combination of education and experience may be accepted as a satisfactory substitute for the specific education. Must be able to work in a laboratory setting with laboratory animals Basic computer knowledge. Basic math skills. Ability to accurately read and record information. Experience 1+ years animal experience preferred Job Summary Location Somerset, NJ Posted 6 Days ago Reference code 41265",
			Company = "Covance",
			City = "Somerset",
			State = "NJ",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 69000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "02251c9cdba4a38299b658718521e9fe",
			Title = "Licensed Practical Nurse LPN",
			Description = "LPN - Licensed Practical Nurse Phoenix / Paradise Valley , AZ We are currently hiring for 12 hour day or night shifts with flexible shifts available! This position is a unique opening to join a team of nurses that provide a high-level of personal care and meet some very specific needs with our clients. As an LPN (Licensed Practical Nurse) on our team, you will provide one-on-one assistance to clients in the comfort of their own homes. In this role you will provide exceptional in-home and companion experiences and assist with services detailed in the customized personal care service plan created for every client. In addition to personal care, you must have experience with: Medication Management IV Infusions Catheter Care Total Care Connections offers the following benefits to our nurses: Competitive pay and Paid Overtime Work close to your home Flexible and regularly available hours - Full-Time Available Continued training opportunities Make a difference in a senior's life Be part of a vibrant company with room to grow Make a difference today. Become a nurse with Total Care Connections! LPN (Licensed Practical Nurse) Job Responsibilities: Healthcare Catheter Care Medication Management IV Infusions Care Management Support Accompanying Caregiver: Provide one-on-one assistance to clients in the comfort of their own homes. Provide exceptional in-home and companion experiences and assist with services detailed in the customized personal care service plan created for every client. Assist clients with ambulation and mobility around the house or outside (doctors appointments, walks etc.) Assist clients with personal care and hygiene Help clients with physical therapy exercises Successful nurse applicants will meet the following requirements: Valid LPN or RN License with the state of Arizona CPR & First Aide Certification TB Test Valid Driver's License, Automobile Insurance, and reliable vehicle Open availability strongly preferred Submit to Criminal Background Investigation, Motor Vehicle Driving Record Submit to Pre-Employment Drug Screening Start your rewarding LPN (Licensed Practical Nurse) career today. Apply now! Total Care Connections in Mesa, AZ proudly serves Paradise Valley, Scottsdale, East Valley and Phoenix Area. APPLY NOW! PM19 PI117257964 Job Summary Location Phoenix, AZ 85017 Posted 1 Days ago Reference code 117257964",
			Company = "Total Care Connections",
			City = "Phoenix",
			State = "AZ",
			PostedDate = new DateTime(2020,1,18),
			MinimumSalary = 42000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "86f562c274bd6a6129e7f24b6cb2c322",
			Title = "Experienced Trader - G",
			Description = "Experienced Trader   Rapidly growing proprietary trading firm with offices in Chicago,   London, &amp; New York City is seeking an Experienced Trader to join a   highly experienced US Equities team.  As a trader, you will be tasked   with not only analyzing and improving upon existing strategies but   driving new initiatives.   Responsibilities:   -Make real time trading decisions using both quantitative and   fundamental data.  -Use data analysis tools to identify and respond to unique market opportunities.  -Use cutting edge technology to build out effective trading   strategies.  Traders work closely with a dedicated technology team in   developing and enhancing strategies.   Qualifications:   -Bachelor s or Master s Degree from a 4-year university in Electrical   Engineering, Computer Science, Mathematics or related technical field.  -Preferred GPA of 3.5 or higher on a 4.0 scale.  -3+ years working experience of high volume, proprietary trading.  -C++ Programming, Excel Programming and VBA Programming experience.  -Proven ability to develop new, profitable trading strategies.  -Knowledge in Python, SQL or similar language, with ability to do   programming work using multi-dimensional arrays, nested loops and   complex conditionals.  -Excellent problem solving skills, with experience working in large   date sets.  -Passion for trading and financial markets.  -Strong mathematical aptitude.  -Values teamwork and is capable of thinking independently.  -Can communicate effectively while under pressure.  -Thrives in a fast paced, ever changing environment.   Keywords:  Chicago IL Jobs, Experienced Trader, Python, C++, Excel,   VBA, SQL, Multi-Dimensional Arrays, Nested Loops, Large Data Sets,   Trading, Financial, Chicago Recruiters, Information Technology Jobs,   IT Jobs, Chicago Recruiting",
			Company = "Next Step Systems",
			City = "Chicago",
			State = "IL",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 93000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "fce03583c8e7b8a2fa0fbf8cd5c7352b",
			Title = "Ambulatory Surgery Operations Director",
			Description = "An exciting new opportunity is now available for an experienced Ambulatory ServicesDirector at a growing outpatient center. This is an opportunity for an experienced leader in ambulatory services to step into a significant leadership role.  With partner centers across the state, theAmbulatory Services Director will have accesses to significant resources to support them in their role. The center prides itself on providing an atmosphere where patients feel comfortable and confident that they will receive personalized advanced treatments, with consistently high patient satisfaction scores. With over 3,000 cases per year, the center is currently looking to expand their efforts and facilities.  The Ambulatory SurgeryCenter Director will work closely with thesystem Administrator and CEO to ensure the appropriate management of the practice?s clinical facility. The Surgical Services Director will oversee clinical and administrative staff, with a focus on quality improvement and business development. Additionally, the Ambulatory Surgery Director will develop policies and procedures to enhance day to day operations of the center, will have financial oversight, and measure performance of non-clinical staff.  Situated in the suburbs of Chicago, this Ambulatory Surgery Center is close to local amenities including excellent food, shopping, and public transportation. Chicago is a cultured city with people from all walks of life, and a place for everyone. The city offers activities for audiences of all ages, including a vibrant nightlife, excellent museums and parks, and is located under an hour from the lake!  The Special Procedures Ambulatory Center Administrator will be offered a very competitive salary and full benefits package. The ideal candidate will be surgical leader with a mind for growing programs, and a heart for patient care.",
			Company = "Clinical Management Consultants",
			City = "Schaumburg",
			State = "IL",
			PostedDate = new DateTime(2020,1,11),
			MinimumSalary = 71000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "7975a948d0c6c17d899ca9fe6600302f",
			Title = "IT Manager/Network Lead",
			Description = "We are hiring an IT manager for a start up in San Mateo. Its a full   time opportunity with the client.  Below are the job details , looking for a hands-on IT manager  Responsibilities include:   Owner of all IT related tasks and issues  Collaborate with partner teams to achieve shared objectives  Manage cross-functional project and program planning and execution  Implement and secure a local network while considering the user     needs, storage capacity and network security features  Manage configuration restrictions, device encryption, software     application version control, and logical security  Develop a formal risk assessment that addresses operations in the     United States.  Implement formal policies and procedures that outline the project,     application, and database management process  Responsible for security audits and certifications    Skills and qualifications:    Bachelor's degree in MIS, Information Technology, or Computer     Science related field preferred  5+ years  experience in an Information Technology or related field  Experience working in an unstructured environment of a hyper     growth technology startup environment highly preferred  Hands-on experience with computer networks, network administration     and network installation  Power-user level experience on OSX and Microsoft Windows  Experience supporting both Android and iOS devices  Experience with security systems or other modern technology     systems to include; networking, database management, core banking or     programming platforms  Strong understanding of banking regulations and their impact on     corporate Information Technology preferred  Ability to communicate clearly to both technical and non-technical     end users    Interested candidates please send your resume and contact details to   discuss further.  ",
			Company = "DPP Tech, Inc.",
			City = "San Mateo",
			State = "CA",
			PostedDate = new DateTime(2020,1,13),
			MinimumSalary = 79000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "15fcfac1c573ad74263e2095455f306c",
			Title = "Senior Mobile Developer",
			Description = "We are looking for a talented Senior Mobile Developer to join our team!    Your Day-To-Day     Define, Design and deploy mobile solutions for clients.   Work with partners and clients to identify and design appropriate     mobile structures.  Provide technical advice and be able to identify technical     implications regarding development activities.   Design and implement mobile architectures.  Work closely with other developers, product managers, DevOps, and     product support engineering teams to deliver development solutions.  Document workflows and relevant processes to execute continuous     improvement plans.  Anticipate, identify, track and resolve technical issues and risks     affecting delivery.     Qualifications and skills relevant to the job:     Strong experience with mobile application development  Familiar with UX/ UI environments  Experience building mobile apps that have successfully launched  Direct work in applications that serve large numbers of users  Familiar with different mobile and web software development ecosystems (Javascript, Swift, C#, Objective-C, etc.)  5+ years of experience with mobile  Experience in-depth hands-on development teams  Experience in post-production maintenance and troubleshooting  Strong technical knowledge and experience in different mobile versions  Experience creating requirement specifications based on Architecture/Development/Detailing of Processes.  Ability to work independently and as a member of a team     Desired Skills:     Telecommunications Industry experience would be a plus     Mandatory Requirements:     Bachelor Degree or Major related to Information Technology Industry  Availability to Travel    Continue growing professionally in a multinational company where we   value talent and experience, and support effort and dedication.     APPLY NOW!",
			Company = "Onis Solutions",
			City = "St. Louis",
			State = "MO",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 72000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "095ed56906e8d82b91535bf7e8c5b4d6",
			Title = "On Site Quality Audit Spec",
			Description = "Description: We are the Health Care Management division of HCSC - a team of dedicated nurses, doctors and other clinicians. Everything we do, and every decision we make, aims to help our members live their most healthy lives. We treat the whole person with integrated pharmacy, physical and mental health care benefits. We're also tackling the social determinants of health by creating non-clinical partnerships in the communities where we work and live, because everyone should have access to quality health care. We use innovative tools and approaches to help members get the most out of their plan benefits, as affordably as possible. We are more than a health care insurer and we are truly anchored in our purpose: to do everything in our power to stand by our members in sickness and in health. BASIC FUNCTION: This position is responsible for conducting provider/practitioner on-site office audits; reviewing and analyzing medical record keeping, medical records and HEDIS documentation; identifying quality issues and monitoring, implementing and tracking interventions; performing oversight of delegated organizations; and ensuring compliance with Plan, BCBSA, NCQA and State and Federal requirements. JOB REQUIREMENTS: *Registered Nurse (RN) with unrestricted license in state. *3 years clinical experience. *2 years experience in utilization review, quality assurance, and/or medical record and site review audits. *Knowledge of medical terminology standard medical practices, formal quality improvement process, and federal, state, accreditation regulations and standards. *Verbal and written communications skills including interpersonal skills for meeting with physicians and office staff and representing the company using diplomatic/professional demeanor. *PC proficiency to include Word and Excel. *Willing to travel, including overnight stays. Frequent local travel and approximately 20-40 overnight stays. PREFERRED JOB REQUIREMENTS: *Certified Professional in Healthcare Quality (CPHQ). *1 year HEDIS abstraction experience. *Experience in systems database. *Experience designing and delivering presentations. *Experience delivering member and/or provider training. *CA Location: NM - Albuquerque Activation Date: Tuesday, January 14, 2020 Expiration Date: Tuesday, March 17, 2020 Job Summary Location Albuquerque, NM 87199 Posted 1 Days ago Reference code 4656_73912",
			Company = "Health Care Service Corporation",
			City = "Albuquerque",
			State = "NM",
			PostedDate = new DateTime(2020,1,14),
			MinimumSalary = 69000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "7585d1c5f4125bddeeffc192ae66bbab",
			Title = "Communication and Credentialing Specialist (680)",
			Description = "Category Med Staff Services - 7183     JOB SUMMARY : The Medical Staff Communication and Credentialing Specialist position is responsible for coordinating physician and staff communication utilizing diagnotes or other communication tools. Facilitates and assists with the OPPE and FPPE (Ongoing Professional Practice Evaluation) reports, the CME program, and credentialing processes. Assists with HFAP survey preparation.   QUALIFICATIONS :   ESSENTIAL FUNCTIONS AND RESPONSIBILITIES :     The Medical Staff Communication and Credentialing Specialist position is responsible for coordinating physician and staff communication utilizing diagnotes or other communication tools.   Facilitates and assists with the OPPE and FPPE (Ongoing Professional Practice Evaluation) reports, reappointments credentialing, and other credentialing processes including affiliation letters and maintaining credential files.   Assists with HFAP accreditation survey preparation.   Assists with data review and other duties as assigned.     EXPECTED BEHAVIORS :     Evidence of strong verbal and written communication skills.   Demonstrates patient's first standards.   Ability to maintain strict confidentiality.   Possesses organizational skills of self and work.   Demonstrated competence in the use of computer programs such as Microsoft Word and Excel with PowerPoint and Access being a plus.   Basic knowledge in the use of office equipment.        ADDITIONAL EDUCATION AND EXPERIENCE REQUIREMENTS :    High school education.   At least one year experience in the medical staff environment.    Mandatory Continuing Education: Customer Service, Fire and Safety, Patient Rights and Confidentiality, Infection Control and Health Insurance Portability and Accountability Act (HIPAA).       Internal ID: 2853660Indy Star. Category:Healthcare, Keywords:Healthcare Accreditation Coordinator, Location:Greenfield, IN-46140",
			Company = "Hancock Regional Hospital",
			City = "Greenfield",
			State = "IN",
			PostedDate = new DateTime(2020,1,18),
			MinimumSalary = 90000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "5cc007be13ff96c9bff91fbe77b365aa",
			Title = "Jr. Dynamics CRM Developer",
			Description = "Job Description At least 3 years of experience in creating requirement specifications based on Architecture/Design /Detailing of Processes At least 2 years of experience in Microsoft Dynamics CRM Online Experience At least 4 years of experience in Development/ Configuration/solutions evaluation/ Validation and deployment Excellent Analytical and Communication skills Leading or participating in the design and architecture sessions with the clients, gathering and documenting business processes and requirements for the project Good knowledge of CRM?s interoperability capability with MS Office, MS Office 365, SharePoint, Azure and MS BI Stack ? C#/VB.net, ADO.Net, XML, T/SQL, JQuery, JavaScript, Web Services, ASP.NET, and Silverlight skills Regularly communicating with the customer on the status of the issue resolution or Project. Well Versed with Agile practices . Excellent, understanding of MSCRM architecture and its interaction with other interfaced systems in the client environment Experience in defining new architectures and ability to drive an independent project from an architectural standpoint Understands and can articulate best practices related to application enhancements/customizations, integration with other applications Experience on Dynamics Marketing, ADX Portal, Parature, Social Engagement and Operations is optional At least 3 years of experience in thought leadership, white papers and leadership/mentoring of staff and internal consulting teams Experience and desire to work in a management consulting environment that requires regular travel At least 3 years of experience in Development/ Configuration/solutions evaluation/ Validation and deployment At least 3 years of experience in capturing requirements related to internal/external consulting, documenting, and mapping current business process. Analytical and Communication skills Planning and Co-ordination skills Experience with project management Experience and desire to work in a management consulting environment that requires regular travel Qualifications Bachelor?s degree from an accredited institution. Will also consider three years of progressive experience in the specialty in lieu of every year of education. ?At least 7 years of experience with Information Technology. U.S. Citizenship Required (No Green Cards) ? ? Job Summary Location Washington, DC Posted 10 Days ago Reference code 12949861",
			Company = "ClearFocus Technologies",
			City = "Washington",
			State = "DC",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 53000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "4bc9322a58b3cd384a3f819da91a025c",
			Title = "IT Project Manager (Telecom Billing)",
			Description = "Sr. Project Manager:   Manage all facets of large scale, cross functional technical     projects with broad scope to ensure deliverable are met within     schedule, budget, and quality goals  Provide IT Project Management Office leadership to define and     track execution of tasks associated with managing several     large-scale network and data migration projects  Work well managing many moving parts across the highly matrixed     organization including Service Delivery, Order Management, Billing     and Network Provisioning  Interface with key business leaders and senior executives to lead     working teams from within the PMO to manage work across multiple departments  Analyze critical dependencies, define and communicate key     milestones, and manage supporting roles and responsibilities for the     PMO in developing, executing and managing the project plans  Tracking program deliverable and milestones for cross-functional     teams; managing program level risk and issue coordination; work with     Line of Business Project Managers to review actions and detailed     activities in support of project objectives  Ability to manage multiple assignments. Superior written and oral     communication skills  Telecom billing migrations project management is a plus  Manages core team meetings across IT application teams and/or     business teams. - Maintains and updates CA Clarity and     Jira/Confluence applications with project status and documentation  Experience in managing projects with Agile/scrum/SAFe     methodologies and tools  Strong background in Tier 1 telecom and hands on experience with     enterprise and wholesale billers, rating systems, cycle processing,     fraud detection, taxing and associated terminology  Functional knowledge of Telecom Billing and Technical knowledge of     Singleview billing Experience",
			Company = "Prodapt North America",
			City = "Basking Ridge",
			State = "NJ",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 64000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a9e802b2399c82fcac33b3c339fbe71e",
			Title = "English Proofreading with Proofit",
			Description = "Proofit is searching for freelancers! We are looking for people who are passionate about writing, language, and improving communication. Our proofreading service comes to you from Grammarly, the company behind the AI-powered digital writing assistant. Grammarly is a fast-growing organization that every day helps more than fifteen million people communicate clearly, effectively, and error-free when writing in English. Proofit uses teamwork and collaboration to correct and return error-free documents to our customers in an exceptionally timely manner. About you: You demonstrate full command and understanding of English grammar, punctuation, and mechanics. You continuously learn and apply Proofit's guidelines and communicate with other team members to ensure high-quality proofreading. You are punctual, willing to work at defined times, and have a stable internet connection. What does this opportunity mean for you? - GUARANTEED WORK ? No waiting for projects! Our unique system and growing customer base mean we always have work for you. - FLEXIBLE SCHEDULE ? Find the times that are best suited to your lifestyle. - COMPETITIVE COMPENSATION ? Our pay scale ensures rates based on location, ability, and performance. - TEAM ATMOSPHERE ? Work directly with your colleagues to ensure consistent quality in an environment that is more social than standard freelancing. - HELP PEOPLE AROUND THE WORLD ? Proofread documents that come directly from our customers across the globe. They value what you do! If you meet our initial criteria, you can expect to hear from us within a couple of business days, and we?ll follow up with some materials to help further assess your qualifications. We would like to mention that Proofit partners with its proofreaders through Upwork (a global freelancing platform). Upwork charges its freelancers a 5-20% service fee on the rate we offer to our proofreaders. This sliding service fee drops the longer we partner together. If you have any questions or comments, let us know when you apply. We would also like to kindly request that you update your location information on your WayUp profile. If your location details are not up-to-date, this may impact your application later on in the assessment process. Thank you and we look forward to hearing from you! Job Summary Location Edmond, OK 73034 Posted Today Reference code 9019_18879679-2687-41a1-b435-1fadfd77be9c",
			Company = "Grammarly",
			City = "Edmond",
			State = "OK",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 34000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "814e4cf647315b76f93f2fcf38989b09",
			Title = "Medical Assistant II",
			Description = "MEDICAL ASSISTANT II  Job Description  Job Title:MEDICAL ASSISTANT II  Company Name:El Centro Regional Medical Center  Employment Type:Full Time  Location:EL CENTRO, CA, United States  Department:OUTPATIENT ONCOLOGY & HEMATOLOGY  Salary:Highly Competitive  Shift Hours/ Days:M-Th  Shift Details:10 hour shifts  Hours/Pay Period:80  Degree Required:M.A.  Job ID:7190-1-2019-02386  Date Posted:Nov 19, 2019  Years Experience:2  Location:Hospital Campus  Job Categories:Nursing  Note:  Please read the complete description below before applying for this job.  Complete Description  The Medical Assistant II is responsible for the coordination of all vaccine management activities including ordering, receiving and storing vaccines and monitoring vaccine temperatures by logging them appropriately and/or The Medical Assistant II is cross-trained and performs front office functions as a regular and ongoing responsibility.  Working in the capacity of such front office positions as Patient Services Associate or Referral Coordinator a minimum of 25% and a maximum of 50% of their total work hours per month.  The Medical Assistant II is also responsible for assisting physicians and other allied health care professionals with procedures on adults and children such as, preparing medical records, urinalysis testing, audiograms, measuring distance vision testing, etc. Answers telephones, schedules follow-up appointments and typing of vital signs, etc. into the electronic medical record (EMR).     High School Diploma or equivalent; and    Basic Life Support (AHA); and    Successful completion of a Medical Assistant Course; and    Certification of competency (indicating training completed for ten (10) clock hours of training in administering injections and performing skin tests); and    Successful completion of the Competent Translator Certificate by ECRMC Education Department.",
			Company = "El Centro Regional Medical Center",
			City = "El Centro",
			State = "CA",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 56000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Communications"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "feff94296c5b375a532389eeeb24afd0",
			Title = "Coder I - Coding",
			Description = "Monday - Friday, 24 hours per week Primarily focuses on coding of moderate complexity, such as outpatient or inpatient evaluation and management and minor procedures. PRIMARY RESPONSIBILITIES Manages assigned charge review and coding-related claim edit work queues to ensure timely and accurate charge capture. Accurately deciphers charge error reasons and plans follow-up steps. Identifies all billable services. Reviews all applicable data sources, including but not limited to, electronic health record, inpatient admit, discharge and transfer (ADT) reports, operative logs (aka Op Logs), nursing home visit documentation, procedure reports generated from non-the electronic health record systems, etc. Reviews medical record documentation in the electronic health record and/or on paper. Identifies, enters and posts CPT-4 and ICD-10 codes to the electronic health record. Identifies need for medical records from outside the organization and follows established procedures to obtain. Ensures all coded services meet appropriate Medicare, National Correct Coding Initiative (NCCI) or payer-specific guidelines. Consults with physicians/ providers as needed to clarify any documentation in the record that is inadequate, ambiguous, or unclear for coding purposes. Provides education around documentation improvement for maximum patient care. Assists physicians/providers with questions regarding coding and documentation guidelines. Provides ongoing feedback based on observations from coding physician/provider documentation. Identifies opportunities for education and communicates trends to leaders. Reviews and resolves charge sessions that fail charge review edits, claim edits, and follow up denials. Works to improve billing based on findings/resolution of errors. Is watchful for charge review, claim edit, and coding-related denial trends and shares trends with supervisor, managers, and team members to facilitate root cause analysis and continuous process improvement. Manages assigned charge review, claim edit, and coding follow up work queues. Performs other duties as assigned. EDUCATION High school diploma or equivalent EXPERIENCE One year experience SSM Health complies with applicable Federal civil rights laws and does not discriminate on the basis of race, color, national origin, age, disability or sex Job Summary Location Oliver, WI Posted 8 Days ago Reference code 2365_b50d91ae8cfca4703c85e9c635cb6ebe",
			Company = "SSM Health",
			City = "Oliver",
			State = "WI",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 53000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "87f2e3b9bbdd78b5698354b329a1f4d8",
			Title = "Research Manager",
			Description = "The University of Massachusetts Donahue Institute (UMDI) Applied Research and Program Evaluation group (ARPE) is seeking qualified applicants for the position of Research Manager. Research Managers work with the unit director and senior research managers to conceive of and create new projects and develop project scopes, budgets, and project work plans. Research Mangers are responsible for the day-to-day management of assigned projects, including conceptualizing and developing sound research plans and timelines, implementing plans within stated timelines, conducting appropriate quantitative and/or qualitative analyses of data, implementing quality control processes, and synthesizing data to surface findings, and developing high quality project deliverables with clearly stated conclusions and recommendations. Research Managers are expected to possess a solid foundation in research methods, strong verbal and written communication skills, analytical skills, and the ability to independently manage projects or components of complex projects. Research Managers must be comfortable with mixed-methods research approaches, including both qualitative and quantitative research designs. Depending on the size and scope of projects, Research Managers may be responsible for supervising and mentoring staff on their project team, and are expected to foster a collaborative team approach to project implementation. Although not solely responsible for developing new business, Research Managers are expected to identify funding opportunities and participate in development activities.   ARPE conducts social science research projects in direct response to specific client needs. ARPE studies typically focus on questions related to public health, human/social services, and education across the age spectrum (from early childhood through post-secondary and adult education). YourMembership. Category:General, Location:Shrewsbury, MA-01545",
			Company = "UMass Donahue Institute",
			City = "Shrewsbury",
			State = "MA",
			PostedDate = new DateTime(2020,1,9),
			MinimumSalary = 42000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d5052cfa1e7a604a877431a17e9734ad",
			Title = "Wheelchair Supervisor - ATL Airport",
			Description = "Wheelchair Supervisor - ATL Airport( Job Number: ?01SUP) Description ? Position Summary: ? Under the supervision of the station manager or duty manager, the Supervisor is responsible for supervising employees on assigned shifts to ensure that the daily activities are performed safely and efficiently, while also servicing the aircraft to achieve on-time departures. Essential Functions: ? ???????? Supervises and coordinates daily activities of employees to ensure a safe and effective operation. ???????? Monitors and enforces safe working habits in accordance with OSHA/TSA/DOT/USPS regulations, DGS policies and safety procedures, and all applicable laws. ???????? Responsible for shift schedule to include: work station assignments, employee training, employee vacations, employee breaks, overtime assignment, back-up for absent employees, and shift rotations. ???????? Enforces Company policies and procedures, including disciplinary action, and promotes DGS policies on Equal Employment Opportunity, Professional Conduct, and diversity initiatives and investigates and responds to employee relations issues in a timely manner. ???????? Communicates with Manager concerning any problems or issues. ???????? Schedules and conducts shift meetings. ???????? Trains, coaches, counsels and mentors employees in compliance with DGS policies, procedures and practices. ???????? Assists in the administration of payroll; completes shift paperwork and performs other administrative functions. ???????? Performs job duties of assigned shift (i.e., ramp, cabin service, cargo, baggage, passenger service). ???????? All other duties as assigned. ? This description is intended to provide guidelines for job expectations and the employee's ability to perform the position described. It is not intended to be construed as an exhaustive list of all functions, responsibilities, skills and abilities. Particular functions, tasks and requirements may vary or be added depending upon the location and operational requirements. The text on this site does not represent a contract of employment and the company reserves the right to change this job description and/or assign tasks for the employee to perform, as the Company may deem appropriate. Shifts Available 4am-12:30pm 10:30am-7pm ? Primary Location :?United States of America-Georgia-Atlanta Starting Hourly Rate ?16.00 Job Summary Location Atlanta, GA Posted 6 Days ago Reference code 386281",
			Company = "Delta Air Lines Global Services",
			City = "Atlanta",
			State = "GA",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 32000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "8223040794b93373dc280026300a0cf9",
			Title = "Restaurant Manager, Glendale, AZ",
			Description = "Overview At the direction of the General Manager, oversee the day-to-day activities of the restaurant. Assists the General Manager with developing and implementing plans to ensure the long-term success of the restaurant.? Maintains optimal execution of daily operations. Responsible for leadership of PAR hourly staff. Provides and promotes elevated customer service. ? ? Responsibility Ensures proper implementation of all operational policies and procedures. Guarantees consistency of delivering fresh, high quality food that has been prepared in a proper manner. Ensures high standards of quality control, sanitation, health, and safety as established by industry standards and laws. Arranges to have equipment repaired or maintained. Accurately estimates quantity and ensures preparation of food and beverage necessary to meet daily demands while minimizing waste. Ensures optimal operation of the restaurant during scheduled shifts. Schedules staff work hours and ensures that peak dining hours are optimally covered. Maintains appropriate records and reporting as required by Corporate Office. ? Maintains a diverse and motivated PAR hourly staff that will achieve and maintain high standards of operation and exceptional guest experiences. Retains top talent and promotes a positive environment by developing restaurant employees through ongoing training, modeling, and providing outstanding leadership. Responsible for every aspect of the hiring process for all employees. Completes and maintains performance reviews and other required personnel records. ? Achieves and maintains a high level of customer service and ensures customer issues are quickly and efficiently resolved. Dedicated to providing the best possible experiences for our guests. Takes responsibility for upholding Cracker Barrel Old Country Store customer satisfaction reputation. Qualifications High school diploma and 2 years restaurant operations experience; or equivalent combination of education and experience. College classes or degree in Business, Hospitality, or related field preferred but not required. ? In-depth knowledge of restaurant operations. Basic knowledge of accounting practices, principles, and profit and loss factors. Excellent social intelligence and interpersonal skills. Supervisory skills. Excellent communication skills. Excellent team-building skills. Job Summary Location Glendale, AZ 85305 Posted Today Reference code 8433_10854",
			Company = "Cracker Barrel",
			City = "Glendale",
			State = "AZ",
			PostedDate = new DateTime(2020,1,26),
			MinimumSalary = 44000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a3e50a1f0132c796e4e6609060dec982",
			Title = "Production Assistant",
			Description = "Assistant Baker Wanted!      Do you love good food and are mindful of what you eat?   Do you enjoy eating cookies???   Do you love supporting local businesses??   Do you want your work to matter?   Do you value hard work??   Do you want to be part of a team and not just an employee?   Are you accurate at math, can scale recipes easily?   Are you detailed and efficient while maintaining high quality standards?   Does a drama free workplace with happy, sometimes sarcastic, hardworking and occasionally silly teammates get you pumped????      If you answered heck yea - then keep reading!      Blue Moon Bakery is looking for an entry level bakery helper, to help with production for our wholesale accounts, special orders and farmers markets.? You will be an important part of our small growing team and must be hard working, punctual, reliable, clean, efficient, able to multi-task, and detail oriented - especially detail oriented while being efficient.??      Responsibilities will include:? packaging while maintaining quality control, dish washing, accurately follow bakery specs and recipes, mixing, scooping, rolling, standing for long periods of time, doing repetitive work, able to lift 50lbs, work independently and with our team members.????      Working in a production bakery can be so much fun but it is also very repetitive, physically demanding and requires attention to detail while working quickly.? Did we mention the repetitiveness?!      If you think you?d be the perfect fit AND are excited to join our team, send us your resume with cover letter writing ?I love cookies? on the first line of your cover letter.? Tell us why you?d be a good fit with our team and what things you love to bake or want to learn to bake.      Position is long term and has the potential to advance as we grow.??      Part-time, 18-24 hours per week, Tues-Friday 8-2pm with a few early morning shift throughout the month.? Wage, $13+",
			Company = "Blue Moon Bakery",
			City = "Hillsboro",
			State = "OR",
			PostedDate = new DateTime(2020,1,5),
			MinimumSalary = 82000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d93520c8ad3fa636a4295eaa6735ab2f",
			Title = "School Psychologist",
			Description = "Make a difference in the lives of children! Staff Rehab is in need of a qualified School Psychologist for a position in Fairfield, CA. This is a full-time position to start ASAP-June 12, 2020. 37.5 hours per week, prek-12th grade. Become a part of one of the Inc 5000s fastest growing school staffing companies, guaranteeing the longevity of your career by ensuring you have access to all of the training and career development resources to be the best you can. We are offering fantastic pay plus benefits for this contract and would love to discuss details with you at your convenience.   Requirements of a School Psychologist:  *A passion for working with pediatrics  *State of California School Psychologist License  *Must be able to provide proof of current TB Test (within 1 year)  *Requires Mandated Reporter Training Certificate     Perks and Benefits for the School Psychologist:   *Medical, Dental, and Vision Benefits  *401K  *$750 Continue Education Units (CEU) Reimbursement  *Paid Time Off & Holiday Pay  *Mentoring and dedicated support on staff  *$5,000 loyalty bonus at 10 year anniversary  *$750 referral bonuses     Staff Rehab is privileged in representing the very best candidates and carries one of the most highly respected names in rehabilitation services. As a member of our team, you are provided a benefits package (medical, dental, and vision) with outstanding coverage for those who elect to participate. Our knowledgeable staff members provide an unparalleled support system. Are you ready to make a difference?   Testimonial: ?I've been working for Staff Rehab for a year and all I could say is that I love the company. Since day one they have been supportive. If you ever email or call them they will respond to you within a few hours or right away. They care about their employees. They offer GREAT benefits.?   Staff Rehab is an Equal Opportunity Employer, drug free workplace, and complies with ADA regulations as applicable. ",
			Company = "Staff Rehab",
			City = "Fairfield",
			State = "CA",
			PostedDate = new DateTime(2020,1,9),
			MinimumSalary = 91000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "f81e785ce210cd258b60412040b9235e",
			Title = "Backend Engineer",
			Description = "Backend Engineer Reports to: CTO  Classification: Full Time, Exempt  Salary Range: $110,000 - $160,000 (Annual)  Who and/or what is U.GG? U.GG is an incredibly fast growing gaming analytics platform with unbelievable engagement and stickiness. Our users are provided with data-driven recommendations that enable them to overcome the meta-information barrier that blocks millions of video game players from playing online games at an optimal level. U.GG addresses the need of hundreds of millions of people facing an ever increasing complexity and always changing nature of multiplayer video games.  Position Summary U.GG is looking for a Backend Engineer who will be responsible for expanding the capabilities of our backend services. The primary focus of this position will be implementing flexible and powerful service layers, while also extending the capabilities of our existing services.  Our Stack The core technology is Elixir, Phoenix, Express, Elasticsearch, and DynamoDB on AWS. We are globally distributed, with a large emphasis on utilizing CDNs and locally available clusters to efficiently serve our global user base.  Responsibilities     Propose, design, and implement improvements to our proprietary data engine      Extend, improve, and own many different services; the areas of project may include data processing, predictive search, server sided rendering, GraphQL API, and more.   Minimum Qualifications     B.S. in Comp Sci/Comp Engineering or equivalent experience      2+ years industry experience designing and building consumer software and/or developer systems      Experience developing services in Elixir or similar software languages      Knowledge of distributed systems   Bonus Qualifications     Full stack experience - front-end, back-end, infrastructure, and/or more      Experience interfacing with NoSQL databases      Strong background in systems design      Knowledge of map-reduce",
			Company = "U.GG",
			City = "Austin",
			State = "TX",
			PostedDate = new DateTime(2020,1,8),
			MinimumSalary = 80000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "fdc24a3a0ff407ee0c7c028b5152f026",
			Title = "Advanced Analyst/Developer",
			Description = "Company Overview General Mills is reshaping the future of food. We believe food makes us better. It nourishes our bodies, brings us joy and connects us to each other. As one of the worlds leading food companies, General Mills operates in more than 100 countries and markets more than 100 consumer brands, including Cheerios, Nature Valley, Betty Crocker, Yoplait, Annies Homegrown, Old El Paso, Epic Provisions, Blue Buffalo and more. Are you passionate about the future of food? Youve come to the right table. We want the very best talent to help lead something big. Responsibilities The Warehouse Management team provides centralized business process support and system and process design expertise to GMI Supply Chain Warehousing business partners throughout North America. Members of this team provide important leadership in connecting supply chain processes across GBS and business teams to ensure that end to end processes align with business strategy and deliver against business objectives. ? RESPONSIBILITIES Develop technical and functional expertise in Supply Chain Warehousing Lead the design and development of solutions for supply chain projects, including RedPrairie Warehouse Management, SAP and other technologies/solutions. Provide first class service and support of existing processes & systems Advise business partners engaged in merger, acquisition, and divestiture projects Connect with IT and business peers to ensure end to end solution optimization Support the startup processes of new lines, plants, contract manufacturers, and customer service facilities Qualifications MINIMUM QUALIFICATIONS Bachelor's Degree in CIS (Computer Information Systems), MIS (Management Information Systems), or related field Business systems analyst experience strong mix of technical and functional skills Excellent analytical and problem solving skills Effective interpersonal and communication skills (written and oral) Demonstrated ability to partner with business and design technical solutions Continuous Improvement strong curiosity to find root cause, drive out waste and identify synergies Project Management - self managing, results oriented, can manage multiple priorities ADDITIONAL PREFERRED QUALIFICATIONS RedPrairie Warehouse Management or other WMS experience SAP / ABAP and SAP module experience e.g. SAP TM, SAP MM Job Summary Location Minneapolis, MN 55400 Posted 1 Days ago Reference code 2365_49d0cdc61df2992e0a135618d129ceec",
			Company = "General Mills Services, Inc.",
			City = "Minneapolis",
			State = "MN",
			PostedDate = new DateTime(2020,1,29),
			MinimumSalary = 35000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "3233e3c5ba23ddce6c719502bc2e21b0",
			Title = "Conference Manager/Project Manager",
			Description = "AnaVation is seeking a Conference Manager/Project Manager with experience supporting Department of Defense (DoD) technical meetings and conferences. The Conference Manager/Project Manager will oversee the lifecycle of event planning and execution to include budget development, managing a support team, allocating necessary resources, site identification and selection, agenda development, speaker coordination, preparation of presentations, and conference/meeting materials for both print and website dissemination, registration and onsite event support, committee membership activities, and close-out reporting for multiple concurrent events. This is a fast-paced environment where multi-tasking and changing priorities are the norm. The ideal candidate is highly self-motivated, has a positive attitude, professional, organized, and capable of managing their workload and prioritizing tasks. Qualifications Required: Must have interim or active DoD Secret clearance College degree (Bachelors or Associates) and 5+ years' experience in planning and managing conferences, workshops, tradeshows, and events with attendees ranging from 15 to 500+ people; an additional four years experience can be substituted for degree A strong attention to detail and follow-through Excellent verbal and written communication skills Excellent organization and time management skills Experience supporting at least 4 concurrent conferences on an annual basis Experience managing a staff of conference planners and support team Experience developing and tracking budgets and profit Experience managing and allocating resources Experience in developing project management tools and documentation Experience in creating, editing, and proofing meeting materials Experience in registration management Venue and third-party vendor coordination and contract negotiation Ability to take meeting notes and capture and track action items Proficient in use of Microsoft Office Suite (Word, Excel, PowerPoint, Outlook) Ability to lift and assemble/disassemble displays and the ability to lift heavy boxes (up to 25 lbs) of conference/collateral materials Some local and long-distance travel required ( Preferred: Previous experience working in a military environment a plus Experience supporting classified meetings CMP or CGMP certifications PMP certification Top Secret clearance Job Summary Location Chantilly, VA 22021 Posted 5 Days ago Reference code 2365_8838b689d1eb31a70e936dde915d4bae",
			Company = "AnaVation LLC",
			City = "Chantilly",
			State = "VA",
			PostedDate = new DateTime(2020,1,31),
			MinimumSalary = 80000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "3bcf98f0d0e32c68ca140eef6d9d0ab6",
			Title = "Assistant Manager",
			Description = "Have you ever envisioned leading a team to success or dared to help manage a great private business? Well, here is your opportunity to take on the challenge! Put your team-building skills to the test and bring us your commitment, passion, energy and excellent interpersonal skills. We will provide you with a thorough training program, great mentors and an exceptional team that will help you launch your career with us. Requirements (our ideal candidates will possess): Experience: Must have Shift Leader or have 2-4 years of supervisory experience, preferably within a restaurant environment. Familiarity with Point-Of-Sale systems is desired. Education: High school diploma or equivalent (GED) preferred. Communication: Excellent written and verbal English communication skills (second language a plus) Competencies: Basic math and computer skills, and strong interpersonal and conflict-resolution skills Driving/Vehicle : Must be at least 18 years old and possess a valid drivers license and a reliable vehicle that may be used for company business. Food Handler Card: Must have a Serve Safe Certificate at time of hire or obtain a Serve Safe Certificate and complete the Togo?s brand courses upon hire, where applicable. Job Details: Work Hours: Part-Time schedule, and may be required to work any shift including opening, mid-day, and closing. The great news is that our restaurant is not open 24 hours! Career Advancement/Career Plan: We promote heavily from within, so from an AM you can develop to become an expert Sandwich guru, General Manager and a Director of Operations. Work Attire: Be an example, lead by professional restaurant attire. Cap, apron, brand logoed shirt will be provided, and clean dark jeans (no holes or rips or design) and closed toe/no-slip shoes are required. Job Description: Supervising assigned shifts, and provides supervision to crew members in the absence of the General Manager Training and developing crew members Completing administrative tasks (e.g. financial and inventory control, schedules, logging maintenance, etc.) Creating and ensuring exceptional guest experiences Ensuring compliance with all security, food safety, quality, and cleanliness standards Maintaining cost controls and contributing to the sales/profit goals Building your skills and leveraging the available tools to prepare yourself for a future General Manager role Job Summary Location Emeryville, CA 94608 Posted 1 Days ago Reference code 3274_2123358",
			Company = "TOGO's Sandwiches",
			City = "Emeryville",
			State = "CA",
			PostedDate = new DateTime(2020,1,26),
			MinimumSalary = 94000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "5548c2ef51937755c77f0c914801d979",
			Title = "Pharmacy Technician part-time",
			Description = "OPPORTUNITIES WITH GENOA HEALTHCARE. A career with Genoa Healthcare means you're part of a collaborative effort to serve behavioral health and addiction treatment communities. We do more than just provide medicine: we change lives for the better. People with serious mental or chronic illness - and those who care for them - have moving stories, and at Genoa we become their voice, their partner. Working as part of a coordinated care team, we partner with community-based providers and others to ensure that people with complex health conditions get the right medications and are able to follow their treatment plans. Our personalized services - in-clinic pharmacies, telepsychiatry and medication management - are leading the way to a new level of care. We recently joined OptumRx, a pharmacy care services company that is part of Optum and UnitedHealth Group's family of businesses. We are part of a leading information and technology-enabled health services business dedicated to making the health system work better for everyone. Take a closer look to learn why a career with Genoa Healthcare might be the path to discovering YOUR LIFE'S BEST WORK. SM We seek a PART-TIME (20 HOURS OR 2.5 DAYS A WEEK) PHARMACY TECHNICIAN (ROTATING SCHEDULE, MUST HAVE MONDAY - FRIDAY 8:00-4:30 AVAILABILITY) to support all functions of the Genoa mental health pharmacy, primarily through dispensing medical prescriptions, and performing necessary clerical duties while under the direct supervision of a registered pharmacist. MAJOR DUTIES & RESPONSIBILITIES: - Provide exceptional customer service to all patients and members of the clinic staff - Under direct supervision of the registered pharmacist, fills prescription orders and makes them available for verification by the Pharmacist. Once verified by the pharmacist, dispenses the prescriptions. - Order, receive and store incoming pharmacy supplies. - Receive and process wholesaler medication orders. - Verify medication stock and enter data in computer to maintain inventory records. - Help maintain a clean organized work environment. - Perform various clerical duties relating to the department. - Work with the pharmacist to assist in the pharmacy functions and keeping the pharmacy in compliance with all federal and state requirements. - Occasional medication delivery to consumers. - Other Duties as assigned Job Summary Location Huntington, WV 25775 Posted Today Reference code 9019_21eaacfa-df3b-428e-9b52-1ba7e7039f9a",
			Company = "UnitedHealth Group",
			City = "Huntington",
			State = "WV",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 59000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d941d92474eb6efcbf09fc0561401f3d",
			Title = "LPN",
			Description = "Primary Care Solutions provides industry-leading Primary Care services to Veterans. Veteran-led and clinician-managed, we deliver compassionate, expert medical care, establishing personal bonds with our Veterans in our Community Based Outpatient Clinics (CBOCs). We have consistently achieved high marks from the VA in our CBOCs, and we are excited to discover first-rate colleagues to join our group. ? *This position is open in various VA locations across the country. ? RESPONSIBILITIES As a Licensed Practical Nurse, you will be responsible for providing a friendly, welcoming, and confidential environment for our Veterans who have served our country valiantly. We are seekinghealthcare professionals who are driven and committed to ensure the health and well-being of our nations Veterans. ? Office hours are M-F 8 to 4:30. No On-Call! No evening or weekend work! No holidays! Interviews patients, measures vital signs, and records information in patients electronic medical?record Obtain medical histories from patients; verify patient information Prepare, assist, and accurately complete all forms Administer medications and operate diagnostic equipment Assist providers during examinations and treatment Take vital signs and perform all ancillary tests appropriate to skill level, certifications and state regulations Perform ancillary testing and tasks as ordered by the Center Medical Director (PFT, EKG, injections, audiograms, blood draws, etc.) and as certified Collect lab Specimens from patients and submit received results to medical providers Complete all clinical reminders Answer and return patient telephone calls, messages and alerts ? JOB REQUIREMENTS: High School Diploma/GED? Graduate of an accredited certificate program Current and active State Nursing License Knowledge of computer systems to include the MS Office Suite Two years?of continuous experience in clinical operations Basic Life Support certification from American Heart Association ? BENEFITS SUMMARY: 401(k) Medical/Vision/Prescription/Dental Plans Life Insurance/Disability Paid Time Off/Holidays Colleague Referral Bonus Program ? This job requires access to confidential and sensitive information requiring on going discretion and secure information management. ? If youre looking for an organization that cares for your growth and well-being as much it does its patients, Apply Today! Job Summary Location Espanola, NM Posted Today Reference code aba707db-68f4-4427-8997-134227301007",
			Company = "Primary Care Solutions",
			City = "Espanola",
			State = "NM",
			PostedDate = new DateTime(2020,1,30),
			MinimumSalary = 39000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "fdd011d4f8c669d23d186ddd9d701244",
			Title = "Scientific Technical Writer - Pharmaceuticals",
			Description = "Why a Great Opportunity  We are looking for a Scientific Technical Writer who will be responsible for producing accurate, clear, and interesting content for manuscripts, reports, and presentations. ?This candidate will apply scientific principles and biomedical knowledge to understand, organize and describe complex data for scientific, medical, and lay audiences. The Technical Writer coordinates input from a multi-disciplinary team while meeting tight deadlines.   Job Description   Scientific Technical Writer Responsibilities:    Helps write and proofread key marketing or scientific documents.  Translates study data and results into presentations, reports, scientific journal manuscripts, and abstracts for publication.  Maintains familiarity with relevant research, conducts literature reviews, and manages references.  Formatting manuscripts and references in the correct order for specific journals.  Assists with the design, development, and selection of scientific illustrations, tables, and figures.  Submits manuscripts and tracks manuscript status from conceptualization through publication.  Manage updates and revisions to technical literature.  Ensure timely production of high-quality documents for publication in journals or presentation in meetings and of other written communication material supporting company brands, research activities, and business needs.  Review work done by team members and provide appropriate feedback.  Performing other assigned duties that may be required in meeting company goals and objectives    Qualifications   Scientific Technical Writer Qualifications:? ?   Bachelor's Degree required and a minimum of 2 years Medical/Scientific publication.?  Must possess excellent writing and verbal skills.?  Efficient in reviewing and editing technical documents.?  Strong functional proficiency using Windows, Word, Excel, and PowerPoint.   ?   Scientific Technical Writer Benefits:    This position provides full benefits and relocation expenses",
			Company = "NPAworldwide Recruitment Network",
			City = "Lancaster",
			State = "SC",
			PostedDate = new DateTime(2020,1,2),
			MinimumSalary = 65000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Communications"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "ded82224573cdeda8e1c045f060ce28e",
			Title = "Private Client Services Tax Manager",
			Description = "Job Summary BDO's Core Purpose is Helping People Thrive Every Day. Our Core Values reflect how we manage our work, our relationships and ourselves. As an employee of the firm, you will live true to our Core Values of people first, being exceptional every day in every way, embracing change, feeling empowered through knowledge and choosing accountability. Our Core Values are the standards by which we conduct ourselves day in and day out, both internally and externally. The Private Client Services Manager assists in providing tax compliance and consulting services to our high net worth clients. Significant knowledge of taxation related to personal income, estate and gift taxation and wealth retention strategies, as well as taxation of entities owned by business owners (partnership and corporate taxation), is required. Qualifications Education: - Bachelor's degree in Accounting or other relevant field required - Masters in Accounting or Taxation, JD or LLM preferred Experience: - Five (5) or more years of public accounting and private client services experience required - Public accounting experience working in the private client service area preferred License/Certifications: - CPA required - CFP, CFE or Masters in Tax preferred Software: - Experience with Gosystems, GoFileRoom and BNA Tax Planner preferred - Experience with the Microsoft office suite required Other Knowledge, Skills & Abilities: - Excellent oral and written communication skills - Detailed oriented - Strong analytical, research and critical thinking skills - Solid organizational skills, especially the ability to meet project deadlines with a focus on details - Ability to successfully multi-task while working independently or within a group environment - Proven ability to work in a deadline-driven environment and handle multiple projects simultaneously - Ability to interact effectively with people at all organizational levels of the firm - Basic knowledge of fundamental accounting, finance and tax principles - General accounting knowledge and basic to intermediate tax knowledge - General understanding of financial planning concepts - Ability to effectively delegate work - Capable of effectively developing and maintaining client relationships - Executive presence and ability to act as primary client contact for preparation and presentation of issues and resolution to clients Job Summary Location El Paso, TX 88568 Posted 14 Days ago Reference code 2365_7df3ba4ec4428a9d91aed7be781d2420",
			Company = "BDO Seidman LLP",
			City = "El Paso",
			State = "TX",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 33000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "f419db82d8e2e53e165c77c9f17e71b9",
			Title = "Chief Medical Officer (CMO) - FQHC - Minnesota-153373",
			Description = "COMPENSATION AND BENEFITS Chief Medical Officer (CMO)  ? $250,000+ Annually ? Loan reimbursement available ? Benefits - All standard benefits plus retirement ? Up to 30 days of PTO plus another week for CME ? Sign-on and relocation negotiable ? Paid Malpractice  RESPONSIBILITIES AND FACILITY DETAILS Chief Medical Officer (CMO)  ? 60/40 Administration to Clinical. Could flex to 50/50 ? 16-20 patients per day ? Excellent support staff and wonderful administrative team - Incredible culture ? Monday-Friday schedule with flexibility ? 1:4 call schedule. Less than 100 calls a year ? CMO will be crucial in many key decisions moving into the new year and beyond. The doors that will open with this position will be abundant!!  QUALIFICATIONS AND SKILLS Chief Medical Officer (CMO)  ? Board Certified not required but preferred. Must be Board Eligible and have the intention of certification ? Experience with FQHC?s or in rural medicine is highly preferred  COMMUNITY Chief Medical Officer (CMO)  ? Center City population of 43,000 with an overall population of 102,000 ? Division-1 University Community with exceptional amenities and affordable housing options ? Voted #2 of the ?Best University Communities in America? by Schools.com ? Recognized by Thrillist as one of the ?Top 14 Coolest Urban Spaces in America? ? Great Parks and Lots of Family Activities ? Dynamic Economy and Beautiful Landscapes  REFERENCE NUMBER: 153373  ABOUT DELTA PHYSICIAN PLACEMENT  Delta Physician Placement (DPP), the permanent staffing division of The Delta Companies, identifies qualified Physicians, Advanced Practitioners, Allied Health, and Therapist on behalf of healthcare facilities nationwide. A single point of contact assists you with coordinating communication with the hiring manager, negotiating contractual details, and coordinating any necessary travel. The company has been recognized with several Best of Staffing? Awards. Visit www.deltaplacement.com for more information.",
			Company = "Delta Physician Placement",
			City = "Rochester",
			State = "MN",
			PostedDate = new DateTime(2020,1,15),
			MinimumSalary = 66000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "2014d3cba1e9baac6c16b5925b6932d3",
			Title = "Internal Coding Auditor",
			Description = "Overview Atlantic Medical Group's Coding and Compliance Department is currently seeking an Internal Coding Auditor with ortho experience. Responsibilities Reports to the Manager of Coding/Compliance and Director of Coding and Compliance. This position is responsible for maintaining the integrity of the documentation and coding of the Atlantic Health System record. This involves performing in-depth work flow assessments of all clinicians affiliated with Atlantic Medical Group and advising and educating the providers of said findings in order to achieve desired outcomes and compliance with Atlantic Health System policies, procedures, and standards.? ? Essential Functions: The Internal Coding/Compliance Auditor 1 will perform coding quality audits of all records (outpatient, inpatient, procedures, testing) to assure appropriateness and accurate code assignments in accordance with Center of Medicare and Medicaid (CMS) guidelines and provide ongoing feedback and analysis of the education needs for the providers and staff. The auditor will also be responsible for providing assistance with coding inquiries from providers, charge posters, billing staff, etc. ? Qualifications Education: High School Diploma required Qualifications/Requirements: Minimum one year ortho coding experience and CPC (member AACP) required. Extensive knowledge of federal, state, regulations and policies pertaining to documentation, coding, and compliance Ability to analyze and identify opportunities in documentation improvement Maintain confidentiality of client and departmental information Knowledge of medical terminology Knowledge of CPT, ICD-10, and HCPCS coding Knowledge of Medicare and Medicaid regulations Atlantic Health System aims to deliver the highest quality, safety and care combined the best experience for our patients and their families. We are confident that you will find success within Atlantic Health System, which has been named for the 11th year in a row to Fortunes Top 100 Best U.S. Companies to Work For list. We believe youll find that our culture of collaboration and care exemplifies the value we place on our patients, their families and our employees. ? All qualified applicants will receive consideration for employment without regard to race, national origin, religion, age, color, sex, sexual orientation, gender identity, disability, or protected veteran status. Job Summary Location Morristown, NJ 07961 Posted 9 Days ago Reference code 2365_ecb9daf7e2889ef5afb2f88667a37724",
			Company = "AHS Hospital Corp.",
			City = "Morristown",
			State = "NJ",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 78000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "9524fda89540aa05eb17c6773eea9104",
			Title = "Ultrasound Tech",
			Description = "Performs ultrasound procedures under the direction of a Radiologist. Responsible for mentoring and training students in a cooperative learning environment.    Prepares patient for examination.    Performs Ultrasound procedures according to professional standards and policies.    Reviews images, documents completion of case, assembles images, requisition and file jacket for delivery to Radiologist.    Education:  High School Diploma Or Equivalent  Additional Educational Requirements  Graduate of an AMA approved school for diagnostic sonography.  Work Experience:  Related Experience Preferred  Additional Experience Requirements  Previous experience post-training preferred.  Licenses and Certifications:  ARDMS or ARRT certification or eligibility Required  CPR or BLS Certification Required  Additional Certification/Licensure Requirements  Must maintain CE requirements and CPR certification.  Required Knowledge and Skills:  Strong professional, organizational, and interpersonal skills to effectively relate with all members of the healthcare team.  Working Conditions:  Works in a normal hospital environment with exposure to infectious diseases and radiation. Must rigidly observe monitoring and safety procedures to avoid overexposure to radiation.  Exposure:  Daily potential for exposure to blood and/or body fluids.  Physical Demands:  Sitting  Occasionally   Standing/Walking  Continuously   Kneeling/Stooping  Rarely   Bending/Climbing  Rarely   Reaching above shoulder, at waist or below waist  Frequently   Lifting/Pushing or Pulling up to 40 pounds  Occasionally   Lifting/Pushing or Pulling over 40 pounds  Rarely   Typing/Filing  Rarely   Reasonable accommodations may be made to enable individuals with disabilities to perform the essential functions.  ID: 2019-9962   Primary Shift: Evening   Work Schedule: 1P-9P   External Company Name: CentraState Healthcare System   External Company URL: http://www.centrastate.com/   Street: 901 West Main Street",
			Company = "CentraState Healthcare System",
			City = "Freehold",
			State = "NJ",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 56000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "7122a30773e03ef3a72cb7266d4cffe2",
			Title = "Certified Coding Specialist II",
			Description = "Requires knowledge of and skill in applying International Classification of Diseases and Procedures (ICD), and Current Procedural Terminology (CPT) code sets and associated Medicare/Medicaid rules and guidelines. Reviews and interprets patient medical record documentation to identify pertinent diagnoses and procedures and assigns ICD-10-CM and CPT 4 codes accurately and timely to the highest level of specificity based upon physician documentation for ambulatory surgery, special procedure, observation, emergency department, outpatient ancillary and clinic visit records. Primarily codes a mixture of different types of Evaluation & Management medical records and assists with coding outpatient ancillary clinic, specialty clinic, surgical and emergency room record coding as necessary. Communicates with physicians and other providers regarding documentation requirements and collaborates with different departments on an as needed basis. Maintains current knowledge of coding and documentation changes, rules and guidelines.   Required:    CCS or CPC with (1) year minimum current and continuous full-time ICD-10-CM & CPT-4 evaluation & management coding    Knowledge of medical terminology, anatomy and physiology and the disease process    Ability to work well independently and productively with minimal guidance and supervision    Detail-oriented, organized and flexible with exceptional interpersonal and communication skills    Demonstrates coding skills and critical thinking skills utilizing current policies and procedures    Preferred:    RHIA or RHIT     Knowledge of health insurance processing    Skilled with electronic medical record applications, automated encoders, and other software applications     Licensure, Registration and/or Certification:    Certified Coding Specialist (CCS) required or Certified Professional Coder (CPC) required    Registered Health Information Administrator (RHIA) or Registered Health Information Technician (RHIT) preferred",
			Company = "Cook Children''s Medical Center",
			City = "Fort Worth",
			State = "TX",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 46000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "5ebe149701ed19f8b460979ba31d31aa",
			Title = "Fleet Maintenance Analyst",
			Description = "TrinityRail  is searching for a  Fleet Maintenance Analyst  to work in our  Dallas, Texas  offices. This individual will analyze maintenance expense, repairs and regulatory compliance of railcars within assigned fleets. They will also work with a network of repair facilities to expedite railcars through the repair process and be responsible for network production and performance. Assigned fleets may be customers? fleets and/or a class of Company-owned railcars. They will ensure railcars meet quality, regulatory and utilization standards. #nowhiring     What you'll do:       Analyze shop repair estimates and invoices for accuracy and potential cost savings; approve repairs and ensure all billing and repair practices meet AAR Standards      Analyze the repair network for performance, quality and cost      Respond to and resolve customer inquiries concerning car maintenance, industry regulations, proper car use &amp; basic construction.      Support and adhere to maintenance schedules; expedite work through shops      Prepare and issue shopping instructions for railcar repair and coordinate between customers and repair shops            What you'll need:       Bachelor?s degree in Business, Mechanical Engineering, or related field preferred.      Experience in operations and/or supply chain analyst roles a plus, examples include: applicable degree concentrations/majors, internship or prior job experience      Knowledge of AAR/FRA rules and regulations pertaining to railcar repair/fabrication, maintenance/design, and applicable standards a plus but not required      Ability to interpret and evaluate engineering drawings and regulatory codes      Customer-focused, excellent relationship building skills with the ability to communicate effectively across all levels of the organization      Microsoft Office required including Excel at an intermediate skill level      Additional experience a plus: visualization tools (Qlik Sense, Tableau), CRM (such as Salesforce), Asset Management Systems",
			Company = "Trinity Industries, Inc",
			City = "Dallas",
			State = "TX",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 88000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "dbb35aec480ab138dc908f54a8026111",
			Title = "Vascular Tech- Non-Invasive Vascular- Grandview Medical Center (Nights)- $12,500 Sign On Bonus",
			Description = "Job Description Vascular Tech- Non-Invasive Vascular- Grandview Medical Center (Nights)- $12,500 Sign On Bonus US-OH-Dayton Job ID: 2019-20257 Type: Full-Time # of Openings: 1 Category: Imaging Grandview Hospital Overview Job Summary: The vascular technologist will be capable fo applying techniques and patient positioning to produce high quality ultrasound images. Individuals in this position must be able to exercise initiative, critical thinking and independent judgment. The technologist must be willing to participate in continuing education programs to further upgrade his/her skills. Qualified candidate must have good communication skills, be reliable and travel to Southview Hospital. Educational Requirements: 1. Registered Vascular Technologist certification by the American Registry of Diagnostic Medical Sonographers with a minimum six months full-time clinical experience in Vascular Lab settings (preferred) 2. Registered by the Cardiovascular Credentialing International with minimum of six months full-time clinical experience in Vascular lab settings may be considered 3.. Registry Eligible candidates for RVT credential with twelve months full-time clinical experience in Vascular Lab setting may be considered with Registry status obtained within 6 months of hire date Skills/Other 1. Candidates must show competency in the vascular diagnostic imaging modalities including but not limited to cerebrovascular, peripheral venous and arterial testing, visceral, renal artery, hemodialysis access and peripheral venous mapping 2. Candidates must have good communication skills including extensive knowledge of vascular anatomy and terminology, including vascular hemodynamics and be able to work independently 3. Candidates must be competent in structured reporting **Sign on bonus only eligible to external candidates only **Required commitment of FT status for 18 months **Payable in two installments **Must have at least 1 year of experience Qualifications PM18 PI117100251",
			Company = "Kettering Health Network",
			City = "Dayton",
			State = "OH",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 88000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d5258cb102d8f88c95988a2bb956602d",
			Title = "Executive Director-Bluford HC Leadership Institute",
			Description = "Executive Director-Bluford HC Leadership Institute  Tracking Code  16078-124  Job Description  Truman Medical Centers, a two-hospital, 600-bed, not-for-profit healthcare system, is the largest and most comprehensive safety net healthcare provider in Jackson County and Kansas City, Mo. TMC serves as the primary teaching hospital for the University of Missouri-Kansas City Schools of Medicine, Nursing, Dentistry and Pharmacy. Recognized as a critical area resource for advanced specialized healthcare, TMC is constantly working to deliver the best possible medical care for our patients. Quality, innovation, teamwork and attention to detail are at the heart of all we do. TMCs tagline is: Better. For Everyone. It is a simple statement, but it has profound significance. It is what we stand for, it is the focus of our work, and it is our promise to our patients.   Provides executive leadership for successful event outcomes with the Bluford Healthcare Leadership Institute. Assures that specific plans, programs, activities and systems are initiated and completed, and consistent with Institute objectives. Actively engages in developing and implementing strategic philanthropic programs. Builds and maintains relationships with existing donors and works in pursuit of added donor partners.  Required Skills    Masters degree in public administration, health care administration, business or related fields.    Five to seven years experience in business leadership, fundraising management with demonstrated skills in administration, human relations and communication.    Ability to present ideas, proposals and reports to a variety of groups and individuals, including high profile members of the community    Ability to analyze, interpret and utilize data and relevant business, industry and health care information.    Experience in a healthcare setting preferred.    Job Location  Lakewood, Kansas City, Missouri, United States  Position Type  Full-Time/Regular  Shift Schedule  8:00AM - 4:30PM",
			Company = "Truman Medical Centers",
			City = "Kansas City",
			State = "MO",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 86000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "106a0077cb6d6975401b81d71d9cd88f",
			Title = "Marketing Manager",
			Description = "Position Overview:      The Marketing Manager is chiefly responsible for leading ACI-NA email marketing efforts and providing graphic design support to the Communications and Marketing Department.? Duties include devising and implementing data-driven comprehensive conference marketing campaigns, strengthening membership communication channels, providing graphic design, and developing collateral material in alignment with department needs.    Responsibilities and Duties Include:      Working with the marketing team and conferences team, develop and execute marketing and email campaigns to promote ACI-NA conferences and educational events; create targeted audience lists to effectively reach likely attendees; design creative assets for marketing campaigns.   Develop and implement brand identity and maintain quality standards; support consistent application of association branding standards across all levels of the organization. Provide training as required to support this effort.   Responsible for the development, design, and production of all printed, electronic, and digital communications including, but not limited to reports, infographics, presentations, media relations materials, advocacy collateral materials, membership promotional materials, event marketing and on-site materials, sponsorship materials, web and social media assets, and advertisements.   Oversee development, implementation, and evaluation of ACI-NA Excellence in Airport Marketing, Communications, and Customer Service Awards process, including managing online submission portal, and assist with the setup of other ACI-NA award programs.   Serve as staff liaison for ACI-NA Airport Marketing Working Group, a subset of the ACI-NA Marketing, Communications, and Customer Experience Committee; advance working group projects; arrange monthly conference calls; plan and execute seminars, conferences, webinars related to media relations.     ?   ? PandoLogic. Category:Marketing & Biz Dev, Keywords:Marketing Manager, Location:Washington, DC-20036",
			Company = "Airports Council",
			City = "Washington",
			State = "DC",
			PostedDate = new DateTime(2020,1,8),
			MinimumSalary = 52000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "195a7182329c851532fd93c8ba361afa",
			Title = "Video Games Engineer, Infotainment Software",
			Description = "The Role     Tesla strives to make its cars the most fun possible; bringing video game experiences to the car helps increase that fun. In this incredibly rare opportunity to help build a video games platform, we are looking for a highly motivated software engineer to help enable the best video game content to be available in-car. Come put that industry experience to great use and help us build this platform.   You will need strong software engineering skills, excellent interpersonal communication, and experience accepting and giving meaningful feedback on technical designs. You will be expected to contribute to many different areas to make projects happen, that may range from kernel level code changes, to in game behavior, to helping developers work with our platform. You will be responsible for the look and feel of the play experience, architecture, and whatever else is needed to create fun. You will need to collaborate with our top-notch design team and back end developers to help create this platform.   Our goal is to set the bar for what video games in a car can be; much of this is uncharted territory having never been done before. We want to work with people who are excited by this goal and have the talent to deliver on it.     Responsibilities        Design, architect, implement and debug game platform interfaces and systems     Rapid prototyping and ownership of fun in-car customer experiences     Work with a cross-functional team of hardware engineers, application/UI software engineers, QA/validation, and designers     Communicate with game development and publishing partne rs      Requirements        Proficient in C++     Excellent grasp of fundamental computer science concepts     Experience writing and shipping customer-facing code     Willingness & curiosity to learn new technologies in any area of the stack: UI, Rendering, Core, Protocol, Server     Experience shipping products in the video game industry     High standards for code quality, maintainability, and performance",
			Company = "Tesla Motors",
			City = "Bellevue",
			State = "WA",
			PostedDate = new DateTime(2020,1,9),
			MinimumSalary = 73000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "5bb74e90b36f55feca64120b4719cc78",
			Title = "Digital Marketing Manager for a Popular Cosmetics Company",
			Description = "Our client is a popular cosmetics company that uses only clean, non-toxic ingredients. They are headquartered in Los Angeles and experiencing rapid growth. They are seeking a Digital Marketing Manager who will lead and manage key digital marketing campaigns, with a particular focus on email. This person will play a key role in helping the Marketing Team execute a global marketing strategy with a focus on email marketing, digital media programs, optimizing campaigns, and creating brand awareness to drive new traffic and customer acquisition growth.  Responsibilities:  - Execute marketing strategies to drive sales and awareness through performance marketing campaigns with a focus on email marketing  - Manage all ongoing and new advertising campaigns both online and offline on a daily basis including ad rotation, media spend, day-parting, and bid adjustments  - Recommend effective emerging marketing channels and platforms to test and learn including conducting research on new media partnerships, ad buys, ad networks and other related opportunities  - Build, manage and maintain close relationships with online media representatives & vendors  - Negotiate media rates and contracts with publishers  - Responsible for ideating and collaborating on marketing creative and ad copy to drive KPI?s through paid channels  - Partner with Web Development team to monitor, audit and update direct-to-consumer website to optimize SEO rankings, user-experience, and user-interface to meet conversion goals  Qualifications?:?  - Bachelor?s Degree in Marketing, or closely-related field  -  6+ years experience in digital marketing with strong email marketing experience  - Demonstrated experience managing digital advertising campaigns on top industry platforms  - Google Analytics, Google Adwords, and Facebook Advertising Certifications, a plus  - Proficient in Excel  - Knowledge of industry trends in marketing, e-commerce, social media, cosmetics, and clean beauty  - Strong interest and an eye for beauty and fashion, especially as it relates to digital media",
			Company = "Confidential",
			City = "Los Angeles",
			State = "CA",
			PostedDate = new DateTime(2020,1,4),
			MinimumSalary = 89000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "f8fe644b71c25618d6a7e92fcbd8c71d",
			Title = "Account Coordinator",
			Description = "Why a Great Opportunity Our client is one of the largest spa and wellness marketing company in North America. They are an established national brand with a blog and social community centered on beauty, fitness, fashion, food and health The company's wide range of digital and retail products, including the bi-annual industry event are designed to address the evolving operational needs of spa and wellness centers to help grow their business.?? Its Spa & Wellness Gift Cards are sold in over 75,000 locations nationwide and accepted at over 10,000 partner locations.? In addition, the gift card is sold directly on its website, as well as, through many B2B loyalty/ incentive and wellness program channels. Job Description Our client is looking for a Sales Assistant who is a highly motivated strategic thinker to support its sales positions. They are in the process of launching a subscription-based program and need a key player to assist in its development and growth. The ideal candidate needs to possess strong attention to detail while delivering exceptional service to its business partners.? This candidate will need to be extremely comfortable with heavy phone work, able to prioritize tasks and thrive in a fast-paced environment. Responsibilities: Edit and process contracts with a high degree of accuracy Heavy phone work will include interaction with partners and consumers Assist sales team with the launch of our new subscription-based program Direct sales leads to appropriate member of sales team Perform data entry - enter leads, set up listings for spaweek.com, and edit / upload services to the site Resolve consumer and partner issues in a prompt, courteous and professional manner and escalate as needed Track sales data and progress reports Assist on other projects as needed Qualifications Requirements: Bachelor?s degree Minimum three years of support or administrative experience Thrive in an extremely fast-paced environment Excellent customer service skills, both verbal and written Ability multi-task, work with minimal supervision and exercise good judgment Develop and maintain positive working relationships to support common goals Ability to thrive in a collaborative environment Proficient with Microsoft Office (Word, Excel, PowerPoint) and Google Docs Plus: interest in marketing, experience with Photoshop ? Compensation & Benefits: Competitive salary Health Care, Vision and Dental Coverage Generous Paid Time Off, Great Company Incentives/Perks 401K Job Summary Location New York City, NY Posted 5 Days ago Reference code 29495",
			Company = "NPAworldwide Recruitment Network",
			City = "New York City",
			State = "NY",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 88000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "930b84a7f298ccaf3da8ed4007223d4a",
			Title = "Data Architect",
			Description = "POSITION SUMMARY : As the data architect your primary responsibility will be to develop, optimize and oversee conceptual and logical data systems. You will build and maintain a company s database by identifying structural and installation solutions that align with needs. Additionally, you will work with engineers and analysts to secure easy access for accurate user to company data. ESSENTIAL JOB RESPONSIBILITIES : Build, optimize and maintain conceptual and logical data models. Analyze business needs for new data solutions, software and application. Translating business needs into solutions. Design and implement data orchestration pipelines, data sourcing, cleansing, and augmentation and quality control processes. Contributing to overall solution, integration, and enterprise architectures Mentoring data engineers to further their personal and professional growth. Leading other engineering staff on projects. Developing team s talent by providing direction and facilitating technical architectural discussions. KNOWLEDGE, EXPERIENCE AND SKILLS : BS/BA in data engineering, software engineering, data science, computer science, applied mathematics, or equivalent experience. 8+ years of experience working on large scale, full lifecycle data implementation projects. 2+ years professional development experience with some of the AWS/Azure/GCP data stack. A deep understanding of relational and warehousing database technology, working with at least one of the major databases platforms (Snowflake, Oracle, SQLServer, Teradata, MySQL, Postgres). Hands-on RDBMS experience (data modeling, analysis, programming, stored procedures) Expertise in developing ETL/ELT workflows with one or more of the following: Talend/Informatica/InfoSphere ETL tools; Python, Java. Deployment of data pipelines in the Cloud (AWS, Azure, or GCP). Experience working with Big Data technologies such as Spark, Hive, Impala, Druid, or Presto. Proven success working in and promoting a rapidly changing, collaborative, and iterative product development environment. Strong interpersonal and analytical skills. Intellectual curiosity and an ability to execute projects. An understanding of big picture business requirements that drive architecture and design decisions. DevOps and DataOps skills including infrastructure as code systems Data system performance tuning. Implementation of predictive analytics and machine learning models (MLlib, scikit-learn, etc). - provided by Dice Job Summary Location Spring, TX 77373 Posted Today Reference code 6874_b9d863036beda26f2f0e31fef0449901",
			Company = "Veloc Inc.",
			City = "Spring",
			State = "TX",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 57000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "fcd1a5eee10616dabe5ebef16091f96d",
			Title = "Nursing Home Administrator(LNHA)",
			Description = "TITLE: Nursing Home Administrator(LNHA)   LOCATION: Sparta, Wisconsin    ?   Are you interested in working for a company that is interested in candidates that are interested in patient care? Would you like to work in an area that is close to Minneapolis but offers small town living and is very welcoming? Then this could be an opportunity for you.   ?    Summary:  Direct the day-to-day functions of the facility in accordance with current federal, state, and local standards, guidelines and regulations that govern long term care facilities, as well as all company policies to assure that the highest degree of quality care can be provided to the residents at all times. Additionally, the Administrator must also operate the facility in accordance with the facility?s budget.   ?    Qualifications:  A Bachelor?s degree in Public Health Administration, Business Administration, or a health related degree is preferred. Possess three (3) or more years of experience as a nursing home administrator. Must posses a current, unencumbered Nursing Home Administrator?s license in Wisconsin. Have not received state or federal deficiencies at a scope & severity above a level G. Must be able to read and interpret financial records, reports, etc. Must be knowledgeable of federal and state anti-discrimination and anti-harassment employment laws and regulations Must have a sincere caring for and interest in the elderly and have the ability to communicate policies, procedures, regulations, reports, etc., to personnel, residents, families, and government agencies.   ?    Additional Info:  The company is a leading provider of short-term post-acute rehabilitation and long-term nursing care. They currently operate several skilled nursing centers in Ohio, Michigan, Kentucky, and Wisconsin with nearly 4,000 beds. The facility is around 75 beds. The company is offering a salary between 85-95K depending for experience for the position along with a great benefits package that includes medical, dental, vision, life, 401K, PTO and tuition reimbursement",
			Company = "Cameron Craig Group",
			City = "Sparta",
			State = "WI",
			PostedDate = new DateTime(2020,1,25),
			MinimumSalary = 42000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "395831e528bf2e6ad9ee6c1c3b2d0b25",
			Title = "VP of Operations",
			Description = "Does this describe you    Do you have experience in business with a proven track record of successful results  Are you known for your business acumen and knowledge of business operations  Do you have a natural ability to connect, relate, and persuade people to your way of thinking  Are you great at organizing a multitude of components and executing in a compressed period of time  Would those that know you best describe you as having great attention to detail  Are you naturally gifted at building and maintaining relationships with executives and associates at all levels of the organization  In the eye of a hurricane, can you remain calm during the storm    If this describes you, this is your opportunity to be a part of a high-growth, privately-held organization named by Glassdoor as one of the nation?s top 50 workplaces. Company is a national leader in operating upscale apartment communities and is considered the best in its industry.? In just 25 years, we?ve grown from zero to $2.5 billion in assets. Along the way we?ve won national awards for innovation and community involvement. But we?re most proud of our more than 400 associates, who remain our No. 1 key to success.  No apartment industry experience Great! We?ve grown successfully by bringing an entirely new and innovative approach to the apartment industry, carried out by a senior management team with no prior industry experience. Our leadership team consists of people from a variety of backgrounds with certain common traits: talent and proven track records of leading, motivating and managing overachieving teams.    The successful candidate will be afforded the following opportunities:  Partnership opportunity within 36 months with an estimated value between $2 & $4 Million  Leadership role with a company named a?Top 50 workplace by Glassdoor.com  Ability to contribute to a highly successful & growing company  Exceptional Pay, Benefits & Bonus opportunity  Day 1, 100% paid health and dental benefits for you and your family  401 k with company match  Opportunity to work with an elite, game changing organization",
			Company = "The Connor Group",
			City = "Dayton",
			State = "OH",
			PostedDate = new DateTime(2020,1,11),
			MinimumSalary = 85000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "21570de085e66f306b35ec0120a8b696",
			Title = "Sr Global Compensation Analyst",
			Description = "Job Description Position at Ingram Micro Ingram Micro touches 80% of the technology you use every day with our focus on Technology Solutions, Cloud, and Commerce and Lifecycle Solutions. With $46 billion in revenue, we have become the world's largest technology distributor with operations in 56 countries and more than 30,000 associates. We continue to strategically expand our global reach with 32 acquisitions since 2012. Position Summary: Responsibilities include the development, implementation, and maintenance of all components of pay (base and incentive/bonus) programs in the US and internationally for executive and non-executive populations. Evaluates roles, compensation packages and other programs, keeps abreast of legislation, trends, advances and/or new technology and makes recommendations for changes and improvements. Provides compensation advice and counseling to HR management who provide counseling to employees and managers. Participates in compensation surveys and ensures competitive pay practices are maintained. Works with external vendors to develop and/or administer compensation programs or systems. Provide project leadership and process leadership to other compensation team members. Requirements: Extensive working and practical knowledge of a wide variety of compensation techniques, theory, and practices. Bachelor's degree preferably in business administration, finance, accounting, or human resources. A minimum of seven years of experience and exposure to the field of compensation, preferably at a global company. International experience strongly preferred. CCP desirable. Strong analytical skills; ability to develop complex compensation analysis required. Excellent verbal and written communication and interpersonal skills. Workday and MarketPay experience desirable. Advanced skills in Microsoft Excel and PowerPoint required. Ability to work effectively and in diverse work groups with all levels of management. *This is not a complete listing of the job duties. It's a representation of the things you will be doing, and you may not perform all of these duties. Ingram Micro Inc. is committed to creating a diverse environment and is proud to be an equal opportunity employer. All qualified applicants will receive consideration for employment without regard to race, color, religion, gender, gender identity or expression, sexual orientation, national origin, genetics, disability, age, veteran status, or any other protected category under applicable law. Job Summary Location Irvine, CA 92602 Posted 14 Days ago Reference code oERUbfwk-124760777",
			Company = "Ingram Micro Inc",
			City = "Irvine",
			State = "CA",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 51000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "3dba146b9adf69686a76a9394d2cd391",
			Title = "Sr. Mobile Software Developer",
			Description = "Job Description:   The Sr. Mobile Software Developer is responsible for developing software applications and assisting others in development. These roles are responsible for building Android SDKs based applications for a variety of healthcare and Internet of Things (IoT) problems.  Responsibilities:? ? ? ? ? ?Collaborate closely with the UI design team and translate UX requirements into high quality code. ? ? ? ? ?Provide feedback and influence UI design to leverage latest features available in Android SDKs. ? ? ? ? ?Design and build out the next generation smart-phone applications that are responsive, high performance, testable and maintainable. ? ? ? ? ?Scope work, break down into modules, and estimate efforts working closely with Program management. ? ? ? ? ?Effectively present and demonstrate various concepts and solutions to other team members. ? ? ? ? ?Perform other duties as required.   Minimum Requirements: ? ? ? ? ?Bachelors degree in Computer Science, Computer Engineering or equivalent education plus experience. ? ? ? ? ?4+ years Software development experience with focus in Android mobile UI.? ? ? ? ? ?Solid understanding of Android application building blocks e.g. Activities/Fragments, Services, Broadcast Receivers/Intents, Content Providers ? ? ? ? ?Extensive experience with Android Studio, Git, responsive UI development and localization ? ? ? ? ?Extensive Experience with Android SDK and APIs ? ? ? ? ?Experience in applying best coding practices, writing clean, testable and maintainable code ? ? ? ? ?Experience? in debugging and troubleshooting code to find bugs and improve performance  Preferred Skills and Competencies:? ? ? ? ? ? ? ? ? ?Excellent communications skills and extensive experience working with technical teams. ? ? ? ? ?Experience with Agile software development preferred. ? ? ? ? ?Experience with Sketch and Zeplin is a plus ? ? ? ? ?Knowledge of RxJava, Realm is a big plus ? ? ? ? ?Understanding on MVP, MVVP architecture patterns? ? ? ? ? ?Experience with medical device development, Bluetooth, etc., is desired",
			Company = "Avance Consulting",
			City = "San Diego",
			State = "CA",
			PostedDate = new DateTime(2020,1,9),
			MinimumSalary = 78000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "cbf49f0ab003cf7db836261ddcc9a445",
			Title = "On-Premise Specialist (Fine Wine Sales Consultant)",
			Description = "On-Premise Specialist position is responsible for coaching and developing sales consultants.  This roll will assist supervisors in managing key strategic initiatives in the on-premise and fine wine arena.  This role requires a flexible work schedule due to the demands of the marketplace.   Job Description:    Achieve sales, service and product distribution objectives in an established geography while working with sales consultants and their supervisors  Work market with brand owners and their representatives  Provide after sales support; including staff trainings, organizing product dinners and conducting evening and weekend tastings  Provide accurate and detailed daily preplans, recaps, and sales reports  Develops and implements strategic sales plans to accommodate corporate goals  Coordinates and assists in leading sales meetings  Monitors and evaluates products and activities of competition  Reviews market analyses to determine customer needs     Job Requirements:    Bachelor?s degree preferred  2 years of sales experience in the alcoholic beverage industry preferred  Previous on-premise sales experience a plus  Self-motivated; willingness to work independently  Ability to maintain a flexible work schedule; including weekends and evenings  Some overnight travel required  Must be 21 years of age and able to qualify for an ABC Wholesale Salesmen Permit  Periodic and repetitive lifting of up to 40-60 pounds  Clean driving record, valid driver license and personal vehicle required  Strong  analytical, excellent organizational , and negotiation skills and attention to detail      Candidate must be able to pass a pre-employment drug screen, criminal background check, and Post Offer physical. ?     AAP/EEO STATEMENT   Johnson Brothers Mutual Distributing of North Carolina provides equal employment opportunity to all individuals regardless of their race, color, creed, religion, gender, age, sexual orientation, national origin, disability, veteran status, or any other characteristic protected by state, federal, or local law.",
			Company = "Johnson Brothers",
			City = "Raleigh",
			State = "NC",
			PostedDate = new DateTime(2020,1,21),
			MinimumSalary = 89000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "b425f92f6c7841df244cc3856b130d17",
			Title = "Clinical Psychologist / Pediatrics (Part Time)",
			Description = "Job Description Provide direct and consultative psychological services to patients, families and interdisciplinary staff. Evaluates cognitive and behavioral functions. 1. Selects formal and informal assessment methods appropriate for age, medical condition and functional status to assess patient's psychological status. 2. Evaluates children to obtain information necessary for planning and intervention in areas of cognition, learning and behavior. 3. Determines appropriate recommendations and treatment for patients evaluated. 4. Participates in autism spectrum disorder evaluations as a key player in the administration of gold standard, or as a supplemental consultant. 5. Presents treatment plan and educates patient, family, and related hospital staff of procedures in a manner consistent with level of understanding. 6. Documents patient interventions according to department and hospital policies and procedures. 7. Collaborates with patient's multidisciplinary health care team, including developmental pediatrician and family nurse practitioner. 8. Evaluates care provided for positive patient outcomes. 9. Analyzes outcome/follow-up data for purposes of performance improvement and research. 10. Collaborates in hospital division's scholarly activities (e.g. research, resident education, etc.). 11. Performs related duties as required. *ADA Essential Functions Qualifications ? Doctoral Degree in Clinical Psychology from an accredited college or university, required. ? Currently licensed to practice Psychology in the State of New York. (Non-clinical psychologists may qualify for this position if educational training and requirements are comparable.) ? Qualify within six (6) months for Medical Board appointment from the medical board overseeing program(s) within which the psychologist is practicing. Extensions not exceeding ninety (90) days may be granted in unusual circumstances. Provisional hiring status to remain until Board Appointment is approved. ? Prior experience in psychological testing and/or evaluating Autism Spectrum Disorders, preferred. ",
			Company = "Northwell Health",
			City = "Staten Island",
			State = "NY",
			PostedDate = new DateTime(2020,1,15),
			MinimumSalary = 70000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d854ea764ae2ed2083e786764207396f",
			Title = "Inbound Banking Support",
			Description = "Full Time-Permanent     Start Date: March 3rd, 2020      Training:  2:00pm-10:30pm Monday - Friday (5 Weeks)    Work Schedule:     -- Schedule:  2:00pm-10:30pm with Thursdays and Fridays off each week    ** Must be able to work every weekend      $16 per hr.       Spanish Bilinguals needed! Receive a?6% premium on top of hourly rate!*   ?*12% ($1.92 per hour) shift differential for eligible hours worked evenings and weekends*    Job Overview     Receiving inbound calls from banking and merchant customers.? Answer questions, assist with researching and resolving issues, etc.? We want our customers to receive a WOW experience.? We want someone who has the ability to be an active listener and is able to express empathy to the customer.      Education:      High School Diploma or GED is preferred       Job Related Experience:      One year customer service experience and/or one year call center experience      Solid internet navigational skills are needed      Good verbal and written communication skills      Experience with an online bill pay service is a plus        Pre-employment background, credit, and drug screen are required.      Why we stand out from the rest     PEOPLE are caring and friendly    CULTURE, Team environment that is fun and supportive    PRIDE in what we do      Added Bonus      Quarterly Honors Program      State of the art facility ? clean and bright      On-Site gym      Free coffee, tea and soda for all      On-Site Caf?      Dual Monitors      Ergonomic chairs       Fiserv offers a competitive compensation and benefits program including:      Medical/Dental/Vision Coverage (eligible on your first day of employment)      On site cafeteria      Unlimited free beverages      Tuition Reimbursement      Flexible Spending Accounts      Business casual dress environment      Comprehensive training programs      Lucrative paid time off program       We are located at 4801 E. Thistle Landing Drive, Phoenix, AZ 85044.? Near the intersection of Ray Road and I-10 freeway, closer to the Ahwatukee Foothills area.      Be Fiserv proud!",
			Company = "Fiserv",
			City = "Phoenix",
			State = "AZ",
			PostedDate = new DateTime(2020,1,15),
			MinimumSalary = 91000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a3312eace540685515a8638fc75c46ba",
			Title = "VP Research Director Financial Services",
			Description = "About This Role: Company is seeking a Vice President, Research Director to lead a research team for our financial services practice. This role helps financial services (finserv) decision makers drive their firm?s success in a hyper-digital and customer-led world. The VP, Research Director is responsible for defining a compelling and actionable research agenda that addresses the needs of innovators in charge of strategy and technology decisions in the financial services sector, constantly challenges their thinking, and helps them lead change. This person also ensures the quality of the research produced by the financial services research team in the areas of banking, insurance, and wealth management. Our ideal candidate is someone who has the ability to partner effectively with both seasoned and new analysts and is passionate about helping individuals achieve their full potential as strategic thinkers and writers. As an advocate and champion for the team and research within Company and with our clients, the successful candidate will partner closely with our global sales organization in pursuing new business opportunities and enriching existing client relationships. Responsibilities Engage as a thought partner with the analyst team to refine and expand the existing research agenda. Shape the narrative of syndicated research content and ensure the quality of our intellectual property. Co-author thought-leading research pieces and deliver a limited amount of consulting based on that research. Serve as a mentor and coach to new members of the research team in support of their professional development goals. Work with the sales team to develop prospect and client engagement strategies and pursue business opportunities. Provide input and support to the team of other Company professionals who serve financial services clients. Meet the team performance goals for smooth content production, consulting revenues, and client support. Participate in Company-sponsored and other events to drive financial services research awareness in our digital practice. Qualifications A strong record of academic achievement. At least 15 years of experience as a practitioner or consultant in financial services areas such as banking, insurance, and/or wealth management. Minimum five years experience of managing a team of 10 people or larger Demonstrated ability to advise senior-level clients. Knowledge of financial services issues and challenges. Superior analytical, writing, and presentation skills. The ability to travel 15% to 20% of the time. Job Summary Location Cambridge, MA Posted Today Reference code 605499",
			Company = "Forrester",
			City = "Cambridge",
			State = "MA",
			PostedDate = new DateTime(2020,1,30),
			MinimumSalary = 52000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "9954ae227ab09b8d6dea076f13647022",
			Title = "Reception/Production Assistant",
			Description = "REF#:  36176  CBS BUSINESS UNIT:  The Late Show with Stephen Colbert  JOB TYPE:  Full-Time Staff  JOB SCHEDULE:   JOB LOCATION:  New York, NY  ABOUT US:  ViacomCBS is a leading global media and entertainment company that creates premium content and experiences for audiences worldwide. Driven by iconic consumer brands, its portfolio includes CBS, Showtime Networks, Paramount Pictures, Nickelodeon, MTV, Comedy Central, BET, CBS All Access, Pluto TV and Simon & Schuster, among others. The company delivers the largest share of the U.S. television audience and boasts one of the industry?s most important and extensive libraries of TV and film titles. In addition to offering innovative streaming services and digital video products, ViacomCBS provides powerful capabilities in production, distribution and advertising solutions for partners on five continents.  DESCRIPTION:  The Late Show is hiring a Production Assistant to work with the Production Department. This person will be responsible for handling front desk operations and assisting on field shoots as needed. Responsibilities: * Field phone calls from the general public about audience related questions and general inquiries * Organize and distribute all incoming and outgoing mail. * Provide support on various shoots and coordinate makeup, wardrobe, and outside talent. * Assist with the Script Department, Control Room, and Cold Open teams when needed. * Other tasks include but are not limited to: office administration & maintenance, log footage production for residual purposes. * The right candidate will be able to handle a fast paced work environment, multitask, drive a 15 passenger or cargo van when needed, run errands, and be prepared to assist in anything that the production requires  QUALIFICATIONS:  * Bachelor's degree or equivalent work experience. * Minimum of 1 year in television. * Valid Driver's License. * Broad understanding of and interest in current events, politics, and comedy. * Detail oriented, able to communicate well with various departments.  EEO STATEMENT:  Equal Opportunity Employer Minorities/Women/Veterans/Disabled",
			Company = "ViacomCBS",
			City = "New York",
			State = "NY",
			PostedDate = new DateTime(2020,1,25),
			MinimumSalary = 64000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "728477ef646d1b4655f66a49ed56f56a",
			Title = "CVOR Nurse Educator",
			Description = "An amazing opportunity has just opened up in Massachusettsfor aCardiovascular Operating Room Nurse Educator. The Nurse Educator will join the PerioperativeService line of a stable community hospital, near the MA-CT state lines. This is an excellent opportunity to mentor and educate the nurses of tomorrow.  This 700-bed medical central, is a leader in the region for providing expert, specialized care. With clinical excellence in areas such as Cancer Care, Neonatal Services, Cardiac Surgery, and a state-of-the-art emergency center, this hospital has been providing high quality care to the region?s residents for many decades.   The CVOR Nurse Educator Surgical Services will be responsible for the continued education of Operating Room Nurses,CNORs,RNswithin the Surgical Services Department. Reporting to the Operating Room Nursing Manager and Nurse DirectorPerioperativeService Line, theClinical Nurse Educator Surgical Services will lead evidence based research initiatives, oversee quality improvement and will be responsible for maintaining safety and quality standards throughout the Operating Room Department.   The Clinical Nurse Educator must have CVOR experience as they may scrub and circulate throughout the operating room and always functionas an exemplary leader. This Surgical Services department utilizes the most advanced technologies, including the DaVinciRobotic surgery program, to help achieve some of the highest patient satisfaction scores in the area.  The medical center is located in the historic and stunning landscape of Massachusetts. This city provides residents with a number of options in terms of neighborhoods, each with its one flare and charm. With excellent higher education opportunities, exciting professional sports teams, and some of America?s most important historical sites, this is truly a thrilling place to call home.  The Clinical Nurse EducatorCardiovascular Surgery will be offered a great compensation package that will include a generous base salary. The hospital leadership team is looking fora truly innovative educator and a true expert within the Operating Room.",
			Company = "Clinical Management Consultants",
			City = "Westfield",
			State = "MA",
			PostedDate = new DateTime(2020,1,21),
			MinimumSalary = 95000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "f62c0501f1ee177441294f7a22781070",
			Title = "Registered Dental Hygienist",
			Description = "Ready to change lives? Dentist owned and operated,Triad Kids Dental?is is dedicated to creating a world of happy, healthy smiles. We believe every person deserves access to quality, affordable dental care - and this mission drives everything we do. We are looking for a Hygienist ready to create memorable patient experiences. Mississippi Smiles is not your typical dentist office, so if you are ready to have fun and make a difference, keep reading! Below are the basics of this role: Our Hygienists are responsible for delivering direct dental care and associated services to patients under the general supervision of a dentist and for providing general support to the office. Deliver quality and compassionate care to every patient Deliver direct patient care to patients, including scaling and prophylaxis, x-rays, application of sealants and fluoride, and related procedures, under the general supervision of a dentist Provide excellent customer service by looking for opportunities to offer Same Day Care Educate patients and parents in oral hygiene instruction Assess the dental condition and needs of patients and review patients' medical history Responsible for adhering to all government regulations and company standards Guide parents and patients through entire treatment process Assist with dental and perio charting; when necessary Take x-rays and save into patient charts, when necessary Ready to do more than the basics and be super awesome? Have fun and make sure our patients are having fun too Provide memorable patient experiences by showing compassion for our patients and parents Get out into your community - participate in local events including school screenings, presentations and any opportunity to promote a positive image Look around and do more than you are asked to do by assisting with other office duties as needed Integrity, always do the right thing! Love working with kids And yes, there are requirements for this role: Current licensure as a Dental Hygienist in good standing Experience is great, but not always required Bilingual is a plus Take care of our patients and we will take care of you: We offer very competitive pay and benefits package as well as growth opportunities to our full -time employees. Our Full-Time dental hygienists also receive company paid malpractice insurance. Other benefits include: medical, dental, vision and optional life insurance. We also offer short and long term disability, 401K with match, flexible spending accounts, paid time off, company holidays and much much more! Job Summary Location Greensboro, NC 27406 Posted 1 Days ago Reference code fc77ec89-b1f3-2462-4e2c-a90fddf5951a",
			Company = "Kids Dental Brands",
			City = "Greensboro",
			State = "NC",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 51000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "9621363e88a24751fa412823c30864fb",
			Title = "Information Architect",
			Description = "Our client is in need of an Information Architect.?This is a contract-to-hire opportunity in St. Louis, MO.?  LRS Consulting Services has been delivering the highest quality consultants to our clients since 1979. We've built a solid reputation for dealing with our clients and our consultants with honesty, integrity, and respect. We work hard every day to maintain that reputation, and we're very interested in candidates who can help us. If you're that candidate, this opportunity is made for you!  Day to Day responsibilities include:  \t Meet with business owners to identity their needs and opportunities related to data and analytics; probe for project requirements and translate requirements to advanced analytics output. \t Support the ongoing advanced analytics efforts for the organization. Collaborate with different business groups and take data from ingest to transformation to visualization. \t Learn new technologies and data techniques in a fast-paced environment to apply to advanced analytics projects. \t Take data from ingest to transformation to visualization; provide visual output for business units. \t Take data from ingest to transformation to data output; provide data applications to business units. \t Leverage and learn updated technologies on an ongoing basis to optimize data solutions for business owners. \t Work, collaborate and validate in an agile environment with multiple sprints in a project.   Qualifications:  \t Must have a minimum of 6 months of experience developing code in .NET, Java, SQL, Python, R, or completed LaunchCode training \t Candidate must be able to effectively communicate in English (written & verbal) \t Candidate must have permanent authorization to work in the USA for any employer \t Corp to corp candidates will not be considered   To apply go to jobs.lrs.com.  LRS is an equal opportunity employer. Applicants for employment will receive consideration without unlawful discrimination based on race, color, religion, creed, national origin, sex, age, disability, marital status, gender identity, domestic partner status, sexual orientation, genetic information, citizenship status or protected veteran status.",
			Company = "LRS",
			City = "Maryland Heights",
			State = "MO",
			PostedDate = new DateTime(2020,1,9),
			MinimumSalary = 93000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "e54c97727704d5c821299265e29e839b",
			Title = "Computer Vision Software Engineer (Internship)",
			Description = "AiFi is a fast-paced technology company that is transforming the world of cashier-less shopping! Bring your passion and dedication, and there's no telling what you could accomplish. Are you passionate about using your knowledge to navigate complex challenges? Join us, and youll have a meaningful role in the next evolution of the consumer shopping experience.     The  Computer Vision Software Engineer Intern  is an integral member of the team responsible for helping solve a variety of technical challenges. You will play an active role in translating business and functional requirements into concrete deliverables and build quick prototypes or proofs of concept in partnership with other technology leaders within the team. You will help invent new features, design, develop and deploy reliable distributed services.   This would be a summer internship located in our Santa Clara office.     If you love :   Work collaboratively with talented teammates to solve some of the greatest challenges in the AI field including computer vision, machine learning, distributed systems and edge computing.  Provide software design and programming support to R&D projects, along with architecting and implementing software libraries.       We are seeking a Computer Vision Software Engineer Intern    BA/BS in Computer Science or a degree in a similar technical discipline.  Hands-on programming experience in Python, Go, and C++.  The ability to produce bullet-proof code that is fault-tolerant, efficient and maintainable.  Academic and/or industry experience with one of more of the following domains: computer vision, image recognition, machine learning or large-scale distributed systems.  Strong communication and team-success oriented collaboration skills.       If you have one of these experiences it is even better :   Enrolled in a PhD/Masters Program in Computer Science or focus on machine learning, artificial intelligence or a related field.  Experience with designing and building systems in a multi-tiered, distributed environment.  Experience optimizing for short term execution while planning for long term technical capabilities.  ",
			Company = "AiFi",
			City = "Santa Clara",
			State = "CA",
			PostedDate = new DateTime(2020,1,12),
			MinimumSalary = 52000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d0d05d20dd6b780cb8d15837fc0b7426",
			Title = "Dental Lab Technician 3",
			Description = "Dental Lab Technician Summary of Position: ClearChoice dental laboratory technicians work onsite at the dentist office to fill prescriptions from those dentists. They use advanced technical skills to construct sophisticated implant-based dental prosthetics to exacting standards for fit and esthetics and use critical thinking to develop and share complex solutions with the dentist and auxiliary staff. The Tech 3 will work under the supervision of the Laboratory Manager if one is assigned or may be called to be a lead technician in the center. While work methods follow established procedures and practices, candidates are expected to consult with their doctors and team using a high degree of judgment on a patient-by-patient basis. Duties and Responsibilities: Receiving and entering work orders and accompanying materials including impressions, models and components. The manufacture and fitting of all aspects of All-On-Four dental prosthetics including accurate manufacture and articulation of implant models, setting of denture teeth, denture processing and all related components and processes. The ability to ensure the accurate and on time manufacture of prosthetics to a patient-driven schedule. Denture and All-On-Four type restoration repairs Maintenance of all laboratory facilities, equipment and instruments Monitoring of all laboratory related supplies and ordering through paper and/or computer-based purchase order systems. Teaching and mentoring other technicians and auxiliary staff Operate computers and standard office type applications such as web browsers, word processing and spreadsheet software applications as well as dental laboratory specific applications. Maintain only the highest degree of professionalism and communicate clearly both verbally and in writing Education and Experience: A minimum of seven years of hands-on technical experience is required. Certification (CDT) or the completion of an accredited dental laboratory program is preferred but not mandatory. Qualified candidates should have experience and be proficient in full arch hybrid restorations, complete dentures, overdentures and implant based restorative techniques and have strong knowledge of dental science and anatomy and esthetics. Working Conditions: ClearChoice operates two-three person dental laboratories within each of its dental offices. As such, technicians perform their duties in both the dental laboratory and dental office environments. Technicians are expected to be onsite at all times Monday through Friday. Days and hours may vary. EOE Job Summary Location Fort Wayne, IN 46804 Posted 25 Days ago Reference code 2365_23d8e2bfa713a1ac45c05fd119bb53ef",
			Company = "ClearChoice Dental Implant Centers",
			City = "Fort Wayne",
			State = "IN",
			PostedDate = new DateTime(2020,1,22),
			MinimumSalary = 78000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a9a7212e5af5077d2c79e0141f02af35",
			Title = "Group Exercise Instructor",
			Description = "Part time; Cooper Wellness Strategies. Serve as a group exercise instructor to safely lead members in a group setting through pre-determined exercise formats created to enhance overall fitness, strength and endurance. The group exercise instructor will also serve as a resource to educate members on various aspects of fitness.  Individual will be a Cooper Aerobics employee servicing a clients on-site fitness facility in Austin, Texas.    Wednesday, 5:15 p.m. - 6:15 p.m. Sub options available    Essential Duties and Responsibilities      Comply with all group fitness related Cooper and client policies and procedures   Plan various engaging routines, music and movements depending upon type of class to educate and motivate participants   Instruct with a variety of teaching methods to accommodate different learning styles and capabilities   Teach assigned classes on time and take ownership for covering classes with an appropriate substitute when absent   Prepare fitness space for the class and restore space to its original state after teaching   Clean and organize studio after each group fitness class   Motivate members to consistently attend group fitness classes   Other duties as needed          Actively working toward a degree in Health and Exercise Science, Kinesiology, Health Promotion or similar study preferred   At least six months teaching in a group exercise format   Group fitness certification by ACE, AFAA, ACSM or The Cooper Institute   Instructors having a specialized skill such as yoga, Pilates, indoor cycling, Zumba, etc. must provide verifiable proof of education   Current CPR certification and basic first aid training   Knowledge of safe exercise technique and group exercise principles   Knowledge of basic physiology and body mechanics   Performance of a variety of exercise routines   Positive and effective interpersonal communication skills   Exceptional customer relations skills and a positive attitude   Excellent organization skills   Ability to operate and troubleshoot audio equipment   Physical demands include, but are not limited to the ability to lift light weights, bend, squat, jump, run, reach, walk, hop, spin and kick    PI116984253",
			Company = "Cooper Aerobics Enterprises Inc",
			City = "Austin",
			State = "TX",
			PostedDate = new DateTime(2020,1,10),
			MinimumSalary = 60000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "b261a05c1569bfbbc82fabe51436ba91",
			Title = "Junior Software Developer",
			Description = "RESOLVIT Bringing Solutions That Make Business Better Join Resolvit as a Junior Software Developer and be part of a creative, forward-thinking team. Our success at deploying skilled, highly knowledgeable experts has landed us on the Inc. 5000 list of America's fastest-growing companies four times - and we're just getting started. As the Junior Software Developer , you will act as a member of the Software Center of Excellence, representing the face of high-quality design and development practices. You will develop high performing, scaling, and innovative end-to-end web applications. You will collaborate with System Engineers, Front End Developers, and Software Developers to implement solutions that are aligned with and extend shared platforms and solutions. Additionally, you will: Apply principles of SDLC and methodologies like Lean/Agile/XP, CI, Software and Product Security, Documentation Practices, refactoring, and Testing Techniques Write code that meets standards and delivers desired functionality using the technology selected for the project Build features such as web services and queries on existing tables Understand performance parameters and assess application performance Work on care data structures and algorithms and implement them using language of choice What You'll Need to be Successful: 1 to 3 years of experience in specific tech stacks; Front End Engineers require knowledge of Angular, JavaScript, TypeScript, CSS, and HTML and Back End Engineers require knowledge of Spring, Java, and SQL Great Additional Skills: Experience in native AWS services Benefits: At Resolvit, you'll be given the support you need to grow in your consulting career. In addition to opportunities for advancement, we offer: Medical, dental, and vision insurance Life insurance coverage Long-term and short-term disability coverage 401(k) retirement plan with matching Professional support from our Client & Employee Optimization Specialist We currently have more than 100 open career opportunities across the country, so be sure to mention the appropriate Job Code with any correspondence! About Resolvit: Resolvit is an international technology consulting firm with industry-leading customers in the financial services, high tech, manufacturing, retail, life sciences, and government sectors. Through its partnerships, Resolvit delivers highly impactful, innovative solutions across five core areas: Infrastructure Modernization, Application Development Services, Enterprise Data Management & Analytics, Knowledge & Content Management, and Strategic Staffing. Job Summary Location Atlanta, GA 30383 Posted 12 Days ago Reference code 2365_c9dacec015607cac0570ad3a1e3f9410",
			Company = "Resolvit",
			City = "Atlanta",
			State = "GA",
			PostedDate = new DateTime(2020,1,14),
			MinimumSalary = 83000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "3f641e8fe3057e97b0e2b96a5c15339b",
			Title = "Chief Operations Officer",
			Description = "Overview We are looking for a dynamic and strategic COO that has the heart of a of an entrepreneur, the brain of an operator, and a proven track record in execution to join our senior leadership team. As COO you will help drive strategy fundamentally influencing the direction of the company and oversee the exceptional execution of all operations to ensure we are in position to exceed or meet our top 5 goals. You will also provide strategic leadership in the understanding of the company, commitment to growth and develop strong sr. management that provides exceptional customer service to all our clients. Responsibilities Sales of new business Expansion of existing business Remove Obstacles that prohibit growth Provide a clear understanding & model of company goals and objectives Directs the preparation of short-term and long-range plans and budgets based on broad corporate goals and growth objectives. Provides direction and ownership as to low overhead, improved profitability and overall budget efficiency. Oversees management who direct division activities that implement the organization's policies while supporting the directives of the company Serves as conduit between senior leadership directives and field management executionProvides leadership in overall operations employee satisfaction, specifically in the recruitment and retention of management leaders in the industry and offer them the tools, knowledge and company understanding to be successful. Creates the structure and operations organization to manage the company?s business activities and its projected growth that allows the visibility to talent, an opportunity for advancement and an environment of retention. Maintains a sound plan of corporate organization, establishing policies to ensure adequate management development and to provide for capable management succession. Develops and installs procedures and controls to promote communication and adequate information flow within the organization that is consistent with the culture and directive of the sr. leadership. Establishes operating policies consistent with the Chief Executive Officer's broad policies and objectives and ensures their execution. Evaluates the results of overall operations regularly and systematically and reports these results to the Chief Executive Officer. Qualifications Education and/ or Experience Master?s degree in Business Management, or a related field from a four-year college or university; or equivalent combination of education and experience.Certificates, Licenses, Registrations May be required to have a valid driver?s license. ? #cb Job Summary Location MCCLELLAN, CA Posted 7 Days ago Reference code 7598",
			Company = "SBM Management Services, LP",
			City = "MCCLELLAN",
			State = "CA",
			PostedDate = new DateTime(2020,1,21),
			MinimumSalary = 68000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "05fbf12408a74e45d014c268232e3acf",
			Title = "Editorial Intern",
			Description = "Argus Media Editorial Internship ? Argus is a fast-growing global media company providing essential information to the commodities industries. We are now recruiting current undergraduate or graduate students, or recent grads interested in a paid internship for the summer of 2020 from June 1st to July 31 st . Our Interns will spend time investigating and writing news and analysis while rotating between different markets such as crude oil, refined products, natural gas, petrochemicals, metals, and fertilizers. ? After the duration of the internship, students will have gained a broad understanding of the commodity markets and the key drivers behind these markets, and they will have a portfolio of their news and analysis to take with them. ? Key Responsibilities ? Produce daily or weekly news and analysis on specific markets, for publication online and in our market reports, under the guidance of an experienced editor Attend meetings, conferences and industry events to build contacts, report on news, and represent Argus Contribute to research and special projects as needed Gain a deeper understanding of the Argus business and methodologies, and what goes into being a news or markets reporter ? Knowledge, Skills, and Abilities ? Recent graduate or currently pursuing a bachelor?s or master?s degree with anticipated graduation date of May or December 2020 in journalism, communications, economics, business, or relevant field Excellent written communication skills; experience in journalism is preferred Strong math and analytical skills Excellent interpersonal and relationship building skills Exceptional time management skills; must be able to multitask and meet daily and weekly deadlines Legal authorization to work in the US for any employer ? About Argus ? Argus is an independent media organization with more than 1,000 full-time staff. It is headquartered in London and has offices in each of the world?s principal commodity centers. Its main activities comprise publishing market reports containing price assessments, market commentary and news, and business intelligence reports that analyze market and industry trends. ? Argus is a leading provider of data on prices and fundamentals, news, analysis, consultancy services and conferences for the global crude, oil products, LPG, natural gas, electricity, coal, emissions, bioenergy, fertilizers, agriculture, petrochemical, metals and transportation industries. Data provided by Argus are widely used for indexation of physical trade. Companies, governments and international agencies use Argus information for analysis and planning purposes. ? ? Job Summary Location Houston, TX Posted 2 Days ago Reference code ozr2bfwX",
			Company = "Argus Media",
			City = "Houston",
			State = "TX",
			PostedDate = new DateTime(2020,1,29),
			MinimumSalary = 60000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a22c3e41defdafbd4e1fa2554e3168ac",
			Title = "Supervisor-Flight Program Ft Smith",
			Description = "Overview ? We?re a Little Different ? Our mission is clear. We bring to life a healing ministry through our compassionate care and exceptional service. ? ? We don?t believe in jobs at Mercy, we believe in careers that match the unique gifts of unique individuals; careers that not only make the most of your skills and talents, but also your heart. ? At Mercy, you?ll feel our supportive community every step of your day, especially the tough ones. We?re a team and love working that way. That team is expanding, and we currently have exceptional opportunities to help our communities grow. ? Responsibilities and Qualifications Overview Responsible for the direct supervision of the day-to-day operations of Mercy Life Line Air Medical Program base. Performs related duties as assigned. Ft. Smith Qualifications: Because you?re committed to excellence, you understand the importance of being properly prepared for your role at Mercy. That?s why you?ll bring to your role the right set of qualifications: ? Education: Graduate of a state approved School of Nursing or Paramedic School. Must continue education as?required by Mercy, regulatory agencies and Joint Commission.?Preferable Bachelors degree. Licensure: Must possess a current RN or Paramedic license from each state for which the base they supervise is licensed. Experience: Must meed or exceed all qualifications for the flight nurse position or the flight paramedic position. Previous air ambulance experience is preferred. Supervisory experience is desirable. Certifications: RN must have CEN, CCRN or CFRN. Paramedic must have FP-C after hire. Must maintain BLS, ACLS, MRP, PALS and other critical care certificates and AR EMT is required at Life Line AR licensed bases before completing Life Line orientation. ? We?ll Support You at Work and Home ? Our foundations are built on dignity and respect. Modern Healthcare Magazine named us as a ?top 100 places to work.? We go out of our way to help people feel welcomed.??We offer day-one comprehensive health, vision and dental coverage, PTO, tuition reimbursement and employer-matched retirement funds to benefit-eligible co-workers, including those working 48 hours or more per pay period! ? What Makes a Good Match for Mercy ? Compassion and professionalism go hand-in-hand with us, along with exceptional quality care. Having a positive outlook and a strong sense of advocacy is in perfect step with our mission and vision. We?re also collaborative and are not afraid to do a little extra to deliver excellent care ? that?s just part of our commitment. If that sounds like a fit for you as well, we encourage you to apply. Job Summary Location Fort Smith, AR Posted 2 Days ago Reference code 813553",
			Company = "Mercy",
			City = "Fort Smith",
			State = "AR",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 78000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "779cb17ee69488bff8985d1635cbe807",
			Title = "000013Manager Materials and Logistics",
			Description = "The Materials Manageris responsible for the management of material, transportation and inventoryneeds of the plant. Accountable formeeting monthly goals and analysing the performance of each measurable, whileadministering the department in an efficient and cost effective manner.Establish thedatabase parameters for Material Requirement Planning (MRP) and relatedproduction software systemsEstablish andmaintain business practices, procedures and documentation that ensures controlof supplier releases, incoming material shipments, receiving documents,inventory levels, material storage and movement and shipments to the customerManage andmonitory the activities of subordinates accuracy andintegrity of all materials related to record keepingEstablish goalsand action plans for continued reduction in the cost of transportation, packagehandling, piece price and inventory levelsMonitory andmeasure supplier performance to ensure compliance with established quality anddelivery standardsManage the dataand maintenance of the Bill of Material Database; this includes monitoring theperformance of effective dateimplementation, changes to Billing of Material, and loading of new end itemsMinimizeinventory levels on balance out parts and, when appropriate, submit andobsolescence claimMaintainexcellent customer relations including supplier delivery performanceReview the jobperformance of each subordinate so employee training and development may beutilized per Company policyMaintain compliance of all Yanfengcustoms processes and proceduresConform to all BOS and TS requirementsapplicable to the positionPromote a safe work environment andprevent injuries through the use of, but not limited to, 5S, job rotation, andergonomic work practices. Safetyauditing, tracking of audit closure, participating in incident reviews alongwith writing or assisting in the 8D process and aiding in corrective actionclosure. Communication of safetyinformation as necessary and participation in safety meetings and activities isalso required.Other duties and tasks as assigned by managerEqual Opportunity Employerminorities/females/veterans/individuals with disabilities/sexual orientation/gender identity",
			Company = "Missouri State Job Bank",
			City = "Riverside",
			State = "MO",
			PostedDate = new DateTime(2020,1,11),
			MinimumSalary = 54000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a59a2cb38c048ce9537dc7948fdace7d",
			Title = "Junior Software Developer (Java)",
			Description = "Overview  Staffing Pros, a division of VETS Inc., is recruiting for a full-time Junior Software Developer (Java) to support our client in Charleston, SC.  Responsibilities    Analyzing customer needs and developing overall concept and design objectives.   Create software in a variety of programming and for a variety of IT software applications.   Debugging and correcting errors in computer programs.   Other duties as assigned.   Qualifications    Bachelor's Degree in computer science, electronics engineering or other engineering or technical discipline is required   3 years relevant experience    8 years additional experience may be substituted for education   Must have the ability to obtain a security clearance   Proven experience as a Software Developer/Software Engineer similar role    Familiarity with Agile development methodologies    Experience with software design and development in a test-driven environment    Knowledge of coding languages (e.g. C++, Java, JavaScript) and frameworks/systems (e.g. AngularJS, Git)    Experience with databases and Object-Relational Mapping (ORM) frameworks (e.g. Hibernate)    Ability to learn new languages and technologies    Excellent communication skills    Resourcefulness and troubleshooting aptitude    Attention to detail    EEO Statement Staffing Pros a division of VETS-inc is an Equal Opportunity Employer/Protected Veterans/Individuals with Disabilities. The contractor will not discharge or in any other manner discriminate against employees or applicants because they have inquired about, discussed, or disclosed their own pay or the pay of another employee or applicant. However, employees who have access to the compensation information of other employees or applicants as a part of their essential job functions cannot disclose the pay of other employees or applicants to individuals who do not otherwise have access to compensation information, unless the disclosure is (a) in response to a formal complaint or charge, (b) in furtherance of an investigation, proceeding, hearing, or action, including an investigation conducted by the employer, or (c) consistent with the contractors legal duty to furnish information. ",
			Company = "Veterans Enterprise Technology Solutions",
			City = "Charleston",
			State = "SC",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 76000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "ddb1e13a85ec24892b5e226bb78f6641",
			Title = "Photographer",
			Description = "About Us:  Jamila creative Hub is a Seattle based firm specialized in digital content creation. We are fully equipped with state of the art equipments to execute your project with ease, we also pride ourselves with young creative minds and millennial who think out of the box just to bring your idea to life.  Responsibilities:    Manage photography project schedules and prioritization by conducting weekly scheduling meetings with the creative project managers, production manager and photo team.   Actively participate in design reviews to ensure that photography is aligning with project objectives.   Work directly with the Photographers, Design Director, and Creative Director to ensure deliverables meet all brand standards and requirements.   Attend all photoshoots and manage production on set in adherence to shoot schedule.   Collaborate with retouching/post production team to ensure all images captured are edited and processed on time to meet brand standards and keep look and feel of imagery consistent.   Work with internal teams to obtain photo samples and photographer assistant on props/rentals.   Set a tone for high quality photography standards and produce high quality photography consistently.   Retouch/resize product photos and/or model photos in a timely manner to our specs.    Requirements:    Proficiency in Microsoft Office.   Experience with Adobe Creative Suite a plus.   Self-motivated, able to multi-task and meet tight deadlines.   Work closely with engineering and product teams to proactively identify patterns and large scale issues, and help develop impactful solutions for our creative community   Support and model excellent service by exhibiting a positive attitude and enthusiasm toward the job and the company   Excellent organization and communication skills required   Working knowledge of current photography equipment, tools and software    Bonus Points:    1-2 years of experience in Photography.   Experience in a corporate, formal setting and interfacing with executive-level talent Perk    Perks:  We offer solid benefits to our employees. In addition to a competitive salary, we offer:    Excellent career path   Healthcare plan   Dental plan   Paid holidays",
			Company = "Jamila Creative Hub",
			City = "Albuquerque",
			State = "NM",
			PostedDate = new DateTime(2020,1,17),
			MinimumSalary = 50000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "f38691fd0115173f500790a00f3cfbd0",
			Title = "Senior Flying Probe Test Engineer for Circuit Cards",
			Description = "Job Description     Sr Circuit Card Flying Probe Test Engineer  The BAE Systems Space Circuit Card Factory seek an experienced Test Engineer to perform all aspects of Flying Probe testing, including setting up and validating new test programs for new products, improving the efficiency of production testing, and troubleshoot flying probe test failures to understand root causes. Training of other technicians will occur from time to time. Cross training on other test processes will also happen over time. 5 years or more of Test experience for medium to high complex Circuit cards using the Takaya APT-1400F tool set is a plus. Strong background in electronics and ability to analyses schematics. High level of team work and a can-do-spirit are essential elements to success in this position.  Please note that pursuant to a government contract, this specific position requires US citizenship or Permanent Resident status.    Required Skills and Education     Minimum of 5 years of experience in flying probe testing of medium to high complex circuit card assemblies, including setting up new tool programs for the testing of new products and troubleshoot test failures for root causes  BS Electrical Engineering or similar  Windows based PC proficiency   Preferred Skills and Education      10 years of experience in flying probe testing of medium to high complex circuit card assemblies, including setting up new tool programs for the testing of new products on Takaya ATP 1400-F tool set    Bachelor of science in Electrical Engineering or an equivalent technical degrees in electronics    About BAE Systems Electronic Systems   BAE Systems Electronic Systems is the global innovator behind game-changing defense and commercial electronics. Exploiting every electron, we push the limits of what is possible, giving our customers the edge and our employees opportunities to change the world. Our products and capabilities can be found everywhere - from the depths of the ocean to the far reaches of space. At our core are more than 14,000 highly talented Electronic Systems employees with the brightest minds in the industry, we make an impact - for our customers and the communities we serve.   ",
			Company = "BAE Systems",
			City = "Chantilly",
			State = "VA",
			PostedDate = new DateTime(2020,1,26),
			MinimumSalary = 79000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a53bee24c96aaa9f5926956803146b77",
			Title = "Dental Hygienist",
			Description = "Overview   Under direct supervision of the Health Services Administrator (HSA), Program Manager (PM), or higher medical professional, the Dental Hygienist promotes dental health by completing dental therapy; performing procedures in compliance with the dental practice act.   Qualifications    Education:   ?  Graduate from an accredited Dental Hygienist school   Experience:   ?  Two (2) years' experience  ?  Previous correctional/detention facility experience ?  Five (5) years' experience   Licenses/Certifications   ?  Unrestricted current Dental Hygiene license, certification or registration in state of practice - must maintain all certifications, educational requirements, licensing, etc. ?  Current (and must maintain) lifesaving BLS certification through AHA ?  Current (and must maintain) lifesaving ACLS certification through AHA   Responsibilities    Prepares treatment room for persons served by adhering to prescribed procedures and protocols  Provides information to persons served and employees by answering questions   Maintains instrumentation for dental hygiene treatment by sharpening, sterilizing instruments  Selects materials and equipment for dental hygiene visit by evaluating persons served oral health  Educates patients by giving oral hygiene and plaque control instructions and postoperative instructions  Documents dental hygiene services and dental histories; Document all services provided and refused in persons served dental/medical records  Maintains persons served confidence and protects operations by keeping information confidential  Maintains safe and clean working environment by complying with procedures, rules, and regulations  Protects persons served and employees by adhering to infection-control policies and protocols  Ensures operation of dental equipment by completing preventive maintenance requirements; following manufacturer's instructions; troubleshooting malfunctions; calling for repairs; maintaining equipment inventories; evaluating new equipment and techniques  Conserves dental resources by using equipment and supplies as needed to accomplish job results  Perform other duties as assigned.   Wellpath is an EOE/Minorities/Females/Vet/Disability Employe",
			Company = "Alameda County Santa Rita",
			City = "Dublin",
			State = "CA",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 35000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "ec223d8b541bac1f6052bad5a32e67e0",
			Title = "IT Security Analyst",
			Description = "RESPONSIBILITIES: Kforce has a client in search of an IT Security Analyst in Juno Beach, Florida (FL). Essential Functions: * Participate in incident management and system investigation efforts within proper protocols and legalities * Work with cutting-edge innovative cyber security related technologies * Recommend process and technology related solutions or improvements to protect the company from cyber security vulnerabilities and weaknesses * This position resides in the 24x7 Cyber Incident Response Team (CIRT), a functional group within Cyber Security and Information Technology * The Cyber Security group is responsible for protecting the confidentiality, integrity, and availability of company information and computing networks REQUIREMENTS: * Familiarity with Intelligence Driven Defense related methodologies * Familiarity with Agile project management methodologies * Ability to follow up on security events, reports, and perform investigation and determine root cause and/or escalate concerns to next tier incident response team as needed * Familiarity with any or all of the following technologies; Host-based antivirus, Network malware detonation/sandboxing, Cloud Access Security Broker (CASB) Technologies, Full Packet Capture tools, Intrusion Detection/Prevention Systems (IPS) * Ability to work in a 24x7 environment and participate in working the second or third shift during the week and/or weekends as scheduling requires * Strong understanding of cyber security concepts * Strong understanding of computer networking technologies and architectures * Excellent Customer Service skills * Effective written and oral communication skills * Ability to satisfy service level agreements for support tickets where applicable * Ability to operate under pressure and multitask, must demonstrate strong bias for action, follow-through and personal leadership * Must be willing to travel 10% of the time, work extended hours when needed, and participate in 24x7x365 on-call rotation * Applicants selected will be subject to a government security investigation and must meet eligibility requirements for access to classified information Desired Skills: * GCIH, CISSP, CEH, CHFI, or other SANS GIAC certifications a plus * Ability to work effectively with a team of other Information Security professionals Kforce is an Equal Opportunity/Affirmative Action Employer. All qualified applicants will receive consideration for employment without regard to race, color, religion, sex, pregnancy, sexual orientation, gender identity, national origin, age, protected veteran status, or disability status. - provided by Dice Job Summary Location Palm Beach Gardens, FL 33408 Posted Today Reference code 6874_7e9f6d443b02859bbd0111720d9ec8b8",
			Company = "Kforce Technology Staffing",
			City = "Palm Beach Gardens",
			State = "FL",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 33000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a5f7e754c8f2e6fbab356e981376d617",
			Title = "Morning News Anchor",
			Description = "Make your mark in Broadcasting and Digital Media. Sinclair Broadcast Group and Sinclair Digital Solutions are dedicated to making Sinclair a communications powerhouse! We are the largest and most diversified television broadcasting company in the country. Sinclair owns and operates, programs or provides services to?more television stations than anyone and?has affiliations with all major networks.?Sinclair Digital group is focused on bringing the most engaging content to web, mobile and over-the-top broadcasting to audiences all over the country! Our success is the result of extraordinary employees and an exemplary management team who believe in a vision and are dedicated ensuring a great future for our employees. Whether you are an industry veteran or a just starting out, you can find it at Sinclair!  We are advancing the world of Broadcasting and we want YOU to join our winning team!   ?   KTXS-TV? is? looking for a dynamic News Anchor to lead our morning newscast. The candidate must have strong editorial judgement.?The successful?candidate will have a commanding presence for our morning broadcast. In this role, you will provide content for our broadcast and digital platforms, as well as maintain a robust presence on KTXS' social media pages.   ?    Required Skills:    Excellent Communication skills  Ability/willingness to produce on a fill-in basis  Work with show producer on news content and format  A strong writer  Outstanding editorial skills  The ability to work well with others?  The ability to be a command presence on the desk and in the field  Proven leader and outstanding newsroom citizen  Appear on behalf of the station at public events  A strong understanding of social media   ?   Required Experience :   Previous anchoring experience at a commercial television station is required  Candidate must have?2 years on-air experience  Considerable live shot experience is a must  The ability to multitask and deliver news under pressure in live situations in both newscasts and other programming  Exceptional written communications skills using a conversational writing style  Strong editorial judgment and a proven ethical foundation    ?   Sinclair Broadcast Group, Inc. is proud to be an Equal Opportunity Employer and Drug Free Workplace!  ",
			Company = "Sinclair Broadcast Group",
			City = "Abilene",
			State = "TX",
			PostedDate = new DateTime(2020,1,1),
			MinimumSalary = 59000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "150666d69218f3769594752bceb315b5",
			Title = "Junior Computer Programmer/Developer",
			Description = "Overview SkyePoint Decisions is currently recruiting for key personnel performing tasks associated with our SOW for a pending contract that is in the procurement phase. This role includes a? Junior Computer Programmer/Developer? or?equivalent who works on-site. The Junior Software Architect is responsible for software design, software development, unit/module/integration testing. This role supports the Bureau of Budget and Planning - Performance and Planning System (RPS). This role is contingent upon contract award. ? ? Responsibilities This individual will likely have at least 3?years of experience in software development ?as a Microsoft ASP .Net developer. This individual must know about Software Analysis and Software Design. An understanding of how to design data-driven software applications that interact with enterprise databases. ? Must be able to obtain a ?Public Trust or hold an active security clearance . Experience?in the federal space in an enterprise environment required. Qualifications 3 years of experience in the IT field as a developer or programmer. Experience in a Microsoft ASP .Net enterprise environment as a software developer. Experience using Microsoft Team Foundation Service or Azure DevOps for software configuration.? Understanding of how to design data-driven software applications that interact with enterprise databases. Computer Science Degree preferred. SkyePoint Decisions is an established ISO 9001:2015 and ISO 27001:2013 certified small business headquartered in Dulles, Virginia, with local offices across the Washington, DC, metropolitan area. SkyePoint Decisions has grown into a successful federal contractor by combining industry best practices with innovative solutions that consistently meet or exceed customer requirements. We understand and integrate our customers technology and mission requirements to successfully deliver high quality, cost effective services on time and on budget. ? SkyePoint Decisions empowers a secure dynamic workforce. We leverage our technical competencies (cybersecurity, cloud services, application development, messaging, system & network optimization and more) to provide our customers operating environments with the security, flexibility, availability, and operational continuity required to enable todays on-the-go federal workforce to securely complete any mission.? ? SkyePoint Decisions is committed to hiring and retaining a diverse workforce. We are an Equal Opportunity Employer, making decisions without regard to race, color, religion, sex, national origin, age, veteran status, disability, or any other protected class. U.S. Citizenship is required for most positions. Job Summary Location Washington, DC 20022 Posted 5 Days ago Reference code 2365_f3310adf14abcfddcd9a9c1cc345079b",
			Company = "SkyePoint Decisions",
			City = "Washington",
			State = "DC",
			PostedDate = new DateTime(2020,1,31),
			MinimumSalary = 62000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "67666ebdda270b9e12272a0b0209616e",
			Title = "Licensed Transaction Coordinator",
			Description = "We are seeking a Transaction Coordinator to assist our busy real estate agency. The ideal candidate will have proven excellent customer service skills and will coordinate all aspects of contracts including title/escrow, mortgage loans and appraisal processes. If this sounds like you then we need to talk! We offer a positive, professional working environment where we have each other?s backs. We work hard and play hard. Compensation package is based on experience. If you?re looking for a place to grow your career -- come grow with us!  Responsibilities: Coordinate communication with agents, customers, and other parties regarding all escrow-related paperwork including appraisals, titles, and mortgage loans  Review all documents to verify correct signature and dates assuring that the closing process has been done efficiently and correctly Arrange inspections, assist in negotiations regarding repairs, and coordinate completion of repairs  Manage all administrative aspects of the transaction from contract to close  Assure offers and counteroffers are approved by sellers so the process for our clients is smooth Handle administrative task relating to Real Estate.Follow each transaction through the process from start to closing.Handle phones, and emails on weekends and off hours on a rotating basis.Be willing to handle some out of offices duties relating to transaction needs. Qualifications: A valid Real Estate License is required for this job Prior experience in transaction coordination, real estate, titles, and/or mortgages preferred Able to convey written and verbal information to customers and agents clearly and accurately Is direct, yet helpful in dealing with customer concerns Real estate license preferred  High school diploma or GED required Must have current Arizona Real Estate license.Must have knowledge of Arizona Real Estate.Must have ability to multi task.Must have knowledge of the ARMLS and how to navigate through adding listings and comparing properties.Must have experience as a transaction coordinator.Must know Microsoft Office, and be able to competently take dictation.Must have knowledge of Dropbox, Top Producer, CRM.Compensation determined upon experience About Company   We are a fast-paced office and we are seeking experienced team members. ",
			Company = "The Mark Gunning Team - West USA",
			City = "Mesa",
			State = "AZ",
			PostedDate = new DateTime(2020,1,10),
			MinimumSalary = 36000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "78302d3093adaeff69b5ce29d155519f",
			Title = "Weekend Psychotherapist - Philadelphia, PA",
			Description = "Thriveworks, Licensed Counselor      Part-time, Weekends      Are you a caring, experienced mental health professional? Are you passionate about helping others live happy, successful lives?      Come join our team! Thriveworks Counseling is seeking part-time Licensed Clinical Social Workers (LCSW), Licensed Marriage and Family Therapists (LMFT), and Licensed Professional Counselors (LPC) to join our growing team of highly talented mental health professionals.     Our mission here at Thriveworks is to help people live happier, healthier, more successful lives?or, in other words, thrive! We believe that everyone can benefit from working with a skilled therapist, counselor, or life coach, and strive to ensure that people all across the country have that very opportunity.     Thriveworks is unlike any other therapy practice out there. We provide the scheduling, billing, insurance credentialing, and marketing for our clinicians so that you can focus on what you do best: working with your patients. Additionally, we are extremely selective about who we hire. We aim to employ the best of the best clinicians and support them in their professional journey with the hope that they?ll opt to work with us for life.      Qualifications       License:       Active and unrestricted professional licensure as LCSW, LMFT, or LPC      Experience:       Experience providing psychotherapy to adults, children, adolescents, or couples      Availability :      Available to work weekend shifts. Shifts are somewhat flexible but commonly include:   Morning (roughly 7am-11am)   Afternoon (roughly 11:30-3:30pm), which is always attached to morning or evening shift   Evening (roughly 4pm-10pm)        Great Benefits       Full clinical caseload typically established within the first 90 days   No on-call-shifts   An amazing team culture and clinical support   Professional development opportunities   Career advancement opportunities         Successful Thriveworks employees believe in our mission to help people live happy and successful lives. They also embody our core values, of which focus on the importance of adapting, raising the bar, acting with integrity, achieving our goals, and working together. If you think you fit the bill and belong on our team, apply today! ",
			Company = "Thriveworks",
			City = "Philadelphia",
			State = "PA",
			PostedDate = new DateTime(2020,1,13),
			MinimumSalary = 34000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a031d73f822917568e57c2824926e88b",
			Title = "Home Care Trach and Vent Registered Nurse (RN) - Pediatrics",
			Description = "BAYADA Pediatrics believes that our clients and their families deserve home health care delivered with compassion, excellence, and reliability. If you want to work for a company that cares as much as you do much about healing and helping, here?s your opportunity to make an important and lasting difference in people's lives, and work in a growing and dynamic environment with exciting career paths for nurses like you. As a Pediatric Registered Nurse (RN), you will use your clinical skills to ensure that our BAYADA clients receive the health care they need and deserve in the comfort and safety of their homes. You?ll love working with a team that is dedicated to providing the highest level of care to our clients, and for a company that is deeply committed to your success. ?We have immediate needs for Registered Nurses (RNs) in the following areas: Medford Bayport Ridge Huntington Center Moriches North Babylon Middle Island ? Benefits for Registered Nurse (RN): Competitive wages and weekly pay Health benefits? Paid time off Paid, industry-leading training opportunities Scholarship programs and tuition reimbursement 401(k) with company match Tools needed for your job ? we invest in our care team 24/7 on-call clinical manager support Short commute times ? we match you to cases near your home Flexible scheduling to fit your lifestyle A positive and stable working environment ? Responsibilities for Registered Nurse (RN): Client assessments Training and education of family members Administration of prescribed medication, treatment and therapy Communication with other members of the client?s multi-disciplinary team Supply management Emergency management? ? Qualifications for Registered Nurse (RN): Current New York?RN license in good standing Current CPR certification Minimum one year clinical experience as a Registered Nurse (RN)? Strong organizational and communication skills Pediatrics trach and vent experience is a plus, but not required (industry-leading training available through BAYADA) ? We look forward to speaking with you. Apply now for immediate consideration. ? Founded in 1975 by J. Mark Baiada, BAYADA Home Health Care provides nursing, rehabilitative, therapeutic, hospice, and assistive care services to children, adults, and seniors in the comfort of their homes. Headquartered in suburban Philadelphia, BAYADA employs more than 23,000 field and office professionals who serve their communities in over 20 states from more than 300 offices. BAYADA Home Health Care, Inc. is an Equal Opportunity Employer and qualified applicants will not be discriminated against on the basis of race, color, religion, sex, national origin, disability, or veteran status. Sponsor-SCS ? Job Summary Location Smithtown, NY 11787 Posted 1 Days ago Reference code 5193_4631972002",
			Company = "BAYADA Home Health Care",
			City = "Smithtown",
			State = "NY",
			PostedDate = new DateTime(2020,1,29),
			MinimumSalary = 57000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "889e438b18ee0b1e30e591a022a5642a",
			Title = "Staff Accountant I - Payroll",
			Description = "Overview  Tiffany and Company is currently seeking a Payroll Staff Accountant out of our Parsippany, NJ offices.The Payroll Staff Accountant is responsible for recording, analyzing and reconciling all US and Canada payroll related activities and working closely with third party vendors to ensure timely and accurate payroll tax deposits/filings. The Staff Accountant will assist in processing various special pay-cycles (i.e. commissions, annual relocation, etc.), and administer day-to-day management of deferred and equity compensation related tasks. In addition, the Staff Accountant will complete various reports and analyses in support of internal/external business partners.  Responsibilities    Record, analyze and reconcile the Companys US and Canada payroll related transactions.    Work with third party vendors to ensure weekly payroll tax deposits and related files are transmitted timely and accurately.    Complete multi-worksite reports, work with AP to pay invoices, participate in quarterly/annual tax filings and Sarbanes-Oxley key control reviews.    Support internal/external business partners with various reporting and analyses.    Identify opportunities to enhance department processes, reporting and analysis.    Process special pay-cycles (i.e., monthly commission and quarterly commission bonus, annual relocation, bi-monthly RSU pay-cycles, etc.) and perform related analytical review to ensure proper financial recording.    Responsible for processing deferred and equity compensation related tasks. Including day-to-day system maintenance, file transmission, payments, and tax calculations. Partner with Accounting & Reporting in periodic balance review and reconciliations.    Participate in special projects as requested.    Qualifications    Four year degree in an Accounting or Finance discipline    Analytical and organizational skills    Proficient in Excel and Microsoft Office Suite    Strong oral and written communication Skills    Flexible work schedule is a must    Preferred Qualifications    1+ year US/Canada payroll related experience    Previous JD Edwards experience    CPA or pursuing certification    LI-POST7  LocationUS-NJ-Parsippany  Posted Date1 day ago(1/22/2020 2:10 PM)  Req #41590  CategoryAccounting/Finance",
			Company = "Tiffany & Co.",
			City = "Bernardsville",
			State = "NJ",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 63000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "913da42d6328f94f44c1613b827419f9",
			Title = "Consolidated Afloat Networks and Enterprise Services (CANES) Technical Instructor",
			Description = "Description Science Applications International Corporation (SAIC) currently has an opening for a Training Analyst. A challenging instructor position that equips students with the knowledge and skills to perform operations, system administration, network monitoring, fault isolation and system restoration of the Consolidated Afloat Networks and Enterprise Services (CANES) and/or Integrated Shipboard Network System (ISNS). Responsibilities include: Provide subject matter expert support for Personnel Qualifications System (PQS), job qualification requirements and other workshops in support of maintenance control for CANES/ISNS Implement and execute training courses using standardized practices and procedures to train military personnel Provide subject matter expertise to develop, test, and maintain curriculum Conduct individualized and classroom/lab/afloat training sessions, work on problems of diverse scope, and may determine methods and procedures for improving the training environment and curriculum Interact on a daily basis with customers and other stakeholders Train military personnel or civilian equivalents and other system administrator personnel in the data, transport , voice and video services, systems management, cyber security, configuration, administration, and troubleshooting for CANES/ISNS Instruction includes labs that reinforce the information discussed. System troubleshooting provides further understanding of the interaction of all system components Qualifications Bachelors degree and 0 years related experience; additional years of experience will be considered in lieu of a degree. Must have an active Secret security clearance; and must be able to obtain a TS/SCI security clearance Formal military training or three (3) years of experience on one or more of the following: Consolidated Afloat Networks and Enterprise Services (CANES) system; Integrated Shipboard Network System (ISNS) (4.0.1 variant) Current IA certifications including CompTIA Security+ or be able to obtain in first 6 months of employment Familiarity with DoN personnel security and physical security policies and procedures Excellent communication skills, both verbal and written Proficient hardware and software troubleshooting skills Applicant must be able to travel up to 25% of the year to both CONUS and OCONUS locations Desired Qualifications Instructor experience including formal instructor training, such as the Navy's Basic Instructor Training or Journeyman Instructor Training; or a current industry standard Trainer Certification, such as Microsoft Certified Trainer (MCT) or CompTIA Certified Technical Trainer (CTT+). Current IA certifications including CompTIA Security+. Job Summary Location United, CA 15689 Posted Today Reference code 6874_8ef7aa89235bc50954096856513ff10c",
			Company = "SAIC",
			City = "United",
			State = "CA",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 65000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "2e661dd81833349e4fb00232775d5492",
			Title = "Sustainability Intern",
			Description = "About TLC Engineering:   TLC has earned its reputation for excellence operating for more than 64 years. We are a full service engineering design firm with focus on large facility design including education, federal, municipal, laboratory and related facilities. Refer to www.tlc-engineers.com  TLC Engineering Solutions is a dynamic and growing National Engineering firm seeking qualified and motivated Mechanical interns to gain knowledge and experience with the planning, designing and production of mechanical engineering components of commercial projects.  The Intern or CO-OP Student will have the opportunity to work at applying academic education to assigned tasks. He/she is provided an opportunity for on-the-job training and given specific tasks to encourage learning the basics of ABS/ADT/RVT and design.   Responsibilities   The Intern or CO-OP Student works under the direction of a senior staff member who has the authority to exercise control over the design and production tasks.  The Intern/CO-OP Student works with all staff members in various roles, pitching in to do any task within their capabilities required at the specific time. The Intern/CO-OP Student reports to the Project/Senior Engineer with additional review provided by the Director or other designated staff member.  The Intern/CO-OP Student is responsible for the complete performance of the assigned tasks and for asking questions of knowledgeable engineers or technicians when necessary to ensure that the work is completed accurately and on time. Tasks are more administrative or production oriented than technically complex. The guidelines, practices, and policies of the discipline, division and firm must be followed.   Qualifications      Current student at an accredited university of college   Desire to pursue a career in consulting engineering   Computer software knowledge, as appropriate     TLC is an Equal Opportunity, Affirmative Action employer, dedicated to Workforce Diversity EOE- M/F/Vets/Disabled. All qualified applicants will receive consideration for employment without regard to race, color, religion, sex, sexual orientation, gender identity, national origin, veteran status, disability, age and other classifications covered under federal, state or local laws. TLC participates in E-Verify.   PI116905756",
			Company = "TLC Engineering Solutions",
			City = "Orlando",
			State = "FL",
			PostedDate = new DateTime(2020,1,7),
			MinimumSalary = 69000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "9a1b2ef2420ac15cc67e61ab3b5346ea",
			Title = "Surgical Technologist-Operating Room",
			Description = "Looking for your next opportunity? If so, choose Parkland and discover what a meaningful job feels like. Whether you work directly with patients or use your talent to support our care, you?ll be part of a team that?s providing valuable health services to Dallas County residents. And here, you?ll have the opportunity to put all your skills to work, and the support to grow and advance in your job and your field. Step into a career that will make a substantial difference for our patients?and for you. We blend cultures, talents, and experience into an exemplary health and hospital system.? Parkland has earned distinction as one of America?s Best Hospitals by U.S News and World Report every year since 1994. PRIMARY PURPOSEPrepares operating rooms for surgery, provides technical services, assists during routine surgeries, and maintains documentation to ensure activities meet operating room and Parkland requirements. MINIMUM SPECIFICATIONSRequirements for Practicing Surgical Technology in the State of Texas (per Texas H.B. 643-Chapter 259):EducationNoneExperience:-NoneAdditional Certification/Registration/Licensure:      In addition to State of Texas requirements (above)-Must have current Health care provider CPR course completion cardf rom one of the following:oAmerican Heart Association oAmerican Red Cross Rescuer oMilitary Training NetworkSkills or Special Abilities:-Must be able to demonstrate a basic working knowledge of surgical equipment, instruments and procedures.-Must be able to set priorities and perform under stressful situations. -Must be able to demonstrate knowledge in use of aseptic techniques.-Must be able to recognize and correct immediately any breaks in aseptic technique.-Must be able to communicate effectively, both orally and in writing.-Must be able to work a change in shift, or flexible hours when the work requires such changes. -Must be able to communicate effectively with hospital staff.-Must be able to demonstrate patient-centered/patient-valued behaviors.  Parkland Health and Hospital System prohibits discrimination based on age (40 or over), race, color, religion, sex (including pregnancy), sexual orientation, gender identity, gender expression, genetic information, disability, national origin, marital status, political belief, or veteran status.",
			Company = "Parkland",
			City = "Dallas",
			State = "TX",
			PostedDate = new DateTime(2020,1,15),
			MinimumSalary = 69000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "5a3d009ceb13d1655a94a882718fca58",
			Title = "Associate Data Visualization Engineer",
			Description = "Company Description  What do we do at Karmak? We create dealer management systems (DMS) software for the heavy-duty trucking and automotive industries. Walk into any auto or truck dealership or parts/service shop, and they?ll access a DMS to check their inventory for a new sale or schedule your vehicle for an oil change. At Karmak, our team of industry experts design, develop, train, and support DMS systems that provide visibility, control, and cost savings to our customers. We are innovative problem solvers ? in software as well as Sales, Marketing, Consulting, Support, Training, and more ? and we?re always looking for bright, curious minds to join our team.  Job Description  The Associate Data Visualization Engineer is responsible for creating reports to analyze and display the data within our business systems. This position will determine the best formats to use, to display the data within the reports and troubleshoot existing reports.? This position will also assist on the support of all Reporting Tools that Karmak provides to our Customers. Candidate must be able to:   Learn various Reporting Development tools that are used to create reports  Gather information for the reports and assist in the creation of requirements and functional specifications  Create SQL database objects and write and maintain SQL queries  Troubleshoot existing reports and issues in reporting tools (defects, performance, etc.)  Integrate the reports with user interface  Work independently or within a small team with a focus on helping clients formulate proper business concepts, interface design and content presentation   Qualifications   Ability to learn the Karmak Fusion Business System quickly  Ability to learn Microsoft SQL Server, which including querying the database, debugging and updating SQL Views and Stored Procedures.?  Must be detail-oriented and possess multi-tasking skills    Ability to communicate (oral and written) and understand the needs of the customer  Strong organizational and software skills  Must be able to document the needs and requirements of both internal and external  A bachelor?s degree is preferred.? In the absence of a degree, additional related experience is required   Additional Information  All your information will be kept confidential according to EEO guidelines.",
			Company = "Karmak",
			City = "Carlinville",
			State = "IL",
			PostedDate = new DateTime(2020,1,9),
			MinimumSalary = 57000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Communications"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "bf9fbc84e92bd95d48de8141f0a45837",
			Title = "SDET (Software Development Engineer in Test) Multiple Roles",
			Description = "York Solutions is currently seeking an experienced SDET for a team we're building for one of our clients in the Minneapolis, MN area. The ideal SDET candidate will have experience with Selenium, Java, and Cucumber. Needed Experience: -Understand framework design -Selenium is needed -Cucumber -Heavy Java knowledge Responsibilities: Create, document, execute and maintain test plans to perform functional, load and performance tests for large-scale, complex software systems. Design and implement test automation programs using Scala/Java/Erlang, SQL and scripting languages. Build new tools and improve existing test infrastructure to expand regression coverage. Work closely with product and engineering teams to understand business requirements and architecture of software systems. Participate in the development lifecycle including product requirement and design review process. Work closely with cross-functional teams to identify dependencies and hand-offs for performing end-to-end tests. Drive and track organizational level quality metrics. Qualifications: Bachelor's Degree At least 3 years of experience as Software Engineer, Software Development Engineer-Test, Quality Engineering or related. Experience testing large scale distributed applications, webservices or RESTful APIs. Experience developing test automation frameworks using open source tools. Experience with system integration testing, performance/stress testing and UI interfaces Experience programming in object-oriented/functional/scripting languages like Java, Scala, Erlang, Python, SQL. Experience with internet-scale distributed technologies and concepts, object-oriented methodologies, databases, and Unix-based systems. About York: Our mission at York Solutions is to always have a positive impact on the lives, the careers, and the future development of IT professionals within the communities we serve. With over 25 years of experience, we are a veteran-owned IT consulting firm that uses a non-transactional, value-based approach to provide clients with custom workforce solutions to achieve business, technology, and operational goals. Using a strategic partnership approach with our clients, York Solutions focuses on fostering a long-term, trust-based relationship. In addition to working with companies, we work with IT professionals to find the right company and role for their skills, while also working with them through professional development programs like our association, Think IT, and our Link to Leadership program. Finally, we are dedicated to furthering an equal-opportunity workforce through our community involvement with our partner, Genesys Works, and through our own Barriers to Entry Program. - provided by Dice Job Summary Location Minneapolis, MN 55401 Posted Today Reference code 6874_a3373e5d441fde7dfecf35c718773d12",
			Company = "York Solutions, LLC",
			City = "Minneapolis",
			State = "MN",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 64000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "76970e183d4fe8886317f1de116faeee",
			Title = "Manager, Plant Operations, REQ 21329, Per Diem",
			Description = "Job Description    Location:  Holy Family Hospital   Posted Date:  1/17/2020     Summary:   In collaboration with Hospital senior management, is responsible for the administration of all departmental programs and services relating to functional maintenance, system operations and utility services. Under the general direction of the Director of Facilities, the Manager of Facilities and Maintenance is responsible for the development and administration of planning, design and construction of the facility. He/she is primarily concerned with the implementation of the organization's short and long-term facilities plan. He/she is responsible for representing the owner during the programming, design and construction phases of major building projects, internal renovations, and changes to existing structures. The Manager of Facilities and Maintenance must ensure that senior management is apprised of current project schedules, costs and that the owner's goals and interests are being achieved. Establishes and directs departmental goals and objectives in accordance with those of the Hospital administration to provide and assure the basic needs for the welfare, comfort, and safety of patients, visitors, and staff as they relate to maintenance, repair, operation, and modification of all hospital buildings, grounds, mechanical and electrical systems and equipment.   Qualifications:    Education:  ? Degree in Engineering. Additional graduate level or management courses preferred. ? Familiarity with NFPA and JC standards, and with building codes and other government regulations.   Experience:  ? Duties involve a broad background with four to five (4 - 5) years in plant maintenance or construction, and/or engineering. ? Four to five (4 - 5) years' management level experience in related or, preferably, hospital field. Knowledge of all building trades as well as procedures for preparation of construction documents.   Staff Oversight:  ? Supervises Maintenance staff of 10 to 15 unionized facilities/trades employees.   Certification/Licensure:  ? License in one of the major trades (electrical, plumbing, HVAC, building, etc., would be desirable) and/or equivalent related experience working within a trade. ? Courses in rules and regulations with various governing agencies, i.e. NFPA, OSHA, MWRA, DEP, DMH, DPH, Building Codes. ",
			Company = "IASIS Healthcare",
			City = "Methuen",
			State = "MA",
			PostedDate = new DateTime(2020,1,18),
			MinimumSalary = 50000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Executive"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "75a4cbeac93946a00da7d6acb951530d",
			Title = "NJATCSU App Systems Analysis/Prog. Mgr 4-UI/UX Designer",
			Description = "Role: NJATCSU App Systems Analysis/Prog. Mgr 4-UI/UX (618033) Client: State of New Jersey (Judiciary) Location: Trenton, NJ Duration:8 Months Interview Type: In Person Only Job Description: 1st Phone Interview Only 2nd In-Person Interviews Only - No exceptions All work will be performed on-site No Exceptions PLEASE READ ENTIRE DESCRIPTION BELOW. SUMMARY: Work experience in UI/UX design patterns Work experience creating user stories, personas and storyboards Determining information architecture and creating sitemaps Work experience creating prototypes and wireframes Work experience conducting usability testing Work experience interpreting requirements to create UI designs Qualifications and Skills: Solid understanding of user experience design Fluent in user-centered design best practices Excellent interpersonal and communication skills Empathy (Must be able to understand or feel what people are experiencing from their frame of reference) Logic and reasoning skills Detailed oriented Critical thinker Design thinking / visualization skills Ability to hear and accept feedback Storytelling and presentation skills Should have extensive knowledge of the following Adobe products: XD, Photoshop, Illustrator, InDesign, Dreamweaver Should have extensive knowledge of web development including HTML5 and CSS3 Knowledge of the Pega platform is desirable Knowledge of state court systems is desirable The ideal candidate can: Collaborate with different teams Negotiate with users and team members Train staff on the user of UX/UI design and tools Responsibilities: Resource will require the skills to perform the following job duties (plus other related duties as assigned) Planning and conducting user research. Interpreting data and qualitative feedback Creating user stories, personas and storyboards Determining information architecture and creating sitemaps Creating prototypes and wireframes Conducting usability testing Note: Candidate will have the opportunity to work with a Pega UI/UX consultant and have opportunity to learn about Pega UI/UX. 4 year degree or equivalent technical study. Skill Required / Desired Amount of Experience Adobe XD Required 1 Years Photoshop Required 4 Years Illustrator Required 4 Years InDesign Required 4 Years Dreamweaver Required 4 Years HTML5 Required 4 Years CSS3 Required 4 Years Pega Platform Desired 1 Years Excellent verbal and written communication skills with the ability to collaborate with internal and external groups Required 4 Years 4 year college degree or equivalent technical study Required 4 Years Overall technical and IT experience Required 5 Years Experience designing and documenting User Interface and User Experience Required 4 Years - provided by Dice Job Summary Location Trenton, NJ 08601 Posted Today Reference code 6874_89fd250a4e2018c9dfe1b797ebd8d2be",
			Company = "INSI CLOUD",
			City = "Trenton",
			State = "NJ",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 92000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Higher Ed"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "3491061bc0d3687d90a597183136e7f8",
			Title = "Branch Manager Home Care",
			Description = "Branch Manager Summary Come join BrightStar Care, a team that believes in serving with a passion and doing the right thing. The Branch Manager will lead, manage, and hold all branch staff accountable to deliver consistent, safe, compassionate, and high-quality care to each client. The Branch Manager is responsible for overall branch operations and is accountable for all personnel, both office and field staff. BrightStar is looking for a self-driven, high-energy individual to lead a highly motivated team of medical staff and office staff. This full time position is a rewarding opportunity to provide care in the homes of those who need it. Benefits * Competitive pay * Weekly direct deposit * PTO * Insurance options * Tight-knit team environment * Work life balance * Advancement opportunities * International opportunities with over 300 locations in the US ? Responsibilities * Client and customer care ? effectively manage the customer care managers (CCMs) and all customer/client relations * Recruitment ? implements and executes active, ongoing recruitment strategies to attract the best field staff and branch office staff * Payroll, scheduling, billing, and coding management ? Supports and uses all technology tools and resources to ensure proper business processes * Accreditation and compliance ? enforces and maintains all Joint Commission accreditations standard of excellence and complies with all federal, state, and local regulations, as well as employment laws and practices Requirements * High School Diploma required * Associates and/or Bachelor Degree in Business Management or Administration; may substitute Degree requirement with a combination of education/experience; and minimum of 2 years? experience as Branch Manager and/or managing sales, customer service, and human resources functions within an office setting. * CPR Certification * 1-2 years? experience using major brand payroll software/payroll provider (e.g. PeopleSoft, PayCom, Oasis, ADP preferred) * 2-3 years managing a high-volume healthcare office branch or agency or 3-4 years managing a similar branch or agency operations with a strong customer relations and quality of work culture * 1-2 years sales management experience * 2-3 years managing people and effectively scheduling staff at all levels (supervisory, per diem staff, full-time, and part-time employees) * Valid driver?s license * Valid state required proof of auto insurance * Experience managing within a healthcare environment supervising field staff, LPNs, CNAs, and RNs is highly desired. ? We are an Equal Opportunity Employer and do not discriminate against applicants due to race, ethnicity, gender, veteran status, or on the basis of disability or any other federal, state or local protected class. Job Summary Location Columbia, SC Posted Today Reference code 371433",
			Company = "BrightStar Care Columbia",
			City = "Columbia",
			State = "SC",
			PostedDate = new DateTime(2020,1,30),
			MinimumSalary = 63000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "dce786aa4668a31ffea3209c8a4bcbee",
			Title = "Technical Writer",
			Description = "Our Government client is looking for an experienced  Technical     Writer  on a 3 months renewable contract role     in Richmond, VA.    Position: Technical Writer   Technical Writer with experience documenting help documentation for a   web-based application. The project is approaching implementation and a   resource is needed to document the help screens for the new application.  Knowledge:   Broad diversified background in information technology, business     systems analysis, technical environments, and application project     management in an enterprise environment.  Strong understanding of technical terms.  Exceptional knowledge of providing online help to users of a new system.   Ability:   To create online help for each field for each screen.  To create online help instructions that are easy to understand and     easy to follow with the goal of completing a transaction without     requiring assistance.    Required / Desired Skills    5 years of Experience translating complex technical information     from many sources into clear and concise documentation both in     writing and graphical format Required  5 years of Ability to work with staff from various     technical/non-technical areas and at all levels Required  5 years of Attention to detail with respect to grammar, spelling,     and other editing errors experience Required  5 years of Ability to handle sensitive information and material in     compliance with internal/external security requirements Required  5 years of Proven ability to meet aggressive timelines experience Required  5 years of In-depth knowledge of Microsoft office products (word,     excel, visio, etc) experience Required    About Vector:   Vector Consulting, Inc., (Headquartered in Atlanta) is an IT Talent   Acquisition Solutions firm committed to delivering results. Since our   founding in 1990, we have been partnering with our customers,   understanding their business, and developing solutions with a   commitment to quality, reliability and value. Our continuing growth   has been and continues to be built around successful relationships   that are based on our organization's operating philosophy and   commitment to ** People, Partnerships, Purpose and Performance - THE   VECTOR WAY    Celebrating 25 years of service",
			Company = "Vector Consulting, Inc",
			City = "Richmond",
			State = "VA",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 90000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Communications"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "1d30ad884a621f5da163bd595d9d2c53",
			Title = "Principal Data Scientist, Bioinformatics",
			Description = "At Roche Sequencing Solutions, we are driven to transform healthcare with next-generation sequencing (NGS) technologies and applications. We are seeking a self-motivated Principal Data Scientist, Bioinformatics to join our Nanopore Sequencer Data Science group, where we collaborate with experimentalists and algorithm developers to build the Roche single-molecule DNA sequencer. If you enjoy working in cross-functional teams, applying data analysis skills to develop creative solutions, and driving bioinformatics deliverables for product development, we want to hear from you! Responsibilities: Collaborate with scientists and other engineering groups, understand their data-science and bioinformatics requirement and propose solutions and lead them to completion. Help design, analyze, and interpret single-molecule sequencing experiments using custom and standard analysis tools. Develop and improve algorithms for next-generation sequencing based diagnostics products. Develop and modify analyses that depend on standard next-generation sequencing analysis tools. Write clean, maintainable, documented code using best engineering practices in the industry (design patterns, TDD, peer review, CI, automated testing etc.). Prepare documentation and participate in design reviews. Define in-depth statistical error profiles and their impact on secondary and tertiary analysis. Document analysis procedures and results and present findings in meetings. Utilize knowledge of bioinformatics, including machine learning, statistical modeling, and data visualization to help analyze and develop sequencing technology. Requirements: PhD in Bioinformatics, Biostatistics, Computation Biology, Computer Science or related technical/scientific field with a minimum of 2 years of direct related professional experience. Or, equivalent combination of education and experience to perform at this level. Experience in the use of high-level programming languages such as Python (preferred), Java and R for complex data analysis. Experience with data visualization and report generation. Experience with next generation sequencing a plus. Who we are At Roche, 94,000 people across 100 countries are pushing back the frontiers of healthcare. Working together, we've become one of the world's leading research-focused healthcare groups. Our success is built on innovation, curiosity and diversity. Roche is an equal opportunity employer and strictly prohibits unlawful discrimination based upon an individual's race, color, religion, gender, sexual orientation, gender identity/expression, national origin/ancestry, age, mental/physical disability, medical condition, marital status, veteran status, or any other characteristic protected by law. Job Summary Location Santa Clara, CA 95053 Posted 1 Days ago Reference code 2365_68e0e7cd0a006b74ffa8809ad07b1f4a",
			Company = "Roche",
			City = "Santa Clara",
			State = "CA",
			PostedDate = new DateTime(2020,1,27),
			MinimumSalary = 32000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "217fa43ec6d0e5f0596468f26fc39de1",
			Title = "Business Analyst- Banking",
			Description = "MINIMUM QUALIFICATIONS    Must have a minimum of at least 5 years at a Financial Institution.  Must have experience as a business analyst handling the following     types of functions: writing requirements, documenting workflows, researching.  Must be able to travel up to 10% for onsite client visits,     additional training, user conferences and development meetings.    PREFERRED QUALIFICATIONS    Bachelor s Degree.  Experience with Commercial/Retail or Consumer Loan Underwriting.  data mapping experience.  quality assurance testing experience.    ESSENTIAL FUNCTIONS    Researches, analyzes, creates, and maintains applicable Policies     &amp; Procedures.  Manages department processes to ensure compliance and that     deadlines are met.  Defines, documents, and publishes processes. Observes existing     practices across multiple departments with similar functions and     looks for opportunities to optimize practices and processes.  Supports collection and interpretation of business information.  Diagrams and evaluates existing processes.  Collects data to identify root cause of problems.  Develops metrics that provide data for process measurement,     identifying indicators for future improvement opportunities.  Measures performance against process requirements. Aligns     improvement to performance shortfalls.  Performs Impact Analysis of all recommended changes and standards.     Presents and defends recommendations to mid-management and senior     level management.  Interrelates KPIs and adjusts business variables to improve the     effectiveness of the measurements used.  Analyzes trends and provides correlated studies of potential     changes and outcomes.  Participates in post-project reviews to determine effectiveness,     pertinence and timeliness of newly recommended processes. Identifies     processes that are effective and works to change processes in need     of further refinement.  Provides consultation on the use of re-engineering techniques to     improve process performance and product quality. May deliver     presentations and training courses including measurement, analysis,     improvement and control.  Analyzes high volumes of data from multiple sources.  Tracks the appropriate market space.  Performs Cost-Benefit and other forms of analyses. ",
			Company = "Powermind Solutions Inc",
			City = "Gardena",
			State = "CA",
			PostedDate = new DateTime(2020,1,21),
			MinimumSalary = 60000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "bc56fcd4ba43ab9028af4233afb17c37",
			Title = "PT Technician (PRN) - PhysioFit Physical Therapy - Gause, LA",
			Description = "JOB SUMMARY:  Under the direct supervision of a licensed Physical Therapist or Occupational Therapist, performs client treatment programs and activities as prescribed and provides technical assistance regarding therapeutic programs, methods, and equipment, in accordance with company policies and procedures. This position is responsible for supporting the mission, vision and values of the company.   QUALIFICATIONS - Required:   1. Education - High School Diploma or equivalent. 2. Skills - Ability to communication effectively, knowledge of physical therapy equipment and care, ability to follow written and oral instruction, ability to assist and prepare patients for treatment with various therapy exercises and equipment.   JOB FUNCTIONS:    Patient Care Activities - To include use of hot packs and cold packs, performance of therapeutic US as directed by the Physical Therapist, supervising exercises that have been previously taught by the Physical Therapist, disconnecting patients from electrical stimulation units, assisting patients in setting exercise equipment, use of dumbbells, theraband, etc., transcribe information in the charts (checking off the exercise flow sheet by recording reps/weights, writing the name/date/ICD-9 code on billing sheets after the initial evaluation of the patient and other pertinent activities as deemed necessary.  Clinical Duties - To include laundry-wash, dry, and fold, clean tables in between patient use, stocking carts with towels, pillowcases, etc.; cleaning of the exercise equipment at least once a day and more frequently as warranted, assisting with the tidiness of the clinic as needed to include emptying trash, vacuuming, straightening up the waiting room and other duties as deemed necessary.  Office Duties - To include answering phones/how to operate the phones, how to take a referral, how to schedule patients including documenting cxl, NS and R/S of patients, how to take a co-pay/patient supply order, where to locate a supply for the clinic or for patient purchase, how to locate charts in the chart drawer, where necessary paper work is located, how to make up a new chart, how to use copiers/fax machine, how to administer initial evaluation paperwork and other tasks deemed necessary.    Upstream Rehabilitation is an Equal Opportunity Employer",
			Company = "Physiofit Physical Therapy",
			City = "Gause",
			State = "LA",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 34000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "1e3adfe85505996e7730d6ccd79866e7",
			Title = "Commercial Banking Assistant III",
			Description = "Requisition Number 20-0075 Post Date 1/27/2020 Title Commercial Banking Assistant III Location Newport News City Newport News State VA Description Position Description The Commercial Banking Assistant III performs a variety of duties in support of the Commercial Banking Line of Business. They work closely with Commercial Relationship Managers, Portfolio Managers, internal department personnel and external customers to complete a variety of tasks associated with the origination and servicing of loans. They ensure the timely renewal of existing loans, mitigate loan exceptions and assist with the growth and management of cash management products and services. Position Accountabilities: ? Service personal and commercial deposit accounts according to guidelines and procedures ? Monitor daily non-sufficient funds reports, obtain necessary approvals and communicate to retail as needed ? Handle daily incoming customer requests and inquiries in a professional manner ? Process payments and advances on loans ? Perform account maintenance and research as needed ? Prepare post closing loan packages to include maintaining files and clearing exceptions ? Adhere to all applicable laws and regulations governing bank operations ? Image or file financial statements and documents as needed ? Perform preliminary loan closing requirements such as to include flood certifications, credit reports, residential appraisals, environmental reports, UCC searches or other reports as needed ? Prepare tickets and/or wire transfers as needed ? Process draws which may include title updates and inspections ? May administer and monitor construction and development loans ? Prepare payoff quotes and handle releases ? Assist with review of loan packages for other Commercial Banking Assistants ? Performs other duties as assigned Organizational Relationship: This position reports to the Commercial Support Group Manager Requirements Position Qualifications Education &amp; Experience: ? High school diploma or equivalent, college degree preferred ? Five plus years commercial or retail banking or industry related experience required ? One to three years of commercial loan experience required Knowledge &amp; Skills: ? High level of proficiency in LaserPro ? Superior customer service skills ? Excellent computer skills relevant to Microsoft Office Suites ? Excellent communication skills ? Well organized with attention to detail ? Ability to prioritize and manage multiple priorities ? Flexible, able to adapt to change ? Superior time management and problem solving skills ? Ability to work independently as well as within a team environment ? Analytical skills We are proud to be an EEO/AA employer, Minority/Female/Disability/Veteran. We maintain a drug-free workplace Job Summary Location Newport News, VA Posted 1 Days ago Reference code *599A110602A2F4C3",
			Company = "Union First Market Bank",
			City = "Newport News",
			State = "VA",
			PostedDate = new DateTime(2020,1,28),
			MinimumSalary = 48000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "22c8fc25ce8c64ccf9445beb529aa525",
			Title = "Network Engineer",
			Description = "Double Fine has an immediate opening for a full time, permanent Multiplayer Network Programmer for its San Francisco development studio to work on an unannounced game. You?ll be responsible for the design, development and maintenance of server architecture, core systems and gameplay features for an online multiplayer game.       Applicants should have a strong preference for working in a highly creative, innovative, and nimble development environment, where collaboration with design, art, tech, production, and other disciplines is standard.   ?   Knowledge or experience with the Unreal Engine is a strong plus, as is previous experience supporting game features and/or development tools. Good problem solving skills, the ability to work well and communicate effectively with others, and a passion for the process of developing creative, high-quality games are all key qualifications.        Responsibilities:      Designing, implementing, and supporting key multiplayer gameplay features using Unreal Engine 4.   Creating well documented and highly optimized code in C++.   Debugging bugs and optimizing performance for multiple platforms.   Being the primary driver of best practices around network capabilities and restrictions.        Requirements:        Minimum of 3 years of professional experience with modern game engines, preferably working on multiplayer game systems.   Experience developing gameplay systems between server and client   Understand different game networking models and the pros and cons of each   Ability to communicate and collaborate effectively with programmers, artists and designers.   Ability to write clean, readable, reliable, documented and portable code.   Passion to learn, grow and share information with your co-workers.   A strong passion for online games/services and/or video game development.       Plusses:      2 or more years of professional experience working with Unreal Engine 4.   Development experience on the current generation of consoles, particularly Xbox One, and enthusiasm to develop for next gen consoles.   Experience implementing analytics systems to measure game design feature performance   Experience using Blueprints in Unreal Engine 4.   Experience in other programming languages in addition to C++.   Experience working with external APIs or SDKs.",
			Company = "Double Fine Productions, Inc.",
			City = "San Francisco",
			State = "CA",
			PostedDate = new DateTime(2020,1,8),
			MinimumSalary = 86000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "4f1df66d347561120877e4b772da3962",
			Title = "Technician - OSS Powder Mill - York, PA",
			Description = "JOB SUMMARY:  Under the direct supervision of a licensed Physical Therapist or Occupational Therapist, performs client treatment programs and activities as prescribed and provides technical assistance regarding therapeutic programs, methods, and equipment, in accordance with company policies and procedures. This position is responsible for supporting the mission, vision and values of the company.   QUALIFICATIONS - Required:   1. Education - High School Diploma or equivalent. 2. Skills - Ability to communication effectively, knowledge of physical therapy equipment and care, ability to follow written and oral instruction, ability to assist and prepare patients for treatment with various therapy exercises and equipment.   JOB FUNCTIONS:    Patient Care Activities - To include use of hot packs and cold packs, performance of therapeutic US as directed by the Physical Therapist, supervising exercises that have been previously taught by the Physical Therapist, disconnecting patients from electrical stimulation units, assisting patients in setting exercise equipment, use of dumbbells, theraband, etc., transcribe information in the charts (checking off the exercise flow sheet by recording reps/weights, writing the name/date/ICD-9 code on billing sheets after the initial evaluation of the patient and other pertinent activities as deemed necessary.  Clinical Duties - To include laundry-wash, dry, and fold, clean tables in between patient use, stocking carts with towels, pillowcases, etc.; cleaning of the exercise equipment at least once a day and more frequently as warranted, assisting with the tidiness of the clinic as needed to include emptying trash, vacuuming, straightening up the waiting room and other duties as deemed necessary.  Office Duties - To include answering phones/how to operate the phones, how to take a referral, how to schedule patients including documenting cxl, NS and R/S of patients, how to take a co-pay/patient supply order, where to locate a supply for the clinic or for patient purchase, how to locate charts in the chart drawer, where necessary paper work is located, how to make up a new chart, how to use copiers/fax machine, how to administer initial evaluation paperwork and other tasks deemed necessary.    Upstream Rehabilitation is an Equal Opportunity Employer    ",
			Company = "Upstream Rehabilitation",
			City = "York",
			State = "PA",
			PostedDate = new DateTime(2020,1,16),
			MinimumSalary = 70000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "c96885a246db10b72123e512c1503c74",
			Title = "Healthcare Interpreter, Full-Time, 8 Hour",
			Description = "Community Regional Medical Center provides central California with the highest level of care available in the region. We measure up with top hospitals nationally and are the 3rd largest in California! Our 685 beds is home to the only comprehensive Burn and Level I Trauma center between Los Angeles and Sacramento. With a full-service 58,000 square-foot Emergency Department, we are one of the largest and busiest in California. We have an 84-bed Level III NICU and plan to significantly expand our pediatric specialty services. The hospital serves 2.5 million people within 9 counties, averaging a daily census of 641 patients. Were affiliated with UCSF as a teaching facility and have trained 3,000 Medical Doctors to date plus we continue to invest in research and training grants. Employee Benefits We provide robust benefit plans with competitive premiums for medical and dental/vision along with retirement plans. Additionally, you will accrue paid time off from your first day of employment. Other Benefits include: Long-term Disability Insurance, Basic Life Insurance, Accidental Death and Dismemberment Coverage, educational and professional certification reimbursement, Employee Assistance Program, Credit Union Membership, Fitness Center, 24 hour Subway, onsite concierge service, and Retirement Planning classes. Are you the perfect fit for this position? Apply Now! Provides interpreting and translation services in a culturally sensitive manner in order to facilitate communication between the limited-English proficient (LEP) patients/families and the healthcare team. Interpreting services are provided for Healthcare Facilities participating in the contracted language provider network, via telephone or other remote technology. Act as a mentor to the Healthcare Interpreter 1 and conducts special projects for management. DEPARTMENT SPECIFIC REQUIREMENTS Successfully complete contracted language provider orientation. High school diploma/GED. Three years experience in Healthcare with one year experience interpreting and/or translating in a Healthcare setting. Completion of 40-hour Healthcare Interpreter certification training or may be obtained within probationary period. Proficient in Medical Terminology in both English and target language is Spanish. PREFERRED: Associates degree. LICENSES/CERTIFICATIONS MINIMUM REQUIRED: Certification Commission for Healthcare Interpreters (CCHI) or National Board of Certification for Medical Interpreters (NBCMI). Requisition ID: 2019-15549 Facility (Tazworks integration): Community Regional Medical Center (CRMC) Updated Date: 11/22/2019 External Company Name: Community Medical Centers of Fresno, CA External Company URL: https://www.communitymedical.org/ Street: 2823 Fresno St Job Summary Location Fresno, CA 93650 Posted 7 Days ago Reference code 2365_39827970d868a9f5c85634d32eccd0ff",
			Company = "Community Medical Centers of Fresno, CA",
			City = "Fresno",
			State = "CA",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 62000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Communications"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "e8ca924aa602a2354ed031a0d0ba484f",
			Title = "RN House Supervisor",
			Description = "Welcome to Centura Health   Welcome to the largest health ecosystem in Colorado and western Kansas. Welcome to living your mission among thousands of people on fire to live theirs too. Welcome to options, possibilities and values that guide exceptional care. Welcome to extremely important industry challenges and opportunities to solve complex problems. Welcome to highly intelligent teams, overflowing community and the wholeness of mind, body and spirit that is Centura Health.   Flourishing Begins Here   You have a purpose, unique talents and NOW is the time to embrace it, live it and put it to work. At Centura Health, we value incredible people with incredible skills ? but your commitment to a greater cause is something we value even more.    ?   Responsible for coordination and direction of safe and efficient patient care and throughput in the hospital by providing a communication link with ED, patient registration, LIPs and nursing units. Serves as clinical resource person in delivery and supervision of direct and indirect care processes. Provides competent leadership and direction for all hospital Codes and emergency management. Serves as agent for department and hospital executives when they are not present and reports concerns and events to the designated administrator on call.   What You Bring/Job Requirements   In addition to bringing your whole self to the workplace each day, qualified candidates will need the following:       Three years of clinical experience required    One year of supervision required    Bachelor BSN required    MSN preferred    Current RN license in applicable state of work or current RN license from a participating state in National Licensure Compact for eligible states    Current Basic Life Support (BLS) certification from the American Heart Association    Current Advanced Cardiac Life Support (ACLS) from the American Heart Association    PALS or ENPC required upon hire or within three months of hire/transfer     ?   Physical Requirements-Medium Work - (Exert up to 50lbs force occasionally, and/or up to 20lbs frequently, and/or up to 10lbs constantly)   Your Connected Community   When people and places align, incredible things happen. Just like the 21,000+ amazing associates who work here, every community within Centura Health?s connected ecosystem has its own unique history, story and personality.",
			Company = "Centura Health",
			City = "Durango",
			State = "CO",
			PostedDate = new DateTime(2020,1,23),
			MinimumSalary = 41000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "bb516018428cefa981bde5075f92d183",
			Title = "Senior Front-End Engineer",
			Description = "Join  Hired  and find your dream job as a  Senior Front-End Engineer  at one of 10,000+ companies looking for candidates just like you.  Companies on  Hired  apply to you, not the other way around. You'll receive salary and compensation details upfront - before the interview - and be able to choose from a variety of industries you're interested in, to find a job You'll love in less than 2 weeks.  As a Senior Front-End Engineer, you'll be responsible for implementing the interactive and visual elements of web and mobile applications. You'll collaborate with the team of UX designers and back-end engineers in delivering intuitive layouts. You'll also be responsible for translating the needs of our company and clients into appealing applications. If you enjoy writing code and creating user-friendly layouts, this job is a good fit for you. We value a diversity of perspectives and encourage healthy discussion and debate, but unite behind our decisions.  Responsibilities   Creating clean code  Ensuring cross-browser compatibility   Building a library for future use  Optimizing applications for scalability and speed  Acting as a mentor to junior developers, through code reviews and design document critiques  Creating prototypes and quality mockups   What Skills   4+ years experience in front-end development   4+ years of recent experience building pages in Javascript (ES6), HTML, and CSS  Experience working with a javascript framework such as React.js or equivalent  Solid understanding of JavaScript frameworks  Exemplary communication skills; able to map problem-solution space and explain possible solutions to non-technical team members  Good skill with Adobe suite, including Illustrator and Photoshop  Familiarity with content management systems, including WordPress, Drupal and Joomla  Understand of layout aesthetics   Solid understanding of SEO principles  Passion for learning new technologies fast  B.S. degree in Computer science, Software Engineering or a related field, or equivalent experience   These Would Also Be Nice   Experience with backend development  Experience with analytics tools like Google Analytics or Mixpanel  Experience with various database systems, both in production and warehousing capacities, such as MySQL, PostgreSQL, and Redshift  Experience with server-side languages such as Ruby on Rails ",
			Company = "Hired",
			City = "Temple",
			State = "NH",
			PostedDate = new DateTime(2020,1,11),
			MinimumSalary = 88000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "d905cfccc534e13423dbc943f025e083",
			Title = "Data analyst - Human Resources",
			Description = "Data Analyst  Human Resources  Apply NowSave JobJob Saved  Job IDREQ_108535FACILITYRiedman CampusLOCATIONRochester, New York  SUMMARY  The Human Resources (HR) Data Analyst is responsible for providing support and insight related to various RRH total rewards processes and programs.  In this role, you will perform thorough analysis of information from multiple resources and develop related metrics and reporting.  You will also identify patterns and trends, make plan design recommendations and calculate any subsequent financial impact to the organization.  The HR Data Analyst interprets data and turns it into information which can offer ways to improve our value proposition, system optimization and integration as a health system.  STATUS:Full Time  LOCATION:Riedman Campus  DEPARTMENT:Human Resources  SCHEDULE:Monday-Friday  ATTRIBUTES    Bachelors degree in Human Resources, Business Administration, Mathematics, or related field    2+ years analytics or analyst related experience    Familiarity with budgeting, forecasting and/or accounting preferred    RESPONSIBILITIES    Gather and confirm user requirements for various analytics projects    Understand and leverage HR Systems, tools, and data resources to maximize their potential for data mining, data extraction, data integrity, and metric development needs. Automate and streamline manual processes by deploying and managing the implementation of business intelligence, data visualization and reporting tools through Workday    Interpret data, analyze trends and results using Excel functionality and develop standard reporting methods and formats to provide fact-based evidence for recommendations or decisions. Translate evidence into actionable forecasts and solutions to improve related programs and processes    Effectively use critical thinking skills and attention to detail to conduct a thorough analysis of market values, affordability and internal operational factors to make programmatic recommendations to leadership    Participate in market research to collect market competitive information; analyze results and make recommendations to leadership    Follow established project, departmental, company procedures and quality standards    Rochester Regional Health is an Equal Opportunity / Affirmative Action Employer. Minority/Female/Disability/Veteran  ",
			Company = "Rochester Regional Health",
			City = "Rochester",
			State = "NY",
			PostedDate = new DateTime(2020,1,26),
			MinimumSalary = 77000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Business Operations"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "108b6b3e766dc3a12a1576b40b8382ec",
			Title = "IT Support Technician",
			Description = "This is a opportunity with a well know agricultural company     located in Watsonville, CA.  The team is growing quickly and is     looking to hire talented IT Support Technicians.      JOB SUMMARY:  Second level technical and desktop   support of PC users. In accordance with the company's support policies   provides: support for PC and general network issues, support for   essential server systems; support for mobile devices; management of IT   projects; training of Service Desk staff; technical support of A/V systems.   RESPONSIBILITIES INCLUDE:   Desktop Support: Provides 2nd level support to users on a variety of   issues. Responds to telephone calls, e-mail and personnel requests for   technical support. Utilizes Service Desk software to track and monitor   problems to insure a timely resolution according to Service Level   Agreements.  Supports and maintains user account information.   Identifies, researches and resolves technical problems.  Shares in   rotation of after business-hour response to requests for help.  Hardware: Maintains, analyzes, troubleshoots and repairs computer   systems, hardware and computer peripherals both locally and by   traveling to other locations. Documents, maintains, upgrades or   replaces hardware systems.  Software: Installs new software releases, system upgrades, evaluates   and installs patches and resolves software related problems  Active Directory Administration: Administers computer and user   accounts through Active Directory, administers distribution and   security groups, create and disable user accounts, organize user and   computer accounts in OUs, change and reset user passwords.  Network: Works with Network Engineers to install, configure and   maintain organization s network (LAN and WAN).  Supports network   operating system and supporting software. Basic troubleshooting of   wired and wireless networks.  Phone System:  Provides maintenance, upgrades and support for   corporate telephone system(s) and mobile phones.  Mobile Devices:  Provides configuration, troubleshooting and support   for a variety of mobile devices including tablets and smart phones.  Documentation: Creates documentation for or related to IT projects,   system upgrades, technical support procedures, frequently asked   questions, and other Service Desk related subjects. ",
			Company = "Maris Consulting Group",
			City = "Watsonville",
			State = "CA",
			PostedDate = new DateTime(2020,1,13),
			MinimumSalary = 93000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "1d5a65853f0ff95cac563aac88934d60",
			Title = "Audiologist or Hearing Instrument Specialist",
			Description = "We are seeking an Audiologist or a Hearing Aid Specialist who is motivated by his/her career in the hearing industry!  ?  The candidate for this location must be licensed to dispense within the state. This position is full-time with a competitive base salary, a benefits package, and an opportunity for bonuses.  ?  HHR will disclose details in further conversation.  ?   Contact us today!   ?   ** This application and its contents are intended for HHR internal use only. Candidate information is NOT forwarded to an employer without candidates permission.   ?   The HHR Competitive Advantage:     Dont limit your career search! ?Hearing Healthcare Recruiters represents a multitude of companies, which allows us to present open positions from across the industry rather than from a single employer.  Our service comes to you at? no charge ?and? your confidentiality is 100% protected.   Anyone can submit a resume or apply directly to an employer BUT Hearing Healthcare Recruiters has a strong relationship with the hiring authorities so? we will make sure your resume is seen !!  Relocating? We have over 150 positions across the United States and Canada that need to be filled.  We serve as your guide & mentor throughout the entire process with frequent follow ups.  Nearly 25 years experience working in the hearing industry - we know the ins and outs!!    Hearing Healthcare Recruiters would love to serve as your primary source for outstanding employment opportunities across the United States.   ?  Hearing Healthcare Recruiters is a professional job placement and recruiting firm that focuses exclusively on the hearing industry. We work with Academia, Audiologists, ENTs, Hearing Industry Manufacturers, Hearing Instrument Specialists, Hospitals, Manufacturer Representatives, Private Practices and Retail Dispensaries.  ?  George Mathis, owner and Senior Recruiter with HHR, spent nearly 20 years in the hearing industry as a manufacturers representative, and brings an intimate knowledge of the hearing industry to the recruiting process. Please note that our service comes to candidates at no-charge, confidentiality is fully protected, and we will coach and mentor you through the entire process.  ?   Lets start a conversation    ?  Hearing Healthcare Recruiters: 714.277.6014 (Pacific Time Zone)  ?  HearingHealthcareRecruiters.com",
			Company = "Hearing Healthcare Recruiters, LLC",
			City = "Jacksonville Beach",
			State = "FL",
			PostedDate = new DateTime(2020,1,24),
			MinimumSalary = 58000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "2f6be1f15782bced5573db08e72f08f6",
			Title = "Head Start ERSEA Specialist",
			Description = "Overwhelmingly, people who decide they want to be a part of the Y in Central Maryland tell us they do so because it reflects their values and a conscious decision they've made about how they choose to live their lives. The happiest and most fulfilled Y associates are those who are motivated to help others and who want to be a part of something larger than themselves. If this speaks to your heart, then we invite you to join our team. Be a part of a charitable, mission-driven organization that works for individual and community well-being for all, for a better us. How this role contributes to the Y's mission: As a Y Head Start ERSEA Specialist, you will be responsible for the overall management, administration and coordination of Eligibility, Recruitment, Selection, Enrollment and Attendance (ERSEA) practices in order to ensure compliance with all federal Head Start Performance Standards. You will design and implement associate recruitment and enrollment training as well as a management system of all ERSEA practices within Head Start operations. You will be responsible for the tracking and monitoring of recruitment, selection, enrollment and attendance for all centers as well as eligibility verification of enrolled participants. You will partner with regional leadership on community outreach and recruitment efforts as well as maintain relationships with local community agencies and public school community workers. As a Y Head Start ERSEA Specialist, you'll contribute to the Y and to the broader community we serve by working with our littlest participants and their families who are economically disadvantaged and help them prepare for success in school and life. This work is right for you if you have: An interest in the well-being and education of young children, enthusiasm, patience, good humor, good judgment and a good spirit The ability to clearly communicate and effectively listen to children, parents/guardians, members, and other Y associates Prior experience in Head Start operations with a focus on ERSEA mandates The desire to problem solve, handle crises, and work with families and children of various cultures from low-income backgrounds A bachelors degree in social services, social work, sociology, human services or related field An ERSEA certification (preferred) The ability to travel across Anne Arundel County, Baltimore City, and Baltimore County on a daily basis Thank you for considering working for the Y in Central Maryland. If being a part of our cause feels right for you, we hope you will join us. The Y provides equal employment opportunities (EEO) to all employees and applicants for employment. Other details Job Family Early Childhood Development Pay Type Salary 1201 S Caton Ave, Baltimore, MD 21227, USA Job Summary Location Stevenson, MD 21153 Posted 1 Days ago Reference code 8631_7648-0141c8e2939701712ae633d82ec3ec48",
			Company = "The Y of Central Maryland",
			City = "Stevenson",
			State = "MD",
			PostedDate = new DateTime(2020,1,31),
			MinimumSalary = 75000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Social Science"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "e9e11729ee8a55c8c5996abc6b128c62",
			Title = "Telemetry Monitor Technician - Critical Care Unit - Full Time - Nights",
			Description = "ProMedica Coldwater Regional Hospital has been providing high-quality health care services to the Branch County community since 1939. Located in Coldwater, Michigan, ProMedica Coldwater has 71 acute medical beds and 16 adult psychiatric beds to care for patients and their families.  Position Summary:   This position is split between the Critical Care Unit and ER   The Monitor Tech will perform the receptionist and secretarial duties on a patient care unit while functioning as the focal communications source in the nursing station. They are responsible for maintaining and monitoring the cardiac central monitoring station. The tech will perform activities which support the smooth operation of a patient care unit.    Job Requirements:    High School Diploma or equivalent     Secondary education in medical assistant or secretarial skills preferred    One year hospital experience desirable     Must successfully pass an EKG course within three months of hire    CPR certification within three months of hire    Must be able to use cardiac monitoring equipment, such as telemetry, printers, and central monitoring equipment    ProMedica is a mission-based, not-for-profit integrated healthcare organization headquartered in Toledo, Ohio. It serves communities in 30 states. The organization offers acute and ambulatory care, an insurance company with a dental plan, and post-acute and academic business lines. The organization has more than 70,000 employees, 13 hospitals, 2,700 physicians and advanced practice providers with privileges, 900+ healthcare providers employed by ProMedica Physicians, a health plan, and 450 assisted living facilities, skilled nursing and rehabilitation centers, memory care communities, outpatient rehabilitation clinics, and hospice and home health care agencies. Driven by its Mission to improve your health and well-being, ProMedica has been nationally recognized for its advocacy programs and efforts to address social determinants of health.  Qualified applicants will receive consideration for employment without regard to race, color, national origin, ancestry, religion, sex, pregnancy, sexual orientation, gender identity or gender expression,  age, disability, military or veteran status, height, weight, familial or marital status, or genetics.  Equal Opportunity Employer/Drug-Free Workplace   Requisition ID:  47023",
			Company = "ProMedica Health System",
			City = "Coldwater",
			State = "MI",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 67000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "20f8b0a79619941a66e7679873357ff8",
			Title = "Trust Admin Officer II",
			Description = "This is an entry level Personal Trust Officer position responsible for administering routine personal trust accounts such as testamentary/intervivos trusts, conservatorships, guardianships and agencies in accordance with terms specified in trust instrument. Under general guidance, sets up estates, trusts, agency accounts and guardianships where issues are routine and less complex in nature. Become familiar with governing document to interpret terms, responsibilities and duties of the Bank. Receive guidance in understanding provisions of the documents and strategies associated with the assigned accounts. Maintain contact with clients to discuss and advise on issues. Maintain up-to-date knowledge of account activity by reviewing various reports. Seek guidance on tax and trust issues.   Basic Qualifications    *Minimum 4 years of experience in Personal Trust required  *Minimum 4 years of experience in a financial services organization required  *Minimum 4 years of administrative/clerical experience required    Skills and Knowledge     Bachelor's Degree.  J.D. Degree a plus.  Up to three years' experience in trust administration preferred.  Strong written and verbal communications skills.  Ability to gather, arrange, compile, interpret, analyze, summarize and evaluate information  and data to identify opportunities and formulate conclusions and recommended actions.  Ability to set priorities, and objectives.  Demonstrate excellent working knowledge of trust administration.  Colleague is ideally working towards Trust Certificate and/or CTFA    *Represents basic qualifications of the position. To be considered for this position you must at least meet the basic qualifications.   City National Bank is an Equal Opportunity Employer -- Minorities/Females/Individuals with Disabilities/Veterans.   Note : This preceding job description has been designed to indicate the general nature and level of work performed by employees within this classification. It is not designed to contain or be interpreted as a comprehensive inventory of all duties, responsibilities, and qualifications required of employees assigned to this job.    Note : Candidates should be advised that City National Bank does not pay interviewee travel expenses or relocation expenses for candidates who are hired unless previously agreed.   Equal Opportunity Employer Minorities/Women/Protected Veterans/Disabled",
			Company = "City National Bank",
			City = "Altadena",
			State = "CA",
			PostedDate = new DateTime(2020,1,26),
			MinimumSalary = 66000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Finance"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "91f0d0b51122f2fc7e9efa45c812d3d8",
			Title = "Phlebotomy Services Tech Flex",
			Description = "Welcome to Centura Health   Welcome to largest health ecosystem in Colorado and western Kansas. Welcome to living your mission among thousands of people on fire to live theirs too. Welcome to options, possibilities and values that guide exceptional care. Welcome to extremely important industry challenges and opportunities to solve complex problems. Welcome to highly intelligent teams, overflowing community and the wholeness of mind, body and spirit that is Centura Health.   Flourishing Begins Here   You have a purpose, unique talents and NOW is the time to embrace it, live it and put it to work. At Centura Health, we value incredible people with incredible skills ? but your commitment to a greater cause is something we value even more.    ?   The Phlebotomy Services Tech is responsible for collection and processing of blood samples and other specimens as defined by site. Provides a high level of customer service for lab inquiries, test requirements, and other laboratory information.   ?   This position will support the South Denver Metro hospitals, including Parker, Littleton, Castle Rock and Porter.   What You Bring/Job Requirements   In addition to bringing your whole self to the workplace each day, qualified candidates will need the following:       6 months phlebotomy work experience preferred    High School Diploma or GED required    Completion of a phlebotomy program preferred    Phlebotomy certification preferred     ?   Light work - (Exert up to 20lbs force occasionally, and/or up to 10lbs frequently)   Your Connected Community   When people and places align, incredible things happen. Just like the 21,000+ amazing associates who work here, every community within Centura Health?s connected ecosystem has its own unique history, story and personality.   ?   Centura Health is headquartered in Centennial, CO, with additional business office locations throughout the Denver Tech Center. The Corporate Service Center is home to our leaders and centralized teams that support our hospitals, clinics and people ? including marketing, human resources, employee benefits, finance, billing, talent acquisition/development, payor relations, IT, project management, community benefit and more. Whether you work in the corporate headquarters or one of our nearby offices, you?ll experience a culture of collaboration and community where incredible people are doing incredible things every day.   Job Summary \r                  \r                      \r                          Location \r                              Centennial, CO 0 \r                      \r                  \r                              \r                      \r                          Posted \r                          Today \r                      \r                  \r                              \r                      \r                          Reference code \r                          6527_18052",
			Company = "Centura Health",
			City = "Centennial",
			State = "CO",
			PostedDate = new DateTime(2020,1,7),
			MinimumSalary = 52000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "7fe2ae217fa303ff393a244641ce48ea",
			Title = "AWS - Software Engineer",
			Description = "Join  Hired  and find your dream job as a  AWS - Software Engineer  at one of 10,000+ companies looking for candidates just like you.  Companies on  Hired  apply to you, not the other way around. You'll receive salary and compensation details upfront - before the interview -  and be able to choose from a variety of industries you're interested in, to find a job You'll love in less than 2 weeks.  Software Engineers continue to be one of the most exciting and in-demand developer jobs available. Engineers code websites or applications on both the server and the client-facing side. It is a role that fuses both creative and practical concerns, as these engineers are responsible for everything the website user encounters, including scrolling functions and graphics, as well as creating the logic, database interactions and server configuration on the application's backend.          In addition to programming the various features of client-side and user-side applications, software engineers are expected to upgrade and maintain both the back and frontend as needed. As new technologies emerge and platforms are expanded, the role will likely transform to suit these changes.          Responsibilities               The development and maintenance of client-side and server-side applications.      Working with other web developers as well as marketing teams and engineers to ensure the right look and necessary features are included in your work.      Designing tests that will be implemented to keep software functional.      Stay on top of expanding technologies and engineering trends.               Skills               Proficiency with HTML and CSS      Being able to code with languages like JavaScript, Core MVC, and ASP.NET      An adroitness with SQL, Ruby and Java for backend programming      Building and accessing databases with NoSQL and Node.js      Understanding the ins-and-outs of HTTP protocols, developer tools, SSL certificates and web application architecture      Keeping track of changes made to code with Git version control system               These Would Also Be Nice               Good communication skills      Thriving as a member of a team      Understanding the needed technology for web development      Keeping business needs in mind      Wanting your work to appeal to clients      Having the desire to continuously grow and learn",
			Company = "Hired",
			City = "North Providence",
			State = "RI",
			PostedDate = new DateTime(2020,1,11),
			MinimumSalary = 43000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "31137034cb07afaf42750aad73bedec3",
			Title = "Cosmetologist - Part Time",
			Description = "Yellow Shoes? Check! Red pants? Check! Costuming and Cosmetology Cast Members at Disneyland? Resort make sure that the thousands of Entertainment and Theme Park and Resort costumed Cast Members are ready for the show every day.  Cosmetology Cast Members are responsible for maintaining all wigs for performers and Audio-Animatronics figures across Disneyland? Resort, applying facial theatrical makeup and teaching entertainers proper makeup application.  You must be at least 18 years of age.   Cosmetologist Cast Members receive a starting pay rate of $17.00/hr      Responsibilities :     Must have the ability to wash and set wigs and recreate a style from a photo in a clear and defined manner.  Must have the ability to work pin-on and retouches for parades, shows and venues.  Provide wigs styled to an approved Corporate design for characters (i.e. Cinderella, Belle, Snow White, Sleeping Beauty).  Demonstrate a working knowledge and appropriate use of styling tools.     Basic Qualifications :      Willingness to join the IATSE labor union.  Ability to perform the physical requirements of the role with or without reasonable accommodation, including frequent walking and standing; lifting, pushing and pulling up to 25 lbs; working with a variety of chemicals on a daily basis including hair spray and cleaning solutions (i.e., shampoo, vinegar, etc).  Training Availability:  6 weeks of full availability (day AND evening) will be required immediately following the start date     Preferred Qualifications:     Two (2) years of working experience as a licensed Cosmetologist.  Experience washing and setting wigs.  Wig or styling experience with synthetic hair.  Wig or styling experience with human hair.  Styling experience with period looks.      Additional Information :    SCHEDULE AVAILABILTY  Our Theme Parks and Resort Hotels operate 24 hours a day, 365 days a year and some shifts may start as early as 5:00am while some may end as late as 3:00am, 4:00am or 5:00am.   SUBMITTING YOUR APPLICATION  After clicking ?Apply for this job? below, the employment application will open in a new window. Please complete ALL pages of the application by clicking ?Next? on each page, then ?Submit? on the final page.   IMPORTANT:  You may only apply once in a six month period. If you have applied within the last six months, please log in to your account to view your current application status.  Keyword; dlrcasting",
			Company = "Disney Parks And Resorts",
			City = "Laguna Hills",
			State = "CA",
			PostedDate = new DateTime(2020,1,20),
			MinimumSalary = 41000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Media"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "c672e24fd21a9e553371e365441c8d50",
			Title = "Senior Software Engineer",
			Description = "Join  Hired  and find your dream job as a  Senior Software Engineer  at one of 10,000+ companies looking for candidates just like you.  Companies on  Hired  apply to you, not the other way around. You'll receive salary and compensation details upfront - before the interview - and be able to choose from a variety of industries you're interested in, to find a job you'll love in less than 2 weeks.  Senior Software Engineers continue to be one of the most exciting and in-demand developer jobs available. Engineers code websites or applications on both the server and the client-facing side. It is a role that fuses both creative and practical concerns, as these engineers are responsible for everything the website user encounters, including scrolling functions and graphics, as well as creating the logic, database interactions and server configuration on the application's backend.          In addition to programming the various features of client-side and user-side applications, senior software engineers are expected to upgrade and maintain both the back and frontend as needed. As new technologies emerge and platforms are expanded, the role will likely transform to suit these changes.          Responsibilities               The development and maintenance of client-side and server-side applications.      Working with other web developers as well as marketing teams and engineers to ensure the right look and necessary features are included in your work.      Designing tests that will be implemented to keep software functional.      Stay on top of expanding technologies and engineering trends.               Skills               4+ Years of Experience     Proficiency with HTML and CSS      Being able to code with languages like JavaScript, Core MVC, and ASP.NET      An adroitness with SQL, Ruby and Java for backend programming      Building and accessing databases with NoSQL and Node.js      Understanding the ins-and-outs of HTTP protocols, developer tools, SSL certificates and web application architecture      Keeping track of changes made to code with Git version control system               These Would Also Be Nice               Good communication skills      Thriving as a member of a team      Understanding the needed technology for web development      Keeping business needs in mind      Wanting your work to appeal to clients      Having the desire to continuously grow and learn",
			Company = "Hired",
			City = "Pierce",
			State = "CO",
			PostedDate = new DateTime(2020,1,5),
			MinimumSalary = 43000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "a8913ee41e01acd563a5507031c27659",
			Title = "Senior Software Engineer",
			Description = "Join  Hired  and find your dream job as a  Senior Software Engineer  at one of 10,000+ companies looking for candidates just like you.  Companies on  Hired  apply to you, not the other way around. You'll receive salary and compensation details upfront - before the interview - and be able to choose from a variety of industries you're interested in, to find a job you'll love in less than 2 weeks.  Senior Software Engineers continue to be one of the most exciting and in-demand developer jobs available. Engineers code websites or applications on both the server and the client-facing side. It is a role that fuses both creative and practical concerns, as these engineers are responsible for everything the website user encounters, including scrolling functions and graphics, as well as creating the logic, database interactions and server configuration on the application's backend.          In addition to programming the various features of client-side and user-side applications, senior software engineers are expected to upgrade and maintain both the back and frontend as needed. As new technologies emerge and platforms are expanded, the role will likely transform to suit these changes.          Responsibilities               The development and maintenance of client-side and server-side applications.      Working with other web developers as well as marketing teams and engineers to ensure the right look and necessary features are included in your work.      Designing tests that will be implemented to keep software functional.      Stay on top of expanding technologies and engineering trends.               Skills               4+ Years of Experience     Proficiency with HTML and CSS      Being able to code with languages like JavaScript, Core MVC, and ASP.NET      An adroitness with SQL, Ruby and Java for backend programming      Building and accessing databases with NoSQL and Node.js      Understanding the ins-and-outs of HTTP protocols, developer tools, SSL certificates and web application architecture      Keeping track of changes made to code with Git version control system               These Would Also Be Nice               Good communication skills      Thriving as a member of a team      Understanding the needed technology for web development      Keeping business needs in mind      Wanting your work to appeal to clients      Having the desire to continuously grow and learn",
			Company = "Hired",
			City = "Platteville",
			State = "CO",
			PostedDate = new DateTime(2020,1,5),
			MinimumSalary = 67000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Computer"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "5dc81d6f839d2054a421123e1771256f",
			Title = "VP of Strategic Partnerships Product & Business",
			Description = "The Strategic Partnerships team at Company is responsible for sourcing, evaluating, negotiating and executing strategic partnership opportunities focused on consumer and ?Dasher? (our drivers) growth. We work closely with senior leadership and product teams to guide company strategy by way of alignment with high growth third parties. We support all aspects of identifying, evaluating, and executing large-scale partnerships and transactions that have a significant impact on the overall direction of the company.    About the Role    As the? Head of Strategic Partnerships , you will lead the strategic partnership strategy with the expected outcome of driving customer acquisition, dasher acquisition and revenue growth.? In this role you will...   Evaluate and prioritize partnership opportunities, performing quantitative and qualitative due diligence  Build strong relationships with stakeholders across our product, engineering, marketing, communications, and other teams to ensure close alignment on deals before, during and after deal sign  Establish key performance indicators that will determine the ultimate success of the partnership  Maintain all aspects of partnership go-to-market, ensuring that both parties hit their respective timelines prior, during, and after launch    About You    You love working directly with client partners (c-suite as well as project leads), and you create and maintain long term relationships  You are a problem solver at core, with a strong bias for action  You?re comfortable building, leading and managing a team  You like rolling up your sleeves as much as you like the big picture  You?re comfortable with a fast pace and several moving parts; we move quickly and are defining an entire industry  You know how to take very broad challenges or opportunities and turn them into actionable projects with clear milestones and goals, with minimal guidance    We're excited about you because...    10+ years of experience in business development, law, investment banking, management consulting, private equity, operations, or similar role  Minimum 3 years in management position  Strong analytical, leadership, intellectual curiosity, and partnering skills  Demonstrated ability to independently and logically frame a problem, provide the analysis required to answer the question, and drive the resolution is mandatory  Established senior-level industry-relevant contacts are preferred, but not required",
			Company = "DoorDash",
			City = "San Francisco",
			State = "CA",
			PostedDate = new DateTime(2020,1,3),
			MinimumSalary = 94000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Management"),
		});
		AllJobPostings.Add(new JobPosting
		{
			UniqueIdentifier = "bdf49db600644f8131a6d252fa597fd4",
			Title = "Echo Sonographer, FT",
			Description = "Details:  Advancing Healthcare Together ? The Future of Healthcare is in East Texas  Why UT Health - East Texas?  Our People. Our people truly are our greatest strength. They make a massive difference in the amazing care we provide every day. We work closely together to create a positive experience for our patients and each other.  Our Purpose. We will build on your experience and provide meaningful and purposeful career growth for your future. You will have the opportunity every day to make a difference in someone?s life and change the course of healthcare.  Our Place. Tyler, Texas is a small town with a huge heart where you will have the privilege of caring for your neighbors. Everybody is somebody here.  Representing the very best in healthcare, UT Health East Texas is comprised of 10 hospitals and more than 50 clinics across east Texas. With nearly 7,500 employees and over 1,000 licensed in-patient beds, UT Health East Texas provides healthcare services to thousands of patients annually through our hospitals, clinics, Level 1 trauma facility, air emergency fleet and EMS service in a metropolitan service area of a quarter-million people.  Our UT Health Tyler hospital is seeking an experienced Echo Songrapher. We are looking for your experience, knowledge and patient care skills in our Echocardiology department where you will be responsible for:  What You Will Be Doing:  ? Perform Transthoracic, Transesophageal and Stress Echocardiograms for adult patients ? Evaluate and assist in the operation and maintenance of ultrasound equipment ? Collect and distribute documents relevant to procedures and other clerical items to ensure smooth, daily operations ? Maintain adequate departmental supplies ? Must know and follow departmental Policy and Procedures and practice Infection Control according to Universal Precautions  Details:  So what experience are we looking for in our Echo Sonographers?  ? CPR Certified Basic Life Support within 90 days of hire date ? At least one year experience hands-on technical skills ? Echo registry elligible per ICAEL standards ? Knowledge and ability to operate equipment and perform ultrasound procedures  Now that you read about what you will be doing and the experience we seek, it is time to apply and make a difference in the lives of our patients.  UT Health East Texas is an equal opportunity employer (including veterans and persons with disabilities). ",
			Company = "UT Health East Texas",
			City = "Tyler",
			State = "TX",
			PostedDate = new DateTime(2020,1,15),
			MinimumSalary = 46000m,
			Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Healthcare Technology"),
		});

		//create some counters to help debug problems
		Int32 intJobPostingID = 0;
		String strJobPostingTitle = "Start";

		//loop through the list to add or update the job posting
		try
		{
			foreach (JobPosting seedJobPosting in AllJobPostings)
			{
				//update the counters
				intJobPostingID = seedJobPosting.JobPostingID;
				strJobPostingTitle = seedJobPosting.Title;
				//see if the job posting is already in the database using the UniqueIdentifier
				JobPosting dbJobPosting = db.JobPostings.FirstOrDefault(m => m.UniqueIdentifier == seedJobPosting.UniqueIdentifier);

					//if job posting is null, job posting is not in database
					if (dbJobPosting == null)
					{
						//Add the job posting to the database
						db.JobPostings.Add(seedJobPosting);
						db.SaveChanges();
					}
					else //the job posting is in the database - reset all fields except ID and Unique Identifier
					{
						dbJobPosting.Title = seedJobPosting.Title;
						dbJobPosting.Description = seedJobPosting.Description;
						dbJobPosting.Company = seedJobPosting.Company;
						dbJobPosting.City = seedJobPosting.City;
						dbJobPosting.State = seedJobPosting.State;
						dbJobPosting.PostedDate = seedJobPosting.PostedDate;
						dbJobPosting.MinimumSalary = seedJobPosting.MinimumSalary;
						dbJobPosting.Category = seedJobPosting.Category;
						db.SaveChanges();
					}
				}
			}
			catch (Exception ex) //throw error if there is a problem in the database
			{
				StringBuilder msg = new StringBuilder();
				msg.Append("There was a problem adding the job posting with the title: ");
				msg.Append(strJobPostingTitle);
				msg.Append(" (JobPostingID: ");
				msg.Append(intJobPostingID);
				msg.Append(")");
				throw new Exception(msg.ToString(), ex);
			}
		}
	}
}
