using System;
    using System.Collections.Generic;
    using System.Text;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    
    namespace Script
    {
    
    public class TestEntities
    {
    public ISTRunTimeContext Context = null;
    public Dictionary<string, HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource> dataSourceNameToDataSource = new Dictionary<string, HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource>();
    
    protected HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource GetDataSource(string dataSourceName)
    {
    if(!dataSourceNameToDataSource.ContainsKey(dataSourceName))
    	throw new Exception(("A data source with the specified name does not exist."));
    return dataSourceNameToDataSource[dataSourceName];
    }
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity20 = null;
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity17 = null;
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity14 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity16 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity19 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity22 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity23 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity15 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity18 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity21 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence13 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse5Input> IfElse5 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch6 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch7 = null;
    public HP.ST.Ext.WebServicesActivities.StServiceCallActivity StServiceCallActivity4 = null;
    public HP.ST.Ext.WebServicesActivities.StServiceCallActivity StServiceCallActivity8 = null;
    
    }
    
    }
    