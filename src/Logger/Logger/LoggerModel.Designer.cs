﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
<<<<<<< HEAD
// Generation date: 10/11/2014 4:51:46 PM
=======
// Generation date: 10/11/2014 9:09:35 PM
>>>>>>> origin/master
namespace Logger
{
    
    /// <summary>
    /// There are no comments for MQMEntities in the schema.
    /// </summary>
    public partial class MQMEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new MQMEntities object using the connection string found in the 'MQMEntities' section of the application configuration file.
        /// </summary>
        public MQMEntities() : 
                base("name=MQMEntities", "MQMEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new MQMEntities object.
        /// </summary>
        public MQMEntities(string connectionString) : 
                base(connectionString, "MQMEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new MQMEntities object.
        /// </summary>
        public MQMEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "MQMEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for ProcessLogs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<ProcessLogs> ProcessLogs
        {
            get
            {
                if ((this._ProcessLogs == null))
                {
                    this._ProcessLogs = base.CreateQuery<ProcessLogs>("[ProcessLogs]");
                }
                return this._ProcessLogs;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<ProcessLogs> _ProcessLogs;
        /// <summary>
        /// There are no comments for ProcessLogs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddToProcessLogs(ProcessLogs processLogs)
        {
            base.AddObject("ProcessLogs", processLogs);
        }
    }
    /// <summary>
    /// There are no comments for MQMModel.ProcessLogs in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProcessLogId
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="MQMModel", Name="ProcessLogs")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class ProcessLogs : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new ProcessLogs object.
        /// </summary>
        /// <param name="processLogId">Initial value of ProcessLogId.</param>
        /// <param name="processName">Initial value of ProcessName.</param>
        /// <param name="logCode">Initial value of LogCode.</param>
        /// <param name="logMessage">Initial value of LogMessage.</param>
        /// <param name="processPhase">Initial value of ProcessPhase.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static ProcessLogs CreateProcessLogs(long processLogId, string processName, string logCode, string logMessage, string processPhase)
        {
            ProcessLogs processLogs = new ProcessLogs();
            processLogs.ProcessLogId = processLogId;
            processLogs.ProcessName = processName;
            processLogs.LogCode = logCode;
            processLogs.LogMessage = logMessage;
            processLogs.ProcessPhase = processPhase;
            return processLogs;
        }
        /// <summary>
        /// There are no comments for property ProcessLogId in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public long ProcessLogId
        {
            get
            {
                return this._ProcessLogId;
            }
            set
            {
                this.OnProcessLogIdChanging(value);
                this.ReportPropertyChanging("ProcessLogId");
                this._ProcessLogId = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("ProcessLogId");
                this.OnProcessLogIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private long _ProcessLogId;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnProcessLogIdChanging(long value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnProcessLogIdChanged();
        /// <summary>
        /// There are no comments for property ProcessName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string ProcessName
        {
            get
            {
                return this._ProcessName;
            }
            set
            {
                this.OnProcessNameChanging(value);
                this.ReportPropertyChanging("ProcessName");
                this._ProcessName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("ProcessName");
                this.OnProcessNameChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _ProcessName;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnProcessNameChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnProcessNameChanged();
        /// <summary>
        /// There are no comments for property LogCode in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string LogCode
        {
            get
            {
                return this._LogCode;
            }
            set
            {
                this.OnLogCodeChanging(value);
                this.ReportPropertyChanging("LogCode");
                this._LogCode = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("LogCode");
                this.OnLogCodeChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _LogCode;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnLogCodeChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnLogCodeChanged();
        /// <summary>
        /// There are no comments for property LogMessage in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string LogMessage
        {
            get
            {
                return this._LogMessage;
            }
            set
            {
                this.OnLogMessageChanging(value);
                this.ReportPropertyChanging("LogMessage");
                this._LogMessage = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("LogMessage");
                this.OnLogMessageChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _LogMessage;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnLogMessageChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnLogMessageChanged();
        /// <summary>
        /// There are no comments for property ProcessPhase in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string ProcessPhase
        {
            get
            {
                return this._ProcessPhase;
            }
            set
            {
                this.OnProcessPhaseChanging(value);
                this.ReportPropertyChanging("ProcessPhase");
                this._ProcessPhase = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("ProcessPhase");
                this.OnProcessPhaseChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _ProcessPhase;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnProcessPhaseChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnProcessPhaseChanged();
        /// <summary>
        /// There are no comments for property LogDate in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Nullable<global::System.DateTime> LogDate
        {
            get
            {
                return this._LogDate;
            }
            set
            {
                this.OnLogDateChanging(value);
                this.ReportPropertyChanging("LogDate");
                this._LogDate = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("LogDate");
                this.OnLogDateChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Nullable<global::System.DateTime> _LogDate;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnLogDateChanging(global::System.Nullable<global::System.DateTime> value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnLogDateChanged();
    }
}
