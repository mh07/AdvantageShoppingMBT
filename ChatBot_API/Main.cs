/***************************************************************
    *  DO NOT EDIT THIS FILE!
    *         
    *  This file is automatically generated by HP Service Test.
    *  Manually changing the contents of this file may result in 
    *  loss of information.
    *          
    *  To edit the test, open the file ‘ChatBot_API.st’ 
    *  in HP Service Test.
     ***************************************************************/
    
    namespace Script
    {
    using System;
    using System.Text;
    using System.Threading;
    using System.Xml;
    using System.Xml.Schema;
    using HP.ST.Fwk.ReporterFWK;
    using HP.ST.Shared.Utilities;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.HelperClasses;
    using HP.ST.Fwk.RunTimeFWK.CompositeActivities;
    using HP.ST.Ext.BindingImpl.Setters.DataSourceSetters;
    using HP.ST.Fwk.JVMLoader;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using HP.ST.Fwk.SOAReplayAPI;
    using HP.ST.Fwk.UFTLicensing;
    
    
    
    public partial class WorkFlowScript : STWorkFlowScriptBase
    {    
    	TestUserCode _userCode = null;
    	TestEntities _flow = null;
    	static Reporter reporter;
    	int reportLevelInTree;
        HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator reportCreator;
    	
    	
        public IEnumerable<FeaturesGroup> LicensedFeatures
        {
        
        get
        {
        List<FeaturesGroup> features = new List<FeaturesGroup>();
        return features;
        
        }
        
        }
        
        public WorkFlowScript()
            : base(VuserClass.CommandLineArguments, new STRunTimeContext(), "test")
        {	
        	UpdateContextWithActionFolder(String.Empty);
        	
        }
        
        public WorkFlowScript(ISTRunTimeContext ctx)
            : base(VuserClass.CommandLineArguments, ctx, "test")
            
        {
        	this._context = ctx;
        	UpdateContextWithActionFolder(String.Empty);
        	UpdateTestSettings(ctx);
        }
        
        internal void InitializeComponent()
        {
        	LoadInput();
        	
        	InitReport();
        	
        	InitializeEncryptionManagerValues();
        
        	Directory.SetCurrentDirectory(this._context.ScriptPath);
        	_userCode = new TestUserCode();
            _flow = _userCode;
            _flow.Context=this._context;
            
            
        
        	_flow.StartActivity1 = new HP.ST.Ext.BasicActivities.StartActivity(_context,"StartActivity1");
            _flow.Loop2 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input>(_context,"Loop2",LoopType.For);
            _flow.EndActivity3 = new HP.ST.Ext.BasicActivities.EndActivity(_context,"EndActivity3");
            _flow.Sequence5 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence(_context,"Sequence5");
            _flow.HTTPActivity4 = new HP.ST.Ext.HTTPActivity.HTTPActivity(_context,"HTTPActivity4");
            _flow.StartActivity1.Comment = @"";
            _flow.StartActivity1.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.StartActivity1.Name = @"Start";
            _flow.StartActivity1.JVM = new HP.ST.Ext.BasicActivities.JVMProperties();
            _flow.StartActivity1.IsJavaUsed = false;
            _flow.StartActivity1.JVM.Classpath = @"%CLASSPATH%";
            _flow.StartActivity1.JVM.AdditionalVMParameters = @"";
            _flow.StartActivity1.JMS = new HP.ST.Ext.BasicActivities.JMSProperties();
            _flow.StartActivity1.IsJmsUsed = false;
            _flow.StartActivity1.JMS.JNDIContextFactory = @"<Select...>";
            _flow.StartActivity1.JMS.JNDIProviderUrl = @"";
            _flow.StartActivity1.JMS.JMSConnectionFactory = @"";
            _flow.StartActivity1.JMS.SecurityPrincipal = @"";
            _flow.StartActivity1.JMS.SecurityCredentials = @"";
            _flow.StartActivity1.JMS.JMSClientID = @"";
            _flow.StartActivity1.JMS.SSLPassword = @"";
            _flow.StartActivity1.JMS.SSLTrustedCertificate = @"";
            _flow.StartActivity1.JMS.SSLIdentity = @"";
            _flow.StartActivity1.JMS.ConnectionsPerProcess = @"1";
            _flow.StartActivity1.JMS.TimeoutOptions = @"DN_User_defined_Timeout";
            _flow.StartActivity1.JMS.UserTimeout = @"20";
            _flow.StartActivity1.JMS.GenerateAutoSelector = @"No";
            _flow.StartActivity1.KafkaSSL = new HP.ST.Fwk.KafkaFWK.KafkaSSLProperties();
            _flow.StartActivity1.IsKafkaUsed = false;
            _flow.StartActivity1.KafkaSSL.StrEnableSSL = @"No";
            _flow.StartActivity1.KafkaSSL.SSLCALocation = @"";
            _flow.StartActivity1.KafkaSSL.SSLClientCertificateLocation = @"";
            _flow.StartActivity1.KafkaSSL.SSLClientKeyLocation = @"";
            _flow.StartActivity1.KafkaSASL = new HP.ST.Fwk.KafkaFWK.KafkaSASLProperties();
            _flow.StartActivity1.KafkaSASL.StrEnableSASL = @"No";
            _flow.StartActivity1.KafkaSASL.StrMechanism = @"GSSAPI";
            _flow.StartActivity1.KafkaSASL.StrServiceName = @"";
            this.Activities.Add (_flow.StartActivity1);
            _flow.Loop2.ConditionAsString = @"Run for 1 iteration";
            _flow.Loop2.NumberOfIterations = (int)1;
            _flow.Loop2.Comment = @"";
            _flow.Loop2.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_loop.png";
            _flow.Loop2.Name = @"Test Flow";
            _flow.Loop2.Activities.Add (_flow.Sequence5);
            this.Activities.Add (_flow.Loop2);
            _flow.EndActivity3.Comment = @"";
            _flow.EndActivity3.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.EndActivity3.Name = @"End";
            this.Activities.Add (_flow.EndActivity3);
            _flow.Sequence5.Comment = @"";
            _flow.Sequence5.IconPath = @"";
            _flow.Sequence5.Name = @"Sequence5";
            _flow.Sequence5.Activities.Add (_flow.HTTPActivity4);
            _flow.HTTPActivity4.TextBody = @"";
            _flow.HTTPActivity4.TextXmlBody = @"";
            _flow.HTTPActivity4.FileBody = @"";
            _flow.HTTPActivity4.PostBody = @"";
            _flow.HTTPActivity4.Url = @"http://10.0.0.43:3001/api/chatbot";
            _flow.HTTPActivity4.HttpMethod = @"POST";
            _flow.HTTPActivity4.HttpVersion = @"1.1";
            _flow.HTTPActivity4.RequestHeaders = new Pair<string, string>[1];
            _flow.HTTPActivity4.RequestHeaders[0] = new Pair<string, string>();
            _flow.HTTPActivity4.RequestHeaders[0].Key = @"Content-Type";
            _flow.HTTPActivity4.RequestHeaders[0].Value = @"application/json";
            _flow.HTTPActivity4.Comment = @"";
            _flow.HTTPActivity4.IconPath = @"AddIns\ServiceTest\HTTPActivity\toolbox_http.png";
            _flow.HTTPActivity4.RequestBodyType = @"Json";
            _flow.HTTPActivity4.ResponseType = @"Json";
            _flow.HTTPActivity4.Name = @"HTTP Request4";
            _flow.HTTPActivity4.Proxy.Server = @"";
            _flow.HTTPActivity4.Proxy.Username = @"";
            _flow.HTTPActivity4.Proxy.Password = @"";
            _flow.HTTPActivity4.Authentication.Username = @"";
            _flow.HTTPActivity4.Authentication.Password = @"";
            _flow.HTTPActivity4.Authentication.PreemptiveAuthentication = false;
            _flow.HTTPActivity4.ConnectionType = @"Keep-Alive";
            _flow.HTTPActivity4.Timeout = (int)100000;
            _flow.HTTPActivity4.ClientCertificate.Password = @"";
            _flow.HTTPActivity4.ClientCertificate.FileSystem.Path = @"";
            _flow.HTTPActivity4.UseClientCertificate = false;
            _flow.HTTPActivity4.MaximumAutomaticRedirections = (int)3;
            _flow.HTTPActivity4.AllowRedirections = true;
            _flow.HTTPActivity4.ReuseCookies = false;
            _flow.HTTPActivity4.ExpectServerError = false;
            _flow.HTTPActivity4.HanaRequest = false;
            XmlDocument HTTPActivity4_XMLBody_Document = new XmlDocument();
            HTTPActivity4_XMLBody_Document.PreserveWhitespace = true;
            HTTPActivity4_XMLBody_Document.LoadXml(
@"<Object jsonType=""Object"" isAnonymous=""true""><message jsonType=""String"">Any laptops for sale?</message></Object>");
            _flow.HTTPActivity4.XMLBody = HTTPActivity4_XMLBody_Document;
            XmlDocument HTTPActivity4_RequestMultipartInfoXml_Document = new XmlDocument();
            HTTPActivity4_RequestMultipartInfoXml_Document.PreserveWhitespace = true;
            HTTPActivity4_RequestMultipartInfoXml_Document.LoadXml(
@"<RequestMultipartInfo><Type>Related</Type></RequestMultipartInfo>");
            _flow.HTTPActivity4.RequestMultipartInfoXml = HTTPActivity4_RequestMultipartInfoXml_Document;
            _flow.HTTPActivity4.Multipart=false;
            XmlDocument HTTPActivity4_ExpectedResponseXmlBody_Document = new XmlDocument();
            HTTPActivity4_ExpectedResponseXmlBody_Document.PreserveWhitespace = true;
            HTTPActivity4_ExpectedResponseXmlBody_Document.LoadXml(
@"<F6DA54ED-92F5-4c5c-9795-170905F25080 />");
            _flow.HTTPActivity4.ExpectedResponseXmlBody = HTTPActivity4_ExpectedResponseXmlBody_Document;
            XmlDocument HTTPActivity4_ExpectedResponseJsonBody_Document = new XmlDocument();
            HTTPActivity4_ExpectedResponseJsonBody_Document.PreserveWhitespace = true;
            HTTPActivity4_ExpectedResponseJsonBody_Document.LoadXml(
@"<F6DA54ED-92F5-4c5c-9795-170905F25080 />");
            _flow.HTTPActivity4.ExpectedResponseJsonBody = HTTPActivity4_ExpectedResponseJsonBody_Document;
            XmlDocument HTTPActivity4_ExpectedOutputProperties_Document = new XmlDocument();
            HTTPActivity4_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            HTTPActivity4_ExpectedOutputProperties_Document.LoadXml(
@"<Arguments><ResponseHttpVersion /><StatusCode /><StatusDescription /><ResponseBody /><ResponseBodyAsBase64 /></Arguments>");
            _flow.HTTPActivity4.ExpectedOutputProperties = HTTPActivity4_ExpectedOutputProperties_Document;
            
        }
        
        internal void InitializeEncryptionManagerValues()
        {
        
        }
        	
    	bool useReport = true;
    
    	protected override STExecutionResult ExecuteStep()
        {
            return base.ExecuteStep();
        }
    
        public void Start()
        {
    	    try
    		{
    		  Workflow_Executing();
    		  this.ExecuteStep();
    		}
    		finally
    		{
    		  WorkFlowScript_Completed();
    		}
        }
    
    	private void InitReport()
    	{
    		if (useReport)
    		{	
    			// Intialize Reporter
    			string reportDBDir = Path.Combine(this._context.ReportDirectory, @"Report");
    			CleanupReport(reportDBDir);        	
    			string reportDBPath = Path.Combine(reportDBDir, "VTDReport.mdb");        	
    			if (reporter == null)
    			{
    				reporter = new Reporter(reportDBPath);
    			}
    			_context.Reporter = reporter;
    		}
    	}
    
        public static void CopyDirectory(string Src, string Dst)
        {
            String[] Files;
    
            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
                Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            Files = Directory.GetFileSystemEntries(Src);
            foreach (string Element in Files)
            {
                // Sub directories
                if (Directory.Exists(Element))
                    CopyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);
            }
        }
        
        private void CleanupReport(string reportDBDir)
        {   
    		if (useReport)
    		{             
    			string reportTemplateDir = Path.Combine(ServiceTestRunner.GetInstallPath(), "bin", "ReportResources");
    			try
    			{
            		CopyDirectory(reportTemplateDir, reportDBDir);
    			}
    			catch //(Exception ex)
    			{
    				//ToDo: LoggingService.Warn("Report Cleanup Error", ex);
    			}
    		}
        }
    
        void Workflow_Executing()
        {   
        	InitReportNode();
                       
        }
    
    	private void InitReportNode()
    	{
    		if (useReport)
    		{	
        		// Init report creator
    			this.reportCreator = new HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator();
    			this.reportLevelInTree = reportCreator.Init(_context.EnvironmentProfile.GetVariableValue("TestName"), _context);
                
    			STActivityBase activity = this;
    			string workflowID = activity.GetHashCode().ToString();
    			ReportNodeCreationData newNodeData =
    			new ReportNodeCreationData(workflowID, workflowID, DateTime.Now);
    			reporter.CreateReportNode(newNodeData);
            
    			ReportInfoData newReportData = new ReportInfoData(workflowID, ReportKeywords.TypeKeywordTag, this.GetType().ToString());
    			reporter.SendReportData(newReportData);
    			newReportData = new ReportInfoData(workflowID, ReportKeywords.NameKeywordTag, this.Name);
    			//TrackData(ReportInfoData.InfoDataTag, newReportData);
    			reporter.SendReportData(newReportData);            
            }
    	}
        
        void WorkFlowScript_Completed()
        {   
    		
    
    		CreateReportFiles();
    					
        	// Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
    
    		OnExecutionCompleted();
    		
        }
    
    	private void CreateReportFiles()
    	{
    		if (useReport)
    		{	
    			//Dispose reporter inorder to close connection to report DB
           		this._context.Reporter.Dispose();
            	
           		// Run report creator
    			reportCreator.RunOnDBAndCreateFiles();
    		}
    	}
    
        
        void Workflow_Faulting()
        {
    		
    
    		CreateReportFiles();
            // Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
           
    		OnExecutionCompleted();
        }
    
    	protected override QcSystemVariables GetRuntimeQcVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeQcVariables(this._context);
    	}
            
    	protected override TestSystemVariables GetTestSystemVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeTestVariables(this._context);
    	}
    
    	private void UpdateTestSettings(ISTRunTimeContext ctx)
        {
    		ctx.PropertyBag["StopTestOnStepFailure"] = true;
    	}
    }
    
    public partial class VuserClass
    {
    	public static string[] CommandLineArguments;
    	public static string[] DotNetResolverPaths;
    	
        public VuserClass()
        {
    				
    		AssemblyResolver.AddSTPathsToResolutionPaths();
    		AssemblyResolver.AttachToAppdomain();
        }
    
        private void AddAssemblyResolver()
        {
    		AssemblyResolver.AddTestPathToResolutionPaths(GetTestPath());
    		AssemblyResolver.AddPathsForAssemblyResolution(DotNetResolverPaths);
        }
    	
        public int STAction()
        {	
            AddAssemblyResolver();
            STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
            WorkFlowScript script = new WorkFlowScript(ctx);
            script.InitializeComponent();
            script.Start();       
            
            return 0;
        }
        
        public void NotifyLicenseException(string msg)
        {
        		
    		try
    		{
    		    STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
                WorkFlowScript script = new WorkFlowScript(ctx);
                script.InitializeComponent();
                script.Context.ReplayClient.OnLicenseFailure(msg);
                
            }
            catch (Exception)
            {
    			// ToDo: log the error message
            }        
        }
    
    	 protected string GetTestPath()
            {
                if (CommandLineArguments != null)
                {
                    for (int i = 0; i < CommandLineArguments.Length; i++)
                    {
                        if (CommandLineArguments[i].Equals("-test", StringComparison.OrdinalIgnoreCase))
                        {
                            return CommandLineArguments[i + 1];
                        }
                    }
                }
                return String.Empty;
            }
        
    }
    
    }
    