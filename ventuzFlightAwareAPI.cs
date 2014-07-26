using System;
using Ventuz.Kernel;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using System.Net;
using System.Threading.Tasks;

public class Script : ScriptBase, System.IDisposable
{
    
    // This member is used by the Validate() method to indicate
    // whether the Generate() method should return true or false
    // during its next execution.
    private bool changed;
	FlightXML2 df;
    // This Method is called if the component is loaded/created.
    public Script()
    {
        // Note: Accessing input or output properties from this method
        // will have no effect as they have not been allocated yet.
		
		try 
		{	        
			df = new FlightXML2();
			df.Credentials = new NetworkCredential("user_name", "api_key");
			df.PreAuthenticate = true;
		}
		catch (Exception ex)
		{
		
			Ventuz.Kernel.VLog.Info("Exception", ex.ToString());
		}


		// get the flights currently enroute.
	
		
    }
    
    // This Method is called if the component is unloaded/disposed
    public virtual void Dispose()
    {
    }
    
    // This Method is called if an input property has changed its value
    public override void Validate()
    {
        // Remember: set changed to true if any of the output 
        // properties has been changed, see Generate()
    }
    
    // This Method is called every time before a frame is rendered.
    // Return value: if true, Ventuz will notify all nodes bound to this
    //               script node that one of the script's outputs has a
    //               new value and they therefore need to validate. For
    //               performance reasons, only return true if output
    //               values really have been changed.
    public override bool Generate()
    {
        if (changed)
        {
            changed = false;
            return true;
        }

        return false;
    }
	
	public void getData()
	{
		try 
		{	        
			EnrouteStruct r = df.Enroute("KAUS", 10, "", 0);
			foreach (EnrouteFlightStruct e in r.enroute) {
				Ventuz.Kernel.VLog.Info(e.ident);
			}

		}
		catch (Exception ex)
		{
		
			Ventuz.Kernel.VLog.Info("Exception", ex.ToString());
			
		}
	
		// get the weather.
		System.Console.WriteLine(df.Metar("KAUS"));
	}
	
	// This Method is called if the function/method Method1 is invoked by the user or a bound event.
	// Return true, if this component has to be revalidated!
	public bool OnMethod1(int arg)
	{
		Task t = new Task(new Action(getData));
		t.Start();
		return false;
	}

}



[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="FlightXML2Soap", Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class FlightXML2 : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
	private System.Threading.SendOrPostCallback AircraftTypeOperationCompleted;
    
	private System.Threading.SendOrPostCallback AirlineFlightInfoOperationCompleted;
    
	private System.Threading.SendOrPostCallback AirlineFlightSchedulesOperationCompleted;
    
	private System.Threading.SendOrPostCallback AirlineInfoOperationCompleted;
    
	private System.Threading.SendOrPostCallback AirlineInsightOperationCompleted;
    
	private System.Threading.SendOrPostCallback AirportInfoOperationCompleted;
    
	private System.Threading.SendOrPostCallback AllAirlinesOperationCompleted;
    
	private System.Threading.SendOrPostCallback AllAirportsOperationCompleted;
    
	private System.Threading.SendOrPostCallback ArrivedOperationCompleted;
    
	private System.Threading.SendOrPostCallback BlockIdentCheckOperationCompleted;
    
	private System.Threading.SendOrPostCallback CountAirportOperationsOperationCompleted;
    
	private System.Threading.SendOrPostCallback CountAllEnrouteAirlineOperationsOperationCompleted;
    
	private System.Threading.SendOrPostCallback DecodeFlightRouteOperationCompleted;
    
	private System.Threading.SendOrPostCallback DecodeRouteOperationCompleted;
    
	private System.Threading.SendOrPostCallback DeleteAlertOperationCompleted;
    
	private System.Threading.SendOrPostCallback DepartedOperationCompleted;
    
	private System.Threading.SendOrPostCallback EnrouteOperationCompleted;
    
	private System.Threading.SendOrPostCallback FleetArrivedOperationCompleted;
    
	private System.Threading.SendOrPostCallback FleetScheduledOperationCompleted;
    
	private System.Threading.SendOrPostCallback FlightInfoOperationCompleted;
    
	private System.Threading.SendOrPostCallback FlightInfoExOperationCompleted;
    
	private System.Threading.SendOrPostCallback GetAlertsOperationCompleted;
    
	private System.Threading.SendOrPostCallback GetFlightIDOperationCompleted;
    
	private System.Threading.SendOrPostCallback GetHistoricalTrackOperationCompleted;
    
	private System.Threading.SendOrPostCallback GetLastTrackOperationCompleted;
    
	private System.Threading.SendOrPostCallback InboundFlightInfoOperationCompleted;
    
	private System.Threading.SendOrPostCallback InFlightInfoOperationCompleted;
    
	private System.Threading.SendOrPostCallback LatLongsToDistanceOperationCompleted;
    
	private System.Threading.SendOrPostCallback LatLongsToHeadingOperationCompleted;
    
	private System.Threading.SendOrPostCallback MapFlightOperationCompleted;
    
	private System.Threading.SendOrPostCallback MapFlightExOperationCompleted;
    
	private System.Threading.SendOrPostCallback MetarOperationCompleted;
    
	private System.Threading.SendOrPostCallback MetarExOperationCompleted;
    
	private System.Threading.SendOrPostCallback NTafOperationCompleted;
    
	private System.Threading.SendOrPostCallback RegisterAlertEndpointOperationCompleted;
    
	private System.Threading.SendOrPostCallback RoutesBetweenAirportsOperationCompleted;
    
	private System.Threading.SendOrPostCallback RoutesBetweenAirportsExOperationCompleted;
    
	private System.Threading.SendOrPostCallback ScheduledOperationCompleted;
    
	private System.Threading.SendOrPostCallback SearchOperationCompleted;
    
	private System.Threading.SendOrPostCallback SearchBirdseyeInFlightOperationCompleted;
    
	private System.Threading.SendOrPostCallback SearchBirdseyePositionsOperationCompleted;
    
	private System.Threading.SendOrPostCallback SearchCountOperationCompleted;
    
	private System.Threading.SendOrPostCallback SetAlertOperationCompleted;
    
	private System.Threading.SendOrPostCallback SetMaximumResultSizeOperationCompleted;
    
	private System.Threading.SendOrPostCallback TafOperationCompleted;
    
	private System.Threading.SendOrPostCallback TailOwnerOperationCompleted;
    
	private System.Threading.SendOrPostCallback ZipcodeInfoOperationCompleted;
    
	/// <remarks/>
	public FlightXML2() {
		this.Url = "http://flightxml.flightaware.com/soap/FlightXML2/op";
	}
    
	/// <remarks/>
	public event AircraftTypeCompletedEventHandler AircraftTypeCompleted;
    
	/// <remarks/>
	public event AirlineFlightInfoCompletedEventHandler AirlineFlightInfoCompleted;
    
	/// <remarks/>
	public event AirlineFlightSchedulesCompletedEventHandler AirlineFlightSchedulesCompleted;
    
	/// <remarks/>
	public event AirlineInfoCompletedEventHandler AirlineInfoCompleted;
    
	/// <remarks/>
	public event AirlineInsightCompletedEventHandler AirlineInsightCompleted;
    
	/// <remarks/>
	public event AirportInfoCompletedEventHandler AirportInfoCompleted;
    
	/// <remarks/>
	public event AllAirlinesCompletedEventHandler AllAirlinesCompleted;
    
	/// <remarks/>
	public event AllAirportsCompletedEventHandler AllAirportsCompleted;
    
	/// <remarks/>
	public event ArrivedCompletedEventHandler ArrivedCompleted;
    
	/// <remarks/>
	public event BlockIdentCheckCompletedEventHandler BlockIdentCheckCompleted;
    
	/// <remarks/>
	public event CountAirportOperationsCompletedEventHandler CountAirportOperationsCompleted;
    
	/// <remarks/>
	public event CountAllEnrouteAirlineOperationsCompletedEventHandler CountAllEnrouteAirlineOperationsCompleted;
    
	/// <remarks/>
	public event DecodeFlightRouteCompletedEventHandler DecodeFlightRouteCompleted;
    
	/// <remarks/>
	public event DecodeRouteCompletedEventHandler DecodeRouteCompleted;
    
	/// <remarks/>
	public event DeleteAlertCompletedEventHandler DeleteAlertCompleted;
    
	/// <remarks/>
	public event DepartedCompletedEventHandler DepartedCompleted;
    
	/// <remarks/>
	public event EnrouteCompletedEventHandler EnrouteCompleted;
    
	/// <remarks/>
	public event FleetArrivedCompletedEventHandler FleetArrivedCompleted;
    
	/// <remarks/>
	public event FleetScheduledCompletedEventHandler FleetScheduledCompleted;
    
	/// <remarks/>
	public event FlightInfoCompletedEventHandler FlightInfoCompleted;
    
	/// <remarks/>
	public event FlightInfoExCompletedEventHandler FlightInfoExCompleted;
    
	/// <remarks/>
	public event GetAlertsCompletedEventHandler GetAlertsCompleted;
    
	/// <remarks/>
	public event GetFlightIDCompletedEventHandler GetFlightIDCompleted;
    
	/// <remarks/>
	public event GetHistoricalTrackCompletedEventHandler GetHistoricalTrackCompleted;
    
	/// <remarks/>
	public event GetLastTrackCompletedEventHandler GetLastTrackCompleted;
    
	/// <remarks/>
	public event InboundFlightInfoCompletedEventHandler InboundFlightInfoCompleted;
    
	/// <remarks/>
	public event InFlightInfoCompletedEventHandler InFlightInfoCompleted;
    
	/// <remarks/>
	public event LatLongsToDistanceCompletedEventHandler LatLongsToDistanceCompleted;
    
	/// <remarks/>
	public event LatLongsToHeadingCompletedEventHandler LatLongsToHeadingCompleted;
    
	/// <remarks/>
	public event MapFlightCompletedEventHandler MapFlightCompleted;
    
	/// <remarks/>
	public event MapFlightExCompletedEventHandler MapFlightExCompleted;
    
	/// <remarks/>
	public event MetarCompletedEventHandler MetarCompleted;
    
	/// <remarks/>
	public event MetarExCompletedEventHandler MetarExCompleted;
    
	/// <remarks/>
	public event NTafCompletedEventHandler NTafCompleted;
    
	/// <remarks/>
	public event RegisterAlertEndpointCompletedEventHandler RegisterAlertEndpointCompleted;
    
	/// <remarks/>
	public event RoutesBetweenAirportsCompletedEventHandler RoutesBetweenAirportsCompleted;
    
	/// <remarks/>
	public event RoutesBetweenAirportsExCompletedEventHandler RoutesBetweenAirportsExCompleted;
    
	/// <remarks/>
	public event ScheduledCompletedEventHandler ScheduledCompleted;
    
	/// <remarks/>
	public event SearchCompletedEventHandler SearchCompleted;
    
	/// <remarks/>
	public event SearchBirdseyeInFlightCompletedEventHandler SearchBirdseyeInFlightCompleted;
    
	/// <remarks/>
	public event SearchBirdseyePositionsCompletedEventHandler SearchBirdseyePositionsCompleted;
    
	/// <remarks/>
	public event SearchCountCompletedEventHandler SearchCountCompleted;
    
	/// <remarks/>
	public event SetAlertCompletedEventHandler SetAlertCompleted;
    
	/// <remarks/>
	public event SetMaximumResultSizeCompletedEventHandler SetMaximumResultSizeCompleted;
    
	/// <remarks/>
	public event TafCompletedEventHandler TafCompleted;
    
	/// <remarks/>
	public event TailOwnerCompletedEventHandler TailOwnerCompleted;
    
	/// <remarks/>
	public event ZipcodeInfoCompletedEventHandler ZipcodeInfoCompleted;
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:AircraftType", RequestElementName="AircraftTypeRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="AircraftTypeResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public AircraftTypeStruct AircraftType(string type) {
		object[] results = this.Invoke("AircraftType", new object[] {
			type});
		return ((AircraftTypeStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginAircraftType(string type, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("AircraftType", new object[] {
			type}, callback, asyncState);
	}
    
	/// <remarks/>
	public AircraftTypeStruct EndAircraftType(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((AircraftTypeStruct) (results[0]));
	}
    
	/// <remarks/>
	public void AircraftTypeAsync(string type) {
		this.AircraftTypeAsync(type, null);
	}
    
	/// <remarks/>
	public void AircraftTypeAsync(string type, object userState) {
		if ((this.AircraftTypeOperationCompleted == null)) {
			this.AircraftTypeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAircraftTypeOperationCompleted);
		}
		this.InvokeAsync("AircraftType", new object[] {
			type}, this.AircraftTypeOperationCompleted, userState);
	}
    
	private void OnAircraftTypeOperationCompleted(object arg) {
		if ((this.AircraftTypeCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.AircraftTypeCompleted(this, new AircraftTypeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:AirlineFlightInfo", RequestElementName="AirlineFlightInfoRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="AirlineFlightInfoResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public AirlineFlightInfoStruct AirlineFlightInfo(string faFlightID) {
		object[] results = this.Invoke("AirlineFlightInfo", new object[] {
			faFlightID});
		return ((AirlineFlightInfoStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginAirlineFlightInfo(string faFlightID, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("AirlineFlightInfo", new object[] {
			faFlightID}, callback, asyncState);
	}
    
	/// <remarks/>
	public AirlineFlightInfoStruct EndAirlineFlightInfo(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((AirlineFlightInfoStruct) (results[0]));
	}
    
	/// <remarks/>
	public void AirlineFlightInfoAsync(string faFlightID) {
		this.AirlineFlightInfoAsync(faFlightID, null);
	}
    
	/// <remarks/>
	public void AirlineFlightInfoAsync(string faFlightID, object userState) {
		if ((this.AirlineFlightInfoOperationCompleted == null)) {
			this.AirlineFlightInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAirlineFlightInfoOperationCompleted);
		}
		this.InvokeAsync("AirlineFlightInfo", new object[] {
			faFlightID}, this.AirlineFlightInfoOperationCompleted, userState);
	}
    
	private void OnAirlineFlightInfoOperationCompleted(object arg) {
		if ((this.AirlineFlightInfoCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.AirlineFlightInfoCompleted(this, new AirlineFlightInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:AirlineFlightSchedules", RequestElementName="AirlineFlightSchedulesRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="AirlineFlightSchedulesResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public ArrayOfAirlineFlightScheduleStruct AirlineFlightSchedules(int startDate, int endDate, string origin, string destination, string airline, string flightno, int howMany, int offset) {
		object[] results = this.Invoke("AirlineFlightSchedules", new object[] {
			startDate,
			endDate,
			origin,
			destination,
			airline,
			flightno,
			howMany,
			offset});
		return ((ArrayOfAirlineFlightScheduleStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginAirlineFlightSchedules(int startDate, int endDate, string origin, string destination, string airline, string flightno, int howMany, int offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("AirlineFlightSchedules", new object[] {
			startDate,
			endDate,
			origin,
			destination,
			airline,
			flightno,
			howMany,
			offset}, callback, asyncState);
	}
    
	/// <remarks/>
	public ArrayOfAirlineFlightScheduleStruct EndAirlineFlightSchedules(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((ArrayOfAirlineFlightScheduleStruct) (results[0]));
	}
    
	/// <remarks/>
	public void AirlineFlightSchedulesAsync(int startDate, int endDate, string origin, string destination, string airline, string flightno, int howMany, int offset) {
		this.AirlineFlightSchedulesAsync(startDate, endDate, origin, destination, airline, flightno, howMany, offset, null);
	}
    
	/// <remarks/>
	public void AirlineFlightSchedulesAsync(int startDate, int endDate, string origin, string destination, string airline, string flightno, int howMany, int offset, object userState) {
		if ((this.AirlineFlightSchedulesOperationCompleted == null)) {
			this.AirlineFlightSchedulesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAirlineFlightSchedulesOperationCompleted);
		}
		this.InvokeAsync("AirlineFlightSchedules", new object[] {
			startDate,
			endDate,
			origin,
			destination,
			airline,
			flightno,
			howMany,
			offset}, this.AirlineFlightSchedulesOperationCompleted, userState);
	}
    
	private void OnAirlineFlightSchedulesOperationCompleted(object arg) {
		if ((this.AirlineFlightSchedulesCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.AirlineFlightSchedulesCompleted(this, new AirlineFlightSchedulesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:AirlineInfo", RequestElementName="AirlineInfoRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="AirlineInfoResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public AirlineInfoStruct AirlineInfo(string airlineCode) {
		object[] results = this.Invoke("AirlineInfo", new object[] {
			airlineCode});
		return ((AirlineInfoStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginAirlineInfo(string airlineCode, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("AirlineInfo", new object[] {
			airlineCode}, callback, asyncState);
	}
    
	/// <remarks/>
	public AirlineInfoStruct EndAirlineInfo(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((AirlineInfoStruct) (results[0]));
	}
    
	/// <remarks/>
	public void AirlineInfoAsync(string airlineCode) {
		this.AirlineInfoAsync(airlineCode, null);
	}
    
	/// <remarks/>
	public void AirlineInfoAsync(string airlineCode, object userState) {
		if ((this.AirlineInfoOperationCompleted == null)) {
			this.AirlineInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAirlineInfoOperationCompleted);
		}
		this.InvokeAsync("AirlineInfo", new object[] {
			airlineCode}, this.AirlineInfoOperationCompleted, userState);
	}
    
	private void OnAirlineInfoOperationCompleted(object arg) {
		if ((this.AirlineInfoCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.AirlineInfoCompleted(this, new AirlineInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:AirlineInsight", RequestElementName="AirlineInsightRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="AirlineInsightResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public ArrayOfAirlineInsightStruct AirlineInsight(string origin, string destination, int reportType) {
		object[] results = this.Invoke("AirlineInsight", new object[] {
			origin,
			destination,
			reportType});
		return ((ArrayOfAirlineInsightStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginAirlineInsight(string origin, string destination, int reportType, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("AirlineInsight", new object[] {
			origin,
			destination,
			reportType}, callback, asyncState);
	}
    
	/// <remarks/>
	public ArrayOfAirlineInsightStruct EndAirlineInsight(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((ArrayOfAirlineInsightStruct) (results[0]));
	}
    
	/// <remarks/>
	public void AirlineInsightAsync(string origin, string destination, int reportType) {
		this.AirlineInsightAsync(origin, destination, reportType, null);
	}
    
	/// <remarks/>
	public void AirlineInsightAsync(string origin, string destination, int reportType, object userState) {
		if ((this.AirlineInsightOperationCompleted == null)) {
			this.AirlineInsightOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAirlineInsightOperationCompleted);
		}
		this.InvokeAsync("AirlineInsight", new object[] {
			origin,
			destination,
			reportType}, this.AirlineInsightOperationCompleted, userState);
	}
    
	private void OnAirlineInsightOperationCompleted(object arg) {
		if ((this.AirlineInsightCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.AirlineInsightCompleted(this, new AirlineInsightCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:AirportInfo", RequestElementName="AirportInfoRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="AirportInfoResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public AirportInfoStruct AirportInfo(string airportCode) {
		object[] results = this.Invoke("AirportInfo", new object[] {
			airportCode});
		return ((AirportInfoStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginAirportInfo(string airportCode, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("AirportInfo", new object[] {
			airportCode}, callback, asyncState);
	}
    
	/// <remarks/>
	public AirportInfoStruct EndAirportInfo(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((AirportInfoStruct) (results[0]));
	}
    
	/// <remarks/>
	public void AirportInfoAsync(string airportCode) {
		this.AirportInfoAsync(airportCode, null);
	}
    
	/// <remarks/>
	public void AirportInfoAsync(string airportCode, object userState) {
		if ((this.AirportInfoOperationCompleted == null)) {
			this.AirportInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAirportInfoOperationCompleted);
		}
		this.InvokeAsync("AirportInfo", new object[] {
			airportCode}, this.AirportInfoOperationCompleted, userState);
	}
    
	private void OnAirportInfoOperationCompleted(object arg) {
		if ((this.AirportInfoCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.AirportInfoCompleted(this, new AirportInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:AllAirlines", RequestElementName="AllAirlinesRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="AllAirlinesResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	[return: System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable=false)]
	public string[] AllAirlines() {
		object[] results = this.Invoke("AllAirlines", new object[0]);
		return ((string[]) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginAllAirlines(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("AllAirlines", new object[0], callback, asyncState);
	}
    
	/// <remarks/>
	public string[] EndAllAirlines(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((string[]) (results[0]));
	}
    
	/// <remarks/>
	public void AllAirlinesAsync() {
		this.AllAirlinesAsync(null);
	}
    
	/// <remarks/>
	public void AllAirlinesAsync(object userState) {
		if ((this.AllAirlinesOperationCompleted == null)) {
			this.AllAirlinesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAllAirlinesOperationCompleted);
		}
		this.InvokeAsync("AllAirlines", new object[0], this.AllAirlinesOperationCompleted, userState);
	}
    
	private void OnAllAirlinesOperationCompleted(object arg) {
		if ((this.AllAirlinesCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.AllAirlinesCompleted(this, new AllAirlinesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:AllAirports", RequestElementName="AllAirportsRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="AllAirportsResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	[return: System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable=false)]
	public string[] AllAirports() {
		object[] results = this.Invoke("AllAirports", new object[0]);
		return ((string[]) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginAllAirports(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("AllAirports", new object[0], callback, asyncState);
	}
    
	/// <remarks/>
	public string[] EndAllAirports(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((string[]) (results[0]));
	}
    
	/// <remarks/>
	public void AllAirportsAsync() {
		this.AllAirportsAsync(null);
	}
    
	/// <remarks/>
	public void AllAirportsAsync(object userState) {
		if ((this.AllAirportsOperationCompleted == null)) {
			this.AllAirportsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAllAirportsOperationCompleted);
		}
		this.InvokeAsync("AllAirports", new object[0], this.AllAirportsOperationCompleted, userState);
	}
    
	private void OnAllAirportsOperationCompleted(object arg) {
		if ((this.AllAirportsCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.AllAirportsCompleted(this, new AllAirportsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:Arrived", RequestElementName="ArrivedRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="ArrivedResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public ArrivalStruct Arrived(string airport, int howMany, string filter, int offset) {
		object[] results = this.Invoke("Arrived", new object[] {
			airport,
			howMany,
			filter,
			offset});
		return ((ArrivalStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginArrived(string airport, int howMany, string filter, int offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("Arrived", new object[] {
			airport,
			howMany,
			filter,
			offset}, callback, asyncState);
	}
    
	/// <remarks/>
	public ArrivalStruct EndArrived(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((ArrivalStruct) (results[0]));
	}
    
	/// <remarks/>
	public void ArrivedAsync(string airport, int howMany, string filter, int offset) {
		this.ArrivedAsync(airport, howMany, filter, offset, null);
	}
    
	/// <remarks/>
	public void ArrivedAsync(string airport, int howMany, string filter, int offset, object userState) {
		if ((this.ArrivedOperationCompleted == null)) {
			this.ArrivedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnArrivedOperationCompleted);
		}
		this.InvokeAsync("Arrived", new object[] {
			airport,
			howMany,
			filter,
			offset}, this.ArrivedOperationCompleted, userState);
	}
    
	private void OnArrivedOperationCompleted(object arg) {
		if ((this.ArrivedCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.ArrivedCompleted(this, new ArrivedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:BlockIdentCheck", RequestElementName="BlockIdentCheckRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="BlockIdentCheckResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public int BlockIdentCheck(string ident) {
		object[] results = this.Invoke("BlockIdentCheck", new object[] {
			ident});
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginBlockIdentCheck(string ident, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("BlockIdentCheck", new object[] {
			ident}, callback, asyncState);
	}
    
	/// <remarks/>
	public int EndBlockIdentCheck(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public void BlockIdentCheckAsync(string ident) {
		this.BlockIdentCheckAsync(ident, null);
	}
    
	/// <remarks/>
	public void BlockIdentCheckAsync(string ident, object userState) {
		if ((this.BlockIdentCheckOperationCompleted == null)) {
			this.BlockIdentCheckOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBlockIdentCheckOperationCompleted);
		}
		this.InvokeAsync("BlockIdentCheck", new object[] {
			ident}, this.BlockIdentCheckOperationCompleted, userState);
	}
    
	private void OnBlockIdentCheckOperationCompleted(object arg) {
		if ((this.BlockIdentCheckCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.BlockIdentCheckCompleted(this, new BlockIdentCheckCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:CountAirportOperations", RequestElementName="CountAirportOperationsRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="CountAirportOperationsResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public CountAirportOperationsStruct CountAirportOperations(string airport) {
		object[] results = this.Invoke("CountAirportOperations", new object[] {
			airport});
		return ((CountAirportOperationsStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginCountAirportOperations(string airport, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("CountAirportOperations", new object[] {
			airport}, callback, asyncState);
	}
    
	/// <remarks/>
	public CountAirportOperationsStruct EndCountAirportOperations(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((CountAirportOperationsStruct) (results[0]));
	}
    
	/// <remarks/>
	public void CountAirportOperationsAsync(string airport) {
		this.CountAirportOperationsAsync(airport, null);
	}
    
	/// <remarks/>
	public void CountAirportOperationsAsync(string airport, object userState) {
		if ((this.CountAirportOperationsOperationCompleted == null)) {
			this.CountAirportOperationsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCountAirportOperationsOperationCompleted);
		}
		this.InvokeAsync("CountAirportOperations", new object[] {
			airport}, this.CountAirportOperationsOperationCompleted, userState);
	}
    
	private void OnCountAirportOperationsOperationCompleted(object arg) {
		if ((this.CountAirportOperationsCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.CountAirportOperationsCompleted(this, new CountAirportOperationsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:CountAllEnrouteAirlineOperations", RequestElementName="CountAllEnrouteAirlineOperationsRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="CountAllEnrouteAirlineOperationsResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	[return: System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable=false)]
	public CountAirlineOperationsStruct[] CountAllEnrouteAirlineOperations() {
		object[] results = this.Invoke("CountAllEnrouteAirlineOperations", new object[0]);
		return ((CountAirlineOperationsStruct[]) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginCountAllEnrouteAirlineOperations(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("CountAllEnrouteAirlineOperations", new object[0], callback, asyncState);
	}
    
	/// <remarks/>
	public CountAirlineOperationsStruct[] EndCountAllEnrouteAirlineOperations(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((CountAirlineOperationsStruct[]) (results[0]));
	}
    
	/// <remarks/>
	public void CountAllEnrouteAirlineOperationsAsync() {
		this.CountAllEnrouteAirlineOperationsAsync(null);
	}
    
	/// <remarks/>
	public void CountAllEnrouteAirlineOperationsAsync(object userState) {
		if ((this.CountAllEnrouteAirlineOperationsOperationCompleted == null)) {
			this.CountAllEnrouteAirlineOperationsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCountAllEnrouteAirlineOperationsOperationCompleted);
		}
		this.InvokeAsync("CountAllEnrouteAirlineOperations", new object[0], this.CountAllEnrouteAirlineOperationsOperationCompleted, userState);
	}
    
	private void OnCountAllEnrouteAirlineOperationsOperationCompleted(object arg) {
		if ((this.CountAllEnrouteAirlineOperationsCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.CountAllEnrouteAirlineOperationsCompleted(this, new CountAllEnrouteAirlineOperationsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:DecodeFlightRoute", RequestElementName="DecodeFlightRouteRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="DecodeFlightRouteResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public ArrayOfFlightRouteStruct DecodeFlightRoute(string faFlightID) {
		object[] results = this.Invoke("DecodeFlightRoute", new object[] {
			faFlightID});
		return ((ArrayOfFlightRouteStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginDecodeFlightRoute(string faFlightID, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("DecodeFlightRoute", new object[] {
			faFlightID}, callback, asyncState);
	}
    
	/// <remarks/>
	public ArrayOfFlightRouteStruct EndDecodeFlightRoute(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((ArrayOfFlightRouteStruct) (results[0]));
	}
    
	/// <remarks/>
	public void DecodeFlightRouteAsync(string faFlightID) {
		this.DecodeFlightRouteAsync(faFlightID, null);
	}
    
	/// <remarks/>
	public void DecodeFlightRouteAsync(string faFlightID, object userState) {
		if ((this.DecodeFlightRouteOperationCompleted == null)) {
			this.DecodeFlightRouteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDecodeFlightRouteOperationCompleted);
		}
		this.InvokeAsync("DecodeFlightRoute", new object[] {
			faFlightID}, this.DecodeFlightRouteOperationCompleted, userState);
	}
    
	private void OnDecodeFlightRouteOperationCompleted(object arg) {
		if ((this.DecodeFlightRouteCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.DecodeFlightRouteCompleted(this, new DecodeFlightRouteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:DecodeRoute", RequestElementName="DecodeRouteRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="DecodeRouteResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public ArrayOfFlightRouteStruct DecodeRoute(string origin, string route, string destination) {
		object[] results = this.Invoke("DecodeRoute", new object[] {
			origin,
			route,
			destination});
		return ((ArrayOfFlightRouteStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginDecodeRoute(string origin, string route, string destination, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("DecodeRoute", new object[] {
			origin,
			route,
			destination}, callback, asyncState);
	}
    
	/// <remarks/>
	public ArrayOfFlightRouteStruct EndDecodeRoute(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((ArrayOfFlightRouteStruct) (results[0]));
	}
    
	/// <remarks/>
	public void DecodeRouteAsync(string origin, string route, string destination) {
		this.DecodeRouteAsync(origin, route, destination, null);
	}
    
	/// <remarks/>
	public void DecodeRouteAsync(string origin, string route, string destination, object userState) {
		if ((this.DecodeRouteOperationCompleted == null)) {
			this.DecodeRouteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDecodeRouteOperationCompleted);
		}
		this.InvokeAsync("DecodeRoute", new object[] {
			origin,
			route,
			destination}, this.DecodeRouteOperationCompleted, userState);
	}
    
	private void OnDecodeRouteOperationCompleted(object arg) {
		if ((this.DecodeRouteCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.DecodeRouteCompleted(this, new DecodeRouteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:DeleteAlert", RequestElementName="DeleteAlertRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="DeleteAlertResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public int DeleteAlert(int alert_id) {
		object[] results = this.Invoke("DeleteAlert", new object[] {
			alert_id});
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginDeleteAlert(int alert_id, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("DeleteAlert", new object[] {
			alert_id}, callback, asyncState);
	}
    
	/// <remarks/>
	public int EndDeleteAlert(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public void DeleteAlertAsync(int alert_id) {
		this.DeleteAlertAsync(alert_id, null);
	}
    
	/// <remarks/>
	public void DeleteAlertAsync(int alert_id, object userState) {
		if ((this.DeleteAlertOperationCompleted == null)) {
			this.DeleteAlertOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteAlertOperationCompleted);
		}
		this.InvokeAsync("DeleteAlert", new object[] {
			alert_id}, this.DeleteAlertOperationCompleted, userState);
	}
    
	private void OnDeleteAlertOperationCompleted(object arg) {
		if ((this.DeleteAlertCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.DeleteAlertCompleted(this, new DeleteAlertCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:Departed", RequestElementName="DepartedRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="DepartedResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public DepartureStruct Departed(string airport, int howMany, string filter, int offset) {
		object[] results = this.Invoke("Departed", new object[] {
			airport,
			howMany,
			filter,
			offset});
		return ((DepartureStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginDeparted(string airport, int howMany, string filter, int offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("Departed", new object[] {
			airport,
			howMany,
			filter,
			offset}, callback, asyncState);
	}
    
	/// <remarks/>
	public DepartureStruct EndDeparted(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((DepartureStruct) (results[0]));
	}
    
	/// <remarks/>
	public void DepartedAsync(string airport, int howMany, string filter, int offset) {
		this.DepartedAsync(airport, howMany, filter, offset, null);
	}
    
	/// <remarks/>
	public void DepartedAsync(string airport, int howMany, string filter, int offset, object userState) {
		if ((this.DepartedOperationCompleted == null)) {
			this.DepartedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDepartedOperationCompleted);
		}
		this.InvokeAsync("Departed", new object[] {
			airport,
			howMany,
			filter,
			offset}, this.DepartedOperationCompleted, userState);
	}
    
	private void OnDepartedOperationCompleted(object arg) {
		if ((this.DepartedCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.DepartedCompleted(this, new DepartedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:Enroute", RequestElementName="EnrouteRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="EnrouteResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public EnrouteStruct Enroute(string airport, int howMany, string filter, int offset) {
		object[] results = this.Invoke("Enroute", new object[] {
			airport,
			howMany,
			filter,
			offset});
		return ((EnrouteStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginEnroute(string airport, int howMany, string filter, int offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("Enroute", new object[] {
			airport,
			howMany,
			filter,
			offset}, callback, asyncState);
	}
    
	/// <remarks/>
	public EnrouteStruct EndEnroute(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((EnrouteStruct) (results[0]));
	}
    
	/// <remarks/>
	public void EnrouteAsync(string airport, int howMany, string filter, int offset) {
		this.EnrouteAsync(airport, howMany, filter, offset, null);
	}
    
	/// <remarks/>
	public void EnrouteAsync(string airport, int howMany, string filter, int offset, object userState) {
		if ((this.EnrouteOperationCompleted == null)) {
			this.EnrouteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEnrouteOperationCompleted);
		}
		this.InvokeAsync("Enroute", new object[] {
			airport,
			howMany,
			filter,
			offset}, this.EnrouteOperationCompleted, userState);
	}
    
	private void OnEnrouteOperationCompleted(object arg) {
		if ((this.EnrouteCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.EnrouteCompleted(this, new EnrouteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:FleetArrived", RequestElementName="FleetArrivedRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="FleetArrivedResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public ArrivalStruct FleetArrived(string fleet, int howMany, int offset) {
		object[] results = this.Invoke("FleetArrived", new object[] {
			fleet,
			howMany,
			offset});
		return ((ArrivalStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginFleetArrived(string fleet, int howMany, int offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("FleetArrived", new object[] {
			fleet,
			howMany,
			offset}, callback, asyncState);
	}
    
	/// <remarks/>
	public ArrivalStruct EndFleetArrived(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((ArrivalStruct) (results[0]));
	}
    
	/// <remarks/>
	public void FleetArrivedAsync(string fleet, int howMany, int offset) {
		this.FleetArrivedAsync(fleet, howMany, offset, null);
	}
    
	/// <remarks/>
	public void FleetArrivedAsync(string fleet, int howMany, int offset, object userState) {
		if ((this.FleetArrivedOperationCompleted == null)) {
			this.FleetArrivedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFleetArrivedOperationCompleted);
		}
		this.InvokeAsync("FleetArrived", new object[] {
			fleet,
			howMany,
			offset}, this.FleetArrivedOperationCompleted, userState);
	}
    
	private void OnFleetArrivedOperationCompleted(object arg) {
		if ((this.FleetArrivedCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.FleetArrivedCompleted(this, new FleetArrivedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:FleetScheduled", RequestElementName="FleetScheduledRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="FleetScheduledResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public ScheduledStruct FleetScheduled(string fleet, int howMany, int offset) {
		object[] results = this.Invoke("FleetScheduled", new object[] {
			fleet,
			howMany,
			offset});
		return ((ScheduledStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginFleetScheduled(string fleet, int howMany, int offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("FleetScheduled", new object[] {
			fleet,
			howMany,
			offset}, callback, asyncState);
	}
    
	/// <remarks/>
	public ScheduledStruct EndFleetScheduled(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((ScheduledStruct) (results[0]));
	}
    
	/// <remarks/>
	public void FleetScheduledAsync(string fleet, int howMany, int offset) {
		this.FleetScheduledAsync(fleet, howMany, offset, null);
	}
    
	/// <remarks/>
	public void FleetScheduledAsync(string fleet, int howMany, int offset, object userState) {
		if ((this.FleetScheduledOperationCompleted == null)) {
			this.FleetScheduledOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFleetScheduledOperationCompleted);
		}
		this.InvokeAsync("FleetScheduled", new object[] {
			fleet,
			howMany,
			offset}, this.FleetScheduledOperationCompleted, userState);
	}
    
	private void OnFleetScheduledOperationCompleted(object arg) {
		if ((this.FleetScheduledCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.FleetScheduledCompleted(this, new FleetScheduledCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:FlightInfo", RequestElementName="FlightInfoRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="FlightInfoResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public FlightInfoStruct FlightInfo(string ident, int howMany) {
		object[] results = this.Invoke("FlightInfo", new object[] {
			ident,
			howMany});
		return ((FlightInfoStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginFlightInfo(string ident, int howMany, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("FlightInfo", new object[] {
			ident,
			howMany}, callback, asyncState);
	}
    
	/// <remarks/>
	public FlightInfoStruct EndFlightInfo(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((FlightInfoStruct) (results[0]));
	}
    
	/// <remarks/>
	public void FlightInfoAsync(string ident, int howMany) {
		this.FlightInfoAsync(ident, howMany, null);
	}
    
	/// <remarks/>
	public void FlightInfoAsync(string ident, int howMany, object userState) {
		if ((this.FlightInfoOperationCompleted == null)) {
			this.FlightInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFlightInfoOperationCompleted);
		}
		this.InvokeAsync("FlightInfo", new object[] {
			ident,
			howMany}, this.FlightInfoOperationCompleted, userState);
	}
    
	private void OnFlightInfoOperationCompleted(object arg) {
		if ((this.FlightInfoCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.FlightInfoCompleted(this, new FlightInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:FlightInfoEx", RequestElementName="FlightInfoExRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="FlightInfoExResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public FlightInfoExStruct FlightInfoEx(string ident, int howMany, int offset) {
		object[] results = this.Invoke("FlightInfoEx", new object[] {
			ident,
			howMany,
			offset});
		return ((FlightInfoExStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginFlightInfoEx(string ident, int howMany, int offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("FlightInfoEx", new object[] {
			ident,
			howMany,
			offset}, callback, asyncState);
	}
    
	/// <remarks/>
	public FlightInfoExStruct EndFlightInfoEx(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((FlightInfoExStruct) (results[0]));
	}
    
	/// <remarks/>
	public void FlightInfoExAsync(string ident, int howMany, int offset) {
		this.FlightInfoExAsync(ident, howMany, offset, null);
	}
    
	/// <remarks/>
	public void FlightInfoExAsync(string ident, int howMany, int offset, object userState) {
		if ((this.FlightInfoExOperationCompleted == null)) {
			this.FlightInfoExOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFlightInfoExOperationCompleted);
		}
		this.InvokeAsync("FlightInfoEx", new object[] {
			ident,
			howMany,
			offset}, this.FlightInfoExOperationCompleted, userState);
	}
    
	private void OnFlightInfoExOperationCompleted(object arg) {
		if ((this.FlightInfoExCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.FlightInfoExCompleted(this, new FlightInfoExCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:GetAlerts", RequestElementName="GetAlertsRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="GetAlertsResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public FlightAlertListing GetAlerts() {
		object[] results = this.Invoke("GetAlerts", new object[0]);
		return ((FlightAlertListing) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginGetAlerts(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("GetAlerts", new object[0], callback, asyncState);
	}
    
	/// <remarks/>
	public FlightAlertListing EndGetAlerts(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((FlightAlertListing) (results[0]));
	}
    
	/// <remarks/>
	public void GetAlertsAsync() {
		this.GetAlertsAsync(null);
	}
    
	/// <remarks/>
	public void GetAlertsAsync(object userState) {
		if ((this.GetAlertsOperationCompleted == null)) {
			this.GetAlertsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAlertsOperationCompleted);
		}
		this.InvokeAsync("GetAlerts", new object[0], this.GetAlertsOperationCompleted, userState);
	}
    
	private void OnGetAlertsOperationCompleted(object arg) {
		if ((this.GetAlertsCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.GetAlertsCompleted(this, new GetAlertsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:GetFlightID", RequestElementName="GetFlightIDRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="GetFlightIDResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public string GetFlightID(string ident, int departureTime) {
		object[] results = this.Invoke("GetFlightID", new object[] {
			ident,
			departureTime});
		return ((string) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginGetFlightID(string ident, int departureTime, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("GetFlightID", new object[] {
			ident,
			departureTime}, callback, asyncState);
	}
    
	/// <remarks/>
	public string EndGetFlightID(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((string) (results[0]));
	}
    
	/// <remarks/>
	public void GetFlightIDAsync(string ident, int departureTime) {
		this.GetFlightIDAsync(ident, departureTime, null);
	}
    
	/// <remarks/>
	public void GetFlightIDAsync(string ident, int departureTime, object userState) {
		if ((this.GetFlightIDOperationCompleted == null)) {
			this.GetFlightIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFlightIDOperationCompleted);
		}
		this.InvokeAsync("GetFlightID", new object[] {
			ident,
			departureTime}, this.GetFlightIDOperationCompleted, userState);
	}
    
	private void OnGetFlightIDOperationCompleted(object arg) {
		if ((this.GetFlightIDCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.GetFlightIDCompleted(this, new GetFlightIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:GetHistoricalTrack", RequestElementName="GetHistoricalTrackRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="GetHistoricalTrackResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	[return: System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable=false)]
	public TrackStruct[] GetHistoricalTrack(string faFlightID) {
		object[] results = this.Invoke("GetHistoricalTrack", new object[] {
			faFlightID});
		return ((TrackStruct[]) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginGetHistoricalTrack(string faFlightID, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("GetHistoricalTrack", new object[] {
			faFlightID}, callback, asyncState);
	}
    
	/// <remarks/>
	public TrackStruct[] EndGetHistoricalTrack(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((TrackStruct[]) (results[0]));
	}
    
	/// <remarks/>
	public void GetHistoricalTrackAsync(string faFlightID) {
		this.GetHistoricalTrackAsync(faFlightID, null);
	}
    
	/// <remarks/>
	public void GetHistoricalTrackAsync(string faFlightID, object userState) {
		if ((this.GetHistoricalTrackOperationCompleted == null)) {
			this.GetHistoricalTrackOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetHistoricalTrackOperationCompleted);
		}
		this.InvokeAsync("GetHistoricalTrack", new object[] {
			faFlightID}, this.GetHistoricalTrackOperationCompleted, userState);
	}
    
	private void OnGetHistoricalTrackOperationCompleted(object arg) {
		if ((this.GetHistoricalTrackCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.GetHistoricalTrackCompleted(this, new GetHistoricalTrackCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:GetLastTrack", RequestElementName="GetLastTrackRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="GetLastTrackResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	[return: System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable=false)]
	public TrackStruct[] GetLastTrack(string ident) {
		object[] results = this.Invoke("GetLastTrack", new object[] {
			ident});
		return ((TrackStruct[]) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginGetLastTrack(string ident, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("GetLastTrack", new object[] {
			ident}, callback, asyncState);
	}
    
	/// <remarks/>
	public TrackStruct[] EndGetLastTrack(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((TrackStruct[]) (results[0]));
	}
    
	/// <remarks/>
	public void GetLastTrackAsync(string ident) {
		this.GetLastTrackAsync(ident, null);
	}
    
	/// <remarks/>
	public void GetLastTrackAsync(string ident, object userState) {
		if ((this.GetLastTrackOperationCompleted == null)) {
			this.GetLastTrackOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetLastTrackOperationCompleted);
		}
		this.InvokeAsync("GetLastTrack", new object[] {
			ident}, this.GetLastTrackOperationCompleted, userState);
	}
    
	private void OnGetLastTrackOperationCompleted(object arg) {
		if ((this.GetLastTrackCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.GetLastTrackCompleted(this, new GetLastTrackCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:InboundFlightInfo", RequestElementName="InboundFlightInfoRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="InboundFlightInfoResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public FlightExStruct InboundFlightInfo(string faFlightID) {
		object[] results = this.Invoke("InboundFlightInfo", new object[] {
			faFlightID});
		return ((FlightExStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginInboundFlightInfo(string faFlightID, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("InboundFlightInfo", new object[] {
			faFlightID}, callback, asyncState);
	}
    
	/// <remarks/>
	public FlightExStruct EndInboundFlightInfo(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((FlightExStruct) (results[0]));
	}
    
	/// <remarks/>
	public void InboundFlightInfoAsync(string faFlightID) {
		this.InboundFlightInfoAsync(faFlightID, null);
	}
    
	/// <remarks/>
	public void InboundFlightInfoAsync(string faFlightID, object userState) {
		if ((this.InboundFlightInfoOperationCompleted == null)) {
			this.InboundFlightInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInboundFlightInfoOperationCompleted);
		}
		this.InvokeAsync("InboundFlightInfo", new object[] {
			faFlightID}, this.InboundFlightInfoOperationCompleted, userState);
	}
    
	private void OnInboundFlightInfoOperationCompleted(object arg) {
		if ((this.InboundFlightInfoCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.InboundFlightInfoCompleted(this, new InboundFlightInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:InFlightInfo", RequestElementName="InFlightInfoRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="InFlightInfoResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public InFlightAircraftStruct InFlightInfo(string ident) {
		object[] results = this.Invoke("InFlightInfo", new object[] {
			ident});
		return ((InFlightAircraftStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginInFlightInfo(string ident, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("InFlightInfo", new object[] {
			ident}, callback, asyncState);
	}
    
	/// <remarks/>
	public InFlightAircraftStruct EndInFlightInfo(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((InFlightAircraftStruct) (results[0]));
	}
    
	/// <remarks/>
	public void InFlightInfoAsync(string ident) {
		this.InFlightInfoAsync(ident, null);
	}
    
	/// <remarks/>
	public void InFlightInfoAsync(string ident, object userState) {
		if ((this.InFlightInfoOperationCompleted == null)) {
			this.InFlightInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInFlightInfoOperationCompleted);
		}
		this.InvokeAsync("InFlightInfo", new object[] {
			ident}, this.InFlightInfoOperationCompleted, userState);
	}
    
	private void OnInFlightInfoOperationCompleted(object arg) {
		if ((this.InFlightInfoCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.InFlightInfoCompleted(this, new InFlightInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:LatLongsToDistance", RequestElementName="LatLongsToDistanceRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="LatLongsToDistanceResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public int LatLongsToDistance(float lat1, float lon1, float lat2, float lon2) {
		object[] results = this.Invoke("LatLongsToDistance", new object[] {
			lat1,
			lon1,
			lat2,
			lon2});
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginLatLongsToDistance(float lat1, float lon1, float lat2, float lon2, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("LatLongsToDistance", new object[] {
			lat1,
			lon1,
			lat2,
			lon2}, callback, asyncState);
	}
    
	/// <remarks/>
	public int EndLatLongsToDistance(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public void LatLongsToDistanceAsync(float lat1, float lon1, float lat2, float lon2) {
		this.LatLongsToDistanceAsync(lat1, lon1, lat2, lon2, null);
	}
    
	/// <remarks/>
	public void LatLongsToDistanceAsync(float lat1, float lon1, float lat2, float lon2, object userState) {
		if ((this.LatLongsToDistanceOperationCompleted == null)) {
			this.LatLongsToDistanceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLatLongsToDistanceOperationCompleted);
		}
		this.InvokeAsync("LatLongsToDistance", new object[] {
			lat1,
			lon1,
			lat2,
			lon2}, this.LatLongsToDistanceOperationCompleted, userState);
	}
    
	private void OnLatLongsToDistanceOperationCompleted(object arg) {
		if ((this.LatLongsToDistanceCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.LatLongsToDistanceCompleted(this, new LatLongsToDistanceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:LatLongsToHeading", RequestElementName="LatLongsToHeadingRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="LatLongsToHeadingResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public int LatLongsToHeading(float lat1, float lon1, float lat2, float lon2) {
		object[] results = this.Invoke("LatLongsToHeading", new object[] {
			lat1,
			lon1,
			lat2,
			lon2});
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginLatLongsToHeading(float lat1, float lon1, float lat2, float lon2, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("LatLongsToHeading", new object[] {
			lat1,
			lon1,
			lat2,
			lon2}, callback, asyncState);
	}
    
	/// <remarks/>
	public int EndLatLongsToHeading(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public void LatLongsToHeadingAsync(float lat1, float lon1, float lat2, float lon2) {
		this.LatLongsToHeadingAsync(lat1, lon1, lat2, lon2, null);
	}
    
	/// <remarks/>
	public void LatLongsToHeadingAsync(float lat1, float lon1, float lat2, float lon2, object userState) {
		if ((this.LatLongsToHeadingOperationCompleted == null)) {
			this.LatLongsToHeadingOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLatLongsToHeadingOperationCompleted);
		}
		this.InvokeAsync("LatLongsToHeading", new object[] {
			lat1,
			lon1,
			lat2,
			lon2}, this.LatLongsToHeadingOperationCompleted, userState);
	}
    
	private void OnLatLongsToHeadingOperationCompleted(object arg) {
		if ((this.LatLongsToHeadingCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.LatLongsToHeadingCompleted(this, new LatLongsToHeadingCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:MapFlight", RequestElementName="MapFlightRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="MapFlightResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public string MapFlight(string ident, int mapHeight, int mapWidth) {
		object[] results = this.Invoke("MapFlight", new object[] {
			ident,
			mapHeight,
			mapWidth});
		return ((string) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginMapFlight(string ident, int mapHeight, int mapWidth, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("MapFlight", new object[] {
			ident,
			mapHeight,
			mapWidth}, callback, asyncState);
	}
    
	/// <remarks/>
	public string EndMapFlight(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((string) (results[0]));
	}
    
	/// <remarks/>
	public void MapFlightAsync(string ident, int mapHeight, int mapWidth) {
		this.MapFlightAsync(ident, mapHeight, mapWidth, null);
	}
    
	/// <remarks/>
	public void MapFlightAsync(string ident, int mapHeight, int mapWidth, object userState) {
		if ((this.MapFlightOperationCompleted == null)) {
			this.MapFlightOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMapFlightOperationCompleted);
		}
		this.InvokeAsync("MapFlight", new object[] {
			ident,
			mapHeight,
			mapWidth}, this.MapFlightOperationCompleted, userState);
	}
    
	private void OnMapFlightOperationCompleted(object arg) {
		if ((this.MapFlightCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.MapFlightCompleted(this, new MapFlightCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:MapFlightEx", RequestElementName="MapFlightExRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="MapFlightExResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public string MapFlightEx(string faFlightID, int mapHeight, int mapWidth, [System.Xml.Serialization.XmlElementAttribute("layer_on")] string[] layer_on, [System.Xml.Serialization.XmlElementAttribute("layer_off")] string[] layer_off, bool show_data_blocks, bool show_airports, bool airports_expand_view, [System.Xml.Serialization.XmlElementAttribute("latlon_box")] float[] latlon_box) {
		object[] results = this.Invoke("MapFlightEx", new object[] {
			faFlightID,
			mapHeight,
			mapWidth,
			layer_on,
			layer_off,
			show_data_blocks,
			show_airports,
			airports_expand_view,
			latlon_box});
		return ((string) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginMapFlightEx(string faFlightID, int mapHeight, int mapWidth, string[] layer_on, string[] layer_off, bool show_data_blocks, bool show_airports, bool airports_expand_view, float[] latlon_box, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("MapFlightEx", new object[] {
			faFlightID,
			mapHeight,
			mapWidth,
			layer_on,
			layer_off,
			show_data_blocks,
			show_airports,
			airports_expand_view,
			latlon_box}, callback, asyncState);
	}
    
	/// <remarks/>
	public string EndMapFlightEx(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((string) (results[0]));
	}
    
	/// <remarks/>
	public void MapFlightExAsync(string faFlightID, int mapHeight, int mapWidth, string[] layer_on, string[] layer_off, bool show_data_blocks, bool show_airports, bool airports_expand_view, float[] latlon_box) {
		this.MapFlightExAsync(faFlightID, mapHeight, mapWidth, layer_on, layer_off, show_data_blocks, show_airports, airports_expand_view, latlon_box, null);
	}
    
	/// <remarks/>
	public void MapFlightExAsync(string faFlightID, int mapHeight, int mapWidth, string[] layer_on, string[] layer_off, bool show_data_blocks, bool show_airports, bool airports_expand_view, float[] latlon_box, object userState) {
		if ((this.MapFlightExOperationCompleted == null)) {
			this.MapFlightExOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMapFlightExOperationCompleted);
		}
		this.InvokeAsync("MapFlightEx", new object[] {
			faFlightID,
			mapHeight,
			mapWidth,
			layer_on,
			layer_off,
			show_data_blocks,
			show_airports,
			airports_expand_view,
			latlon_box}, this.MapFlightExOperationCompleted, userState);
	}
    
	private void OnMapFlightExOperationCompleted(object arg) {
		if ((this.MapFlightExCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.MapFlightExCompleted(this, new MapFlightExCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:Metar", RequestElementName="MetarRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="MetarResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public string Metar(string airport) {
		object[] results = this.Invoke("Metar", new object[] {
			airport});
		return ((string) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginMetar(string airport, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("Metar", new object[] {
			airport}, callback, asyncState);
	}
    
	/// <remarks/>
	public string EndMetar(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((string) (results[0]));
	}
    
	/// <remarks/>
	public void MetarAsync(string airport) {
		this.MetarAsync(airport, null);
	}
    
	/// <remarks/>
	public void MetarAsync(string airport, object userState) {
		if ((this.MetarOperationCompleted == null)) {
			this.MetarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMetarOperationCompleted);
		}
		this.InvokeAsync("Metar", new object[] {
			airport}, this.MetarOperationCompleted, userState);
	}
    
	private void OnMetarOperationCompleted(object arg) {
		if ((this.MetarCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.MetarCompleted(this, new MetarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:MetarEx", RequestElementName="MetarExRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="MetarExResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public ArrayOfMetarStruct MetarEx(string airport, int startTime, int howMany, int offset) {
		object[] results = this.Invoke("MetarEx", new object[] {
			airport,
			startTime,
			howMany,
			offset});
		return ((ArrayOfMetarStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginMetarEx(string airport, int startTime, int howMany, int offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("MetarEx", new object[] {
			airport,
			startTime,
			howMany,
			offset}, callback, asyncState);
	}
    
	/// <remarks/>
	public ArrayOfMetarStruct EndMetarEx(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((ArrayOfMetarStruct) (results[0]));
	}
    
	/// <remarks/>
	public void MetarExAsync(string airport, int startTime, int howMany, int offset) {
		this.MetarExAsync(airport, startTime, howMany, offset, null);
	}
    
	/// <remarks/>
	public void MetarExAsync(string airport, int startTime, int howMany, int offset, object userState) {
		if ((this.MetarExOperationCompleted == null)) {
			this.MetarExOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMetarExOperationCompleted);
		}
		this.InvokeAsync("MetarEx", new object[] {
			airport,
			startTime,
			howMany,
			offset}, this.MetarExOperationCompleted, userState);
	}
    
	private void OnMetarExOperationCompleted(object arg) {
		if ((this.MetarExCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.MetarExCompleted(this, new MetarExCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:NTaf", RequestElementName="NTafRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="NTafResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public TafStruct NTaf(string airport) {
		object[] results = this.Invoke("NTaf", new object[] {
			airport});
		return ((TafStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginNTaf(string airport, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("NTaf", new object[] {
			airport}, callback, asyncState);
	}
    
	/// <remarks/>
	public TafStruct EndNTaf(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((TafStruct) (results[0]));
	}
    
	/// <remarks/>
	public void NTafAsync(string airport) {
		this.NTafAsync(airport, null);
	}
    
	/// <remarks/>
	public void NTafAsync(string airport, object userState) {
		if ((this.NTafOperationCompleted == null)) {
			this.NTafOperationCompleted = new System.Threading.SendOrPostCallback(this.OnNTafOperationCompleted);
		}
		this.InvokeAsync("NTaf", new object[] {
			airport}, this.NTafOperationCompleted, userState);
	}
    
	private void OnNTafOperationCompleted(object arg) {
		if ((this.NTafCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.NTafCompleted(this, new NTafCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:RegisterAlertEndpoint", RequestElementName="RegisterAlertEndpointRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="RegisterAlertEndpointResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public int RegisterAlertEndpoint(string address, string format_type) {
		object[] results = this.Invoke("RegisterAlertEndpoint", new object[] {
			address,
			format_type});
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginRegisterAlertEndpoint(string address, string format_type, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("RegisterAlertEndpoint", new object[] {
			address,
			format_type}, callback, asyncState);
	}
    
	/// <remarks/>
	public int EndRegisterAlertEndpoint(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public void RegisterAlertEndpointAsync(string address, string format_type) {
		this.RegisterAlertEndpointAsync(address, format_type, null);
	}
    
	/// <remarks/>
	public void RegisterAlertEndpointAsync(string address, string format_type, object userState) {
		if ((this.RegisterAlertEndpointOperationCompleted == null)) {
			this.RegisterAlertEndpointOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegisterAlertEndpointOperationCompleted);
		}
		this.InvokeAsync("RegisterAlertEndpoint", new object[] {
			address,
			format_type}, this.RegisterAlertEndpointOperationCompleted, userState);
	}
    
	private void OnRegisterAlertEndpointOperationCompleted(object arg) {
		if ((this.RegisterAlertEndpointCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.RegisterAlertEndpointCompleted(this, new RegisterAlertEndpointCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:RoutesBetweenAirports", RequestElementName="RoutesBetweenAirportsRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="RoutesBetweenAirportsResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	[return: System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable=false)]
	public RoutesBetweenAirportsStruct[] RoutesBetweenAirports(string origin, string destination) {
		object[] results = this.Invoke("RoutesBetweenAirports", new object[] {
			origin,
			destination});
		return ((RoutesBetweenAirportsStruct[]) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginRoutesBetweenAirports(string origin, string destination, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("RoutesBetweenAirports", new object[] {
			origin,
			destination}, callback, asyncState);
	}
    
	/// <remarks/>
	public RoutesBetweenAirportsStruct[] EndRoutesBetweenAirports(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((RoutesBetweenAirportsStruct[]) (results[0]));
	}
    
	/// <remarks/>
	public void RoutesBetweenAirportsAsync(string origin, string destination) {
		this.RoutesBetweenAirportsAsync(origin, destination, null);
	}
    
	/// <remarks/>
	public void RoutesBetweenAirportsAsync(string origin, string destination, object userState) {
		if ((this.RoutesBetweenAirportsOperationCompleted == null)) {
			this.RoutesBetweenAirportsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRoutesBetweenAirportsOperationCompleted);
		}
		this.InvokeAsync("RoutesBetweenAirports", new object[] {
			origin,
			destination}, this.RoutesBetweenAirportsOperationCompleted, userState);
	}
    
	private void OnRoutesBetweenAirportsOperationCompleted(object arg) {
		if ((this.RoutesBetweenAirportsCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.RoutesBetweenAirportsCompleted(this, new RoutesBetweenAirportsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:RoutesBetweenAirportsEx", RequestElementName="RoutesBetweenAirportsExRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="RoutesBetweenAirportsExResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public ArrayOfRoutesBetweenAirportsExStruct RoutesBetweenAirportsEx(string origin, string destination, int howMany, int offset, string maxDepartureAge, string maxFileAge) {
		object[] results = this.Invoke("RoutesBetweenAirportsEx", new object[] {
			origin,
			destination,
			howMany,
			offset,
			maxDepartureAge,
			maxFileAge});
		return ((ArrayOfRoutesBetweenAirportsExStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginRoutesBetweenAirportsEx(string origin, string destination, int howMany, int offset, string maxDepartureAge, string maxFileAge, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("RoutesBetweenAirportsEx", new object[] {
			origin,
			destination,
			howMany,
			offset,
			maxDepartureAge,
			maxFileAge}, callback, asyncState);
	}
    
	/// <remarks/>
	public ArrayOfRoutesBetweenAirportsExStruct EndRoutesBetweenAirportsEx(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((ArrayOfRoutesBetweenAirportsExStruct) (results[0]));
	}
    
	/// <remarks/>
	public void RoutesBetweenAirportsExAsync(string origin, string destination, int howMany, int offset, string maxDepartureAge, string maxFileAge) {
		this.RoutesBetweenAirportsExAsync(origin, destination, howMany, offset, maxDepartureAge, maxFileAge, null);
	}
    
	/// <remarks/>
	public void RoutesBetweenAirportsExAsync(string origin, string destination, int howMany, int offset, string maxDepartureAge, string maxFileAge, object userState) {
		if ((this.RoutesBetweenAirportsExOperationCompleted == null)) {
			this.RoutesBetweenAirportsExOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRoutesBetweenAirportsExOperationCompleted);
		}
		this.InvokeAsync("RoutesBetweenAirportsEx", new object[] {
			origin,
			destination,
			howMany,
			offset,
			maxDepartureAge,
			maxFileAge}, this.RoutesBetweenAirportsExOperationCompleted, userState);
	}
    
	private void OnRoutesBetweenAirportsExOperationCompleted(object arg) {
		if ((this.RoutesBetweenAirportsExCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.RoutesBetweenAirportsExCompleted(this, new RoutesBetweenAirportsExCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:Scheduled", RequestElementName="ScheduledRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="ScheduledResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public ScheduledStruct Scheduled(string airport, int howMany, string filter, int offset) {
		object[] results = this.Invoke("Scheduled", new object[] {
			airport,
			howMany,
			filter,
			offset});
		return ((ScheduledStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginScheduled(string airport, int howMany, string filter, int offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("Scheduled", new object[] {
			airport,
			howMany,
			filter,
			offset}, callback, asyncState);
	}
    
	/// <remarks/>
	public ScheduledStruct EndScheduled(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((ScheduledStruct) (results[0]));
	}
    
	/// <remarks/>
	public void ScheduledAsync(string airport, int howMany, string filter, int offset) {
		this.ScheduledAsync(airport, howMany, filter, offset, null);
	}
    
	/// <remarks/>
	public void ScheduledAsync(string airport, int howMany, string filter, int offset, object userState) {
		if ((this.ScheduledOperationCompleted == null)) {
			this.ScheduledOperationCompleted = new System.Threading.SendOrPostCallback(this.OnScheduledOperationCompleted);
		}
		this.InvokeAsync("Scheduled", new object[] {
			airport,
			howMany,
			filter,
			offset}, this.ScheduledOperationCompleted, userState);
	}
    
	private void OnScheduledOperationCompleted(object arg) {
		if ((this.ScheduledCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.ScheduledCompleted(this, new ScheduledCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:Search", RequestElementName="SearchRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="SearchResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public InFlightStruct Search(string query, int howMany, int offset) {
		object[] results = this.Invoke("Search", new object[] {
			query,
			howMany,
			offset});
		return ((InFlightStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginSearch(string query, int howMany, int offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("Search", new object[] {
			query,
			howMany,
			offset}, callback, asyncState);
	}
    
	/// <remarks/>
	public InFlightStruct EndSearch(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((InFlightStruct) (results[0]));
	}
    
	/// <remarks/>
	public void SearchAsync(string query, int howMany, int offset) {
		this.SearchAsync(query, howMany, offset, null);
	}
    
	/// <remarks/>
	public void SearchAsync(string query, int howMany, int offset, object userState) {
		if ((this.SearchOperationCompleted == null)) {
			this.SearchOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchOperationCompleted);
		}
		this.InvokeAsync("Search", new object[] {
			query,
			howMany,
			offset}, this.SearchOperationCompleted, userState);
	}
    
	private void OnSearchOperationCompleted(object arg) {
		if ((this.SearchCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.SearchCompleted(this, new SearchCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:SearchBirdseyeInFlight", RequestElementName="SearchBirdseyeInFlightRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="SearchBirdseyeInFlightResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public InFlightStruct SearchBirdseyeInFlight(string query, int howMany, int offset) {
		object[] results = this.Invoke("SearchBirdseyeInFlight", new object[] {
			query,
			howMany,
			offset});
		return ((InFlightStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginSearchBirdseyeInFlight(string query, int howMany, int offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("SearchBirdseyeInFlight", new object[] {
			query,
			howMany,
			offset}, callback, asyncState);
	}
    
	/// <remarks/>
	public InFlightStruct EndSearchBirdseyeInFlight(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((InFlightStruct) (results[0]));
	}
    
	/// <remarks/>
	public void SearchBirdseyeInFlightAsync(string query, int howMany, int offset) {
		this.SearchBirdseyeInFlightAsync(query, howMany, offset, null);
	}
    
	/// <remarks/>
	public void SearchBirdseyeInFlightAsync(string query, int howMany, int offset, object userState) {
		if ((this.SearchBirdseyeInFlightOperationCompleted == null)) {
			this.SearchBirdseyeInFlightOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchBirdseyeInFlightOperationCompleted);
		}
		this.InvokeAsync("SearchBirdseyeInFlight", new object[] {
			query,
			howMany,
			offset}, this.SearchBirdseyeInFlightOperationCompleted, userState);
	}
    
	private void OnSearchBirdseyeInFlightOperationCompleted(object arg) {
		if ((this.SearchBirdseyeInFlightCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.SearchBirdseyeInFlightCompleted(this, new SearchBirdseyeInFlightCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:SearchBirdseyePositions", RequestElementName="SearchBirdseyePositionsRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="SearchBirdseyePositionsResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public ArrayOfTrackExStruct SearchBirdseyePositions(string query, bool uniqueFlights, int howMany, int offset) {
		object[] results = this.Invoke("SearchBirdseyePositions", new object[] {
			query,
			uniqueFlights,
			howMany,
			offset});
		return ((ArrayOfTrackExStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginSearchBirdseyePositions(string query, bool uniqueFlights, int howMany, int offset, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("SearchBirdseyePositions", new object[] {
			query,
			uniqueFlights,
			howMany,
			offset}, callback, asyncState);
	}
    
	/// <remarks/>
	public ArrayOfTrackExStruct EndSearchBirdseyePositions(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((ArrayOfTrackExStruct) (results[0]));
	}
    
	/// <remarks/>
	public void SearchBirdseyePositionsAsync(string query, bool uniqueFlights, int howMany, int offset) {
		this.SearchBirdseyePositionsAsync(query, uniqueFlights, howMany, offset, null);
	}
    
	/// <remarks/>
	public void SearchBirdseyePositionsAsync(string query, bool uniqueFlights, int howMany, int offset, object userState) {
		if ((this.SearchBirdseyePositionsOperationCompleted == null)) {
			this.SearchBirdseyePositionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchBirdseyePositionsOperationCompleted);
		}
		this.InvokeAsync("SearchBirdseyePositions", new object[] {
			query,
			uniqueFlights,
			howMany,
			offset}, this.SearchBirdseyePositionsOperationCompleted, userState);
	}
    
	private void OnSearchBirdseyePositionsOperationCompleted(object arg) {
		if ((this.SearchBirdseyePositionsCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.SearchBirdseyePositionsCompleted(this, new SearchBirdseyePositionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:SearchCount", RequestElementName="SearchCountRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="SearchCountResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public int SearchCount(string query) {
		object[] results = this.Invoke("SearchCount", new object[] {
			query});
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginSearchCount(string query, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("SearchCount", new object[] {
			query}, callback, asyncState);
	}
    
	/// <remarks/>
	public int EndSearchCount(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public void SearchCountAsync(string query) {
		this.SearchCountAsync(query, null);
	}
    
	/// <remarks/>
	public void SearchCountAsync(string query, object userState) {
		if ((this.SearchCountOperationCompleted == null)) {
			this.SearchCountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchCountOperationCompleted);
		}
		this.InvokeAsync("SearchCount", new object[] {
			query}, this.SearchCountOperationCompleted, userState);
	}
    
	private void OnSearchCountOperationCompleted(object arg) {
		if ((this.SearchCountCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.SearchCountCompleted(this, new SearchCountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:SetAlert", RequestElementName="SetAlertRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="SetAlertResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public int SetAlert(int alert_id, string ident, string origin, string destination, string aircrafttype, int date_start, int date_end, string channels, bool enabled, int max_weekly) {
		object[] results = this.Invoke("SetAlert", new object[] {
			alert_id,
			ident,
			origin,
			destination,
			aircrafttype,
			date_start,
			date_end,
			channels,
			enabled,
			max_weekly});
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginSetAlert(int alert_id, string ident, string origin, string destination, string aircrafttype, int date_start, int date_end, string channels, bool enabled, int max_weekly, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("SetAlert", new object[] {
			alert_id,
			ident,
			origin,
			destination,
			aircrafttype,
			date_start,
			date_end,
			channels,
			enabled,
			max_weekly}, callback, asyncState);
	}
    
	/// <remarks/>
	public int EndSetAlert(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public void SetAlertAsync(int alert_id, string ident, string origin, string destination, string aircrafttype, int date_start, int date_end, string channels, bool enabled, int max_weekly) {
		this.SetAlertAsync(alert_id, ident, origin, destination, aircrafttype, date_start, date_end, channels, enabled, max_weekly, null);
	}
    
	/// <remarks/>
	public void SetAlertAsync(int alert_id, string ident, string origin, string destination, string aircrafttype, int date_start, int date_end, string channels, bool enabled, int max_weekly, object userState) {
		if ((this.SetAlertOperationCompleted == null)) {
			this.SetAlertOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetAlertOperationCompleted);
		}
		this.InvokeAsync("SetAlert", new object[] {
			alert_id,
			ident,
			origin,
			destination,
			aircrafttype,
			date_start,
			date_end,
			channels,
			enabled,
			max_weekly}, this.SetAlertOperationCompleted, userState);
	}
    
	private void OnSetAlertOperationCompleted(object arg) {
		if ((this.SetAlertCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.SetAlertCompleted(this, new SetAlertCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:SetMaximumResultSize", RequestElementName="SetMaximumResultSizeRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="SetMaximumResultSizeResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public int SetMaximumResultSize(int max_size) {
		object[] results = this.Invoke("SetMaximumResultSize", new object[] {
			max_size});
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginSetMaximumResultSize(int max_size, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("SetMaximumResultSize", new object[] {
			max_size}, callback, asyncState);
	}
    
	/// <remarks/>
	public int EndSetMaximumResultSize(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((int) (results[0]));
	}
    
	/// <remarks/>
	public void SetMaximumResultSizeAsync(int max_size) {
		this.SetMaximumResultSizeAsync(max_size, null);
	}
    
	/// <remarks/>
	public void SetMaximumResultSizeAsync(int max_size, object userState) {
		if ((this.SetMaximumResultSizeOperationCompleted == null)) {
			this.SetMaximumResultSizeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetMaximumResultSizeOperationCompleted);
		}
		this.InvokeAsync("SetMaximumResultSize", new object[] {
			max_size}, this.SetMaximumResultSizeOperationCompleted, userState);
	}
    
	private void OnSetMaximumResultSizeOperationCompleted(object arg) {
		if ((this.SetMaximumResultSizeCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.SetMaximumResultSizeCompleted(this, new SetMaximumResultSizeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:Taf", RequestElementName="TafRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="TafResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public string Taf(string airport) {
		object[] results = this.Invoke("Taf", new object[] {
			airport});
		return ((string) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginTaf(string airport, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("Taf", new object[] {
			airport}, callback, asyncState);
	}
    
	/// <remarks/>
	public string EndTaf(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((string) (results[0]));
	}
    
	/// <remarks/>
	public void TafAsync(string airport) {
		this.TafAsync(airport, null);
	}
    
	/// <remarks/>
	public void TafAsync(string airport, object userState) {
		if ((this.TafOperationCompleted == null)) {
			this.TafOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTafOperationCompleted);
		}
		this.InvokeAsync("Taf", new object[] {
			airport}, this.TafOperationCompleted, userState);
	}
    
	private void OnTafOperationCompleted(object arg) {
		if ((this.TafCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.TafCompleted(this, new TafCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:TailOwner", RequestElementName="TailOwnerRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="TailOwnerResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public TailOwnerStruct TailOwner(string ident) {
		object[] results = this.Invoke("TailOwner", new object[] {
			ident});
		return ((TailOwnerStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginTailOwner(string ident, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("TailOwner", new object[] {
			ident}, callback, asyncState);
	}
    
	/// <remarks/>
	public TailOwnerStruct EndTailOwner(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((TailOwnerStruct) (results[0]));
	}
    
	/// <remarks/>
	public void TailOwnerAsync(string ident) {
		this.TailOwnerAsync(ident, null);
	}
    
	/// <remarks/>
	public void TailOwnerAsync(string ident, object userState) {
		if ((this.TailOwnerOperationCompleted == null)) {
			this.TailOwnerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTailOwnerOperationCompleted);
		}
		this.InvokeAsync("TailOwner", new object[] {
			ident}, this.TailOwnerOperationCompleted, userState);
	}
    
	private void OnTailOwnerOperationCompleted(object arg) {
		if ((this.TailOwnerCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.TailOwnerCompleted(this, new TailOwnerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	[System.Web.Services.Protocols.SoapDocumentMethodAttribute("FlightXML2:ZipcodeInfo", RequestElementName="ZipcodeInfoRequest", RequestNamespace="http://flightxml.flightaware.com/soap/FlightXML2", ResponseElementName="ZipcodeInfoResults", ResponseNamespace="http://flightxml.flightaware.com/soap/FlightXML2", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
	public ZipcodeInfoStruct ZipcodeInfo(string zipcode) {
		object[] results = this.Invoke("ZipcodeInfo", new object[] {
			zipcode});
		return ((ZipcodeInfoStruct) (results[0]));
	}
    
	/// <remarks/>
	public System.IAsyncResult BeginZipcodeInfo(string zipcode, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("ZipcodeInfo", new object[] {
			zipcode}, callback, asyncState);
	}
    
	/// <remarks/>
	public ZipcodeInfoStruct EndZipcodeInfo(System.IAsyncResult asyncResult) {
		object[] results = this.EndInvoke(asyncResult);
		return ((ZipcodeInfoStruct) (results[0]));
	}
    
	/// <remarks/>
	public void ZipcodeInfoAsync(string zipcode) {
		this.ZipcodeInfoAsync(zipcode, null);
	}
    
	/// <remarks/>
	public void ZipcodeInfoAsync(string zipcode, object userState) {
		if ((this.ZipcodeInfoOperationCompleted == null)) {
			this.ZipcodeInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnZipcodeInfoOperationCompleted);
		}
		this.InvokeAsync("ZipcodeInfo", new object[] {
			zipcode}, this.ZipcodeInfoOperationCompleted, userState);
	}
    
	private void OnZipcodeInfoOperationCompleted(object arg) {
		if ((this.ZipcodeInfoCompleted != null)) {
			System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
			this.ZipcodeInfoCompleted(this, new ZipcodeInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
		}
	}
    
	/// <remarks/>
	public new void CancelAsync(object userState) {
		base.CancelAsync(userState);
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class AircraftTypeStruct {
    
	private string manufacturerField;
    
	private string typeField;
    
	private string descriptionField;
    
	/// <remarks/>
	public string manufacturer {
		get {
			return this.manufacturerField;
		}
		set {
			this.manufacturerField = value;
		}
	}
    
	/// <remarks/>
	public string type {
		get {
			return this.typeField;
		}
		set {
			this.typeField = value;
		}
	}
    
	/// <remarks/>
	public string description {
		get {
			return this.descriptionField;
		}
		set {
			this.descriptionField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class ZipcodeInfoStruct {
    
	private float latitudeField;
    
	private float longitudeField;
    
	private string cityField;
    
	private string stateField;
    
	private string countyField;
    
	/// <remarks/>
	public float latitude {
		get {
			return this.latitudeField;
		}
		set {
			this.latitudeField = value;
		}
	}
    
	/// <remarks/>
	public float longitude {
		get {
			return this.longitudeField;
		}
		set {
			this.longitudeField = value;
		}
	}
    
	/// <remarks/>
	public string city {
		get {
			return this.cityField;
		}
		set {
			this.cityField = value;
		}
	}
    
	/// <remarks/>
	public string state {
		get {
			return this.stateField;
		}
		set {
			this.stateField = value;
		}
	}
    
	/// <remarks/>
	public string county {
		get {
			return this.countyField;
		}
		set {
			this.countyField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class TailOwnerStruct {
    
	private string ownerField;
    
	private string locationField;
    
	private string location2Field;
    
	private string websiteField;
    
	/// <remarks/>
	public string owner {
		get {
			return this.ownerField;
		}
		set {
			this.ownerField = value;
		}
	}
    
	/// <remarks/>
	public string location {
		get {
			return this.locationField;
		}
		set {
			this.locationField = value;
		}
	}
    
	/// <remarks/>
	public string location2 {
		get {
			return this.location2Field;
		}
		set {
			this.location2Field = value;
		}
	}
    
	/// <remarks/>
	public string website {
		get {
			return this.websiteField;
		}
		set {
			this.websiteField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class TrackExStruct {
    
	private string faFlightIDField;
    
	private int timestampField;
    
	private float latitudeField;
    
	private float longitudeField;
    
	private int groundspeedField;
    
	private int altitudeField;
    
	private string altitudeStatusField;
    
	private string updateTypeField;
    
	private string altitudeChangeField;
    
	/// <remarks/>
	public string faFlightID {
		get {
			return this.faFlightIDField;
		}
		set {
			this.faFlightIDField = value;
		}
	}
    
	/// <remarks/>
	public int timestamp {
		get {
			return this.timestampField;
		}
		set {
			this.timestampField = value;
		}
	}
    
	/// <remarks/>
	public float latitude {
		get {
			return this.latitudeField;
		}
		set {
			this.latitudeField = value;
		}
	}
    
	/// <remarks/>
	public float longitude {
		get {
			return this.longitudeField;
		}
		set {
			this.longitudeField = value;
		}
	}
    
	/// <remarks/>
	public int groundspeed {
		get {
			return this.groundspeedField;
		}
		set {
			this.groundspeedField = value;
		}
	}
    
	/// <remarks/>
	public int altitude {
		get {
			return this.altitudeField;
		}
		set {
			this.altitudeField = value;
		}
	}
    
	/// <remarks/>
	public string altitudeStatus {
		get {
			return this.altitudeStatusField;
		}
		set {
			this.altitudeStatusField = value;
		}
	}
    
	/// <remarks/>
	public string updateType {
		get {
			return this.updateTypeField;
		}
		set {
			this.updateTypeField = value;
		}
	}
    
	/// <remarks/>
	public string altitudeChange {
		get {
			return this.altitudeChangeField;
		}
		set {
			this.altitudeChangeField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class ArrayOfTrackExStruct {
    
	private int next_offsetField;
    
	private TrackExStruct[] dataField;
    
	/// <remarks/>
	public int next_offset {
		get {
			return this.next_offsetField;
		}
		set {
			this.next_offsetField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("data")]
	public TrackExStruct[] data {
		get {
			return this.dataField;
		}
		set {
			this.dataField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class InFlightStruct {
    
	private int next_offsetField;
    
	private InFlightAircraftStruct[] aircraftField;
    
	/// <remarks/>
	public int next_offset {
		get {
			return this.next_offsetField;
		}
		set {
			this.next_offsetField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("aircraft")]
	public InFlightAircraftStruct[] aircraft {
		get {
			return this.aircraftField;
		}
		set {
			this.aircraftField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class InFlightAircraftStruct {
    
	private string faFlightIDField;
    
	private string identField;
    
	private string prefixField;
    
	private string typeField;
    
	private string suffixField;
    
	private string originField;
    
	private string destinationField;
    
	private string timeoutField;
    
	private int timestampField;
    
	private int departureTimeField;
    
	private int firstPositionTimeField;
    
	private int arrivalTimeField;
    
	private float longitudeField;
    
	private float latitudeField;
    
	private float lowLongitudeField;
    
	private float lowLatitudeField;
    
	private float highLongitudeField;
    
	private float highLatitudeField;
    
	private int groundspeedField;
    
	private int altitudeField;
    
	private int headingField;
    
	private string altitudeStatusField;
    
	private string updateTypeField;
    
	private string altitudeChangeField;
    
	private string waypointsField;
    
	/// <remarks/>
	public string faFlightID {
		get {
			return this.faFlightIDField;
		}
		set {
			this.faFlightIDField = value;
		}
	}
    
	/// <remarks/>
	public string ident {
		get {
			return this.identField;
		}
		set {
			this.identField = value;
		}
	}
    
	/// <remarks/>
	public string prefix {
		get {
			return this.prefixField;
		}
		set {
			this.prefixField = value;
		}
	}
    
	/// <remarks/>
	public string type {
		get {
			return this.typeField;
		}
		set {
			this.typeField = value;
		}
	}
    
	/// <remarks/>
	public string suffix {
		get {
			return this.suffixField;
		}
		set {
			this.suffixField = value;
		}
	}
    
	/// <remarks/>
	public string origin {
		get {
			return this.originField;
		}
		set {
			this.originField = value;
		}
	}
    
	/// <remarks/>
	public string destination {
		get {
			return this.destinationField;
		}
		set {
			this.destinationField = value;
		}
	}
    
	/// <remarks/>
	public string timeout {
		get {
			return this.timeoutField;
		}
		set {
			this.timeoutField = value;
		}
	}
    
	/// <remarks/>
	public int timestamp {
		get {
			return this.timestampField;
		}
		set {
			this.timestampField = value;
		}
	}
    
	/// <remarks/>
	public int departureTime {
		get {
			return this.departureTimeField;
		}
		set {
			this.departureTimeField = value;
		}
	}
    
	/// <remarks/>
	public int firstPositionTime {
		get {
			return this.firstPositionTimeField;
		}
		set {
			this.firstPositionTimeField = value;
		}
	}
    
	/// <remarks/>
	public int arrivalTime {
		get {
			return this.arrivalTimeField;
		}
		set {
			this.arrivalTimeField = value;
		}
	}
    
	/// <remarks/>
	public float longitude {
		get {
			return this.longitudeField;
		}
		set {
			this.longitudeField = value;
		}
	}
    
	/// <remarks/>
	public float latitude {
		get {
			return this.latitudeField;
		}
		set {
			this.latitudeField = value;
		}
	}
    
	/// <remarks/>
	public float lowLongitude {
		get {
			return this.lowLongitudeField;
		}
		set {
			this.lowLongitudeField = value;
		}
	}
    
	/// <remarks/>
	public float lowLatitude {
		get {
			return this.lowLatitudeField;
		}
		set {
			this.lowLatitudeField = value;
		}
	}
    
	/// <remarks/>
	public float highLongitude {
		get {
			return this.highLongitudeField;
		}
		set {
			this.highLongitudeField = value;
		}
	}
    
	/// <remarks/>
	public float highLatitude {
		get {
			return this.highLatitudeField;
		}
		set {
			this.highLatitudeField = value;
		}
	}
    
	/// <remarks/>
	public int groundspeed {
		get {
			return this.groundspeedField;
		}
		set {
			this.groundspeedField = value;
		}
	}
    
	/// <remarks/>
	public int altitude {
		get {
			return this.altitudeField;
		}
		set {
			this.altitudeField = value;
		}
	}
    
	/// <remarks/>
	public int heading {
		get {
			return this.headingField;
		}
		set {
			this.headingField = value;
		}
	}
    
	/// <remarks/>
	public string altitudeStatus {
		get {
			return this.altitudeStatusField;
		}
		set {
			this.altitudeStatusField = value;
		}
	}
    
	/// <remarks/>
	public string updateType {
		get {
			return this.updateTypeField;
		}
		set {
			this.updateTypeField = value;
		}
	}
    
	/// <remarks/>
	public string altitudeChange {
		get {
			return this.altitudeChangeField;
		}
		set {
			this.altitudeChangeField = value;
		}
	}
    
	/// <remarks/>
	public string waypoints {
		get {
			return this.waypointsField;
		}
		set {
			this.waypointsField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class RoutesBetweenAirportsExStruct {
    
	private int countField;
    
	private string routeField;
    
	private int filedAltitude_minField;
    
	private int filedAltitude_maxField;
    
	private int last_departuretimeField;
    
	/// <remarks/>
	public int count {
		get {
			return this.countField;
		}
		set {
			this.countField = value;
		}
	}
    
	/// <remarks/>
	public string route {
		get {
			return this.routeField;
		}
		set {
			this.routeField = value;
		}
	}
    
	/// <remarks/>
	public int filedAltitude_min {
		get {
			return this.filedAltitude_minField;
		}
		set {
			this.filedAltitude_minField = value;
		}
	}
    
	/// <remarks/>
	public int filedAltitude_max {
		get {
			return this.filedAltitude_maxField;
		}
		set {
			this.filedAltitude_maxField = value;
		}
	}
    
	/// <remarks/>
	public int last_departuretime {
		get {
			return this.last_departuretimeField;
		}
		set {
			this.last_departuretimeField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class ArrayOfRoutesBetweenAirportsExStruct {
    
	private int next_offsetField;
    
	private RoutesBetweenAirportsExStruct[] dataField;
    
	/// <remarks/>
	public int next_offset {
		get {
			return this.next_offsetField;
		}
		set {
			this.next_offsetField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("data")]
	public RoutesBetweenAirportsExStruct[] data {
		get {
			return this.dataField;
		}
		set {
			this.dataField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class RoutesBetweenAirportsStruct {
    
	private int countField;
    
	private string routeField;
    
	private int filedAltitudeField;
    
	/// <remarks/>
	public int count {
		get {
			return this.countField;
		}
		set {
			this.countField = value;
		}
	}
    
	/// <remarks/>
	public string route {
		get {
			return this.routeField;
		}
		set {
			this.routeField = value;
		}
	}
    
	/// <remarks/>
	public int filedAltitude {
		get {
			return this.filedAltitudeField;
		}
		set {
			this.filedAltitudeField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class TafStruct {
    
	private string airportField;
    
	private string timeStringField;
    
	private string[] forecastField;
    
	/// <remarks/>
	public string airport {
		get {
			return this.airportField;
		}
		set {
			this.airportField = value;
		}
	}
    
	/// <remarks/>
	public string timeString {
		get {
			return this.timeStringField;
		}
		set {
			this.timeStringField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("forecast")]
	public string[] forecast {
		get {
			return this.forecastField;
		}
		set {
			this.forecastField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class MetarStruct {
    
	private string airportField;
    
	private int timeField;
    
	private string cloud_friendlyField;
    
	private int cloud_altitudeField;
    
	private string cloud_typeField;
    
	private string conditionsField;
    
	private float pressureField;
    
	private int temp_airField;
    
	private int temp_dewpointField;
    
	private int temp_relhumField;
    
	private float visibilityField;
    
	private string wind_friendlyField;
    
	private int wind_directionField;
    
	private int wind_speedField;
    
	private int wind_speed_gustField;
    
	private string raw_dataField;
    
	/// <remarks/>
	public string airport {
		get {
			return this.airportField;
		}
		set {
			this.airportField = value;
		}
	}
    
	/// <remarks/>
	public int time {
		get {
			return this.timeField;
		}
		set {
			this.timeField = value;
		}
	}
    
	/// <remarks/>
	public string cloud_friendly {
		get {
			return this.cloud_friendlyField;
		}
		set {
			this.cloud_friendlyField = value;
		}
	}
    
	/// <remarks/>
	public int cloud_altitude {
		get {
			return this.cloud_altitudeField;
		}
		set {
			this.cloud_altitudeField = value;
		}
	}
    
	/// <remarks/>
	public string cloud_type {
		get {
			return this.cloud_typeField;
		}
		set {
			this.cloud_typeField = value;
		}
	}
    
	/// <remarks/>
	public string conditions {
		get {
			return this.conditionsField;
		}
		set {
			this.conditionsField = value;
		}
	}
    
	/// <remarks/>
	public float pressure {
		get {
			return this.pressureField;
		}
		set {
			this.pressureField = value;
		}
	}
    
	/// <remarks/>
	public int temp_air {
		get {
			return this.temp_airField;
		}
		set {
			this.temp_airField = value;
		}
	}
    
	/// <remarks/>
	public int temp_dewpoint {
		get {
			return this.temp_dewpointField;
		}
		set {
			this.temp_dewpointField = value;
		}
	}
    
	/// <remarks/>
	public int temp_relhum {
		get {
			return this.temp_relhumField;
		}
		set {
			this.temp_relhumField = value;
		}
	}
    
	/// <remarks/>
	public float visibility {
		get {
			return this.visibilityField;
		}
		set {
			this.visibilityField = value;
		}
	}
    
	/// <remarks/>
	public string wind_friendly {
		get {
			return this.wind_friendlyField;
		}
		set {
			this.wind_friendlyField = value;
		}
	}
    
	/// <remarks/>
	public int wind_direction {
		get {
			return this.wind_directionField;
		}
		set {
			this.wind_directionField = value;
		}
	}
    
	/// <remarks/>
	public int wind_speed {
		get {
			return this.wind_speedField;
		}
		set {
			this.wind_speedField = value;
		}
	}
    
	/// <remarks/>
	public int wind_speed_gust {
		get {
			return this.wind_speed_gustField;
		}
		set {
			this.wind_speed_gustField = value;
		}
	}
    
	/// <remarks/>
	public string raw_data {
		get {
			return this.raw_dataField;
		}
		set {
			this.raw_dataField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class ArrayOfMetarStruct {
    
	private int next_offsetField;
    
	private MetarStruct[] metarField;
    
	/// <remarks/>
	public int next_offset {
		get {
			return this.next_offsetField;
		}
		set {
			this.next_offsetField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("metar")]
	public MetarStruct[] metar {
		get {
			return this.metarField;
		}
		set {
			this.metarField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class TrackStruct {
    
	private int timestampField;
    
	private float latitudeField;
    
	private float longitudeField;
    
	private int groundspeedField;
    
	private int altitudeField;
    
	private string altitudeStatusField;
    
	private string updateTypeField;
    
	private string altitudeChangeField;
    
	/// <remarks/>
	public int timestamp {
		get {
			return this.timestampField;
		}
		set {
			this.timestampField = value;
		}
	}
    
	/// <remarks/>
	public float latitude {
		get {
			return this.latitudeField;
		}
		set {
			this.latitudeField = value;
		}
	}
    
	/// <remarks/>
	public float longitude {
		get {
			return this.longitudeField;
		}
		set {
			this.longitudeField = value;
		}
	}
    
	/// <remarks/>
	public int groundspeed {
		get {
			return this.groundspeedField;
		}
		set {
			this.groundspeedField = value;
		}
	}
    
	/// <remarks/>
	public int altitude {
		get {
			return this.altitudeField;
		}
		set {
			this.altitudeField = value;
		}
	}
    
	/// <remarks/>
	public string altitudeStatus {
		get {
			return this.altitudeStatusField;
		}
		set {
			this.altitudeStatusField = value;
		}
	}
    
	/// <remarks/>
	public string updateType {
		get {
			return this.updateTypeField;
		}
		set {
			this.updateTypeField = value;
		}
	}
    
	/// <remarks/>
	public string altitudeChange {
		get {
			return this.altitudeChangeField;
		}
		set {
			this.altitudeChangeField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class FlightAlertChannel {
    
	private int channel_idField;
    
	private string channel_nameField;
    
	private string mask_summaryField;
    
	private bool e_filedField;
    
	private bool e_departureField;
    
	private bool e_arrivalField;
    
	private bool e_divertedField;
    
	private bool e_cancelledField;
    
	private string target_addressField;
    
	/// <remarks/>
	public int channel_id {
		get {
			return this.channel_idField;
		}
		set {
			this.channel_idField = value;
		}
	}
    
	/// <remarks/>
	public string channel_name {
		get {
			return this.channel_nameField;
		}
		set {
			this.channel_nameField = value;
		}
	}
    
	/// <remarks/>
	public string mask_summary {
		get {
			return this.mask_summaryField;
		}
		set {
			this.mask_summaryField = value;
		}
	}
    
	/// <remarks/>
	public bool e_filed {
		get {
			return this.e_filedField;
		}
		set {
			this.e_filedField = value;
		}
	}
    
	/// <remarks/>
	public bool e_departure {
		get {
			return this.e_departureField;
		}
		set {
			this.e_departureField = value;
		}
	}
    
	/// <remarks/>
	public bool e_arrival {
		get {
			return this.e_arrivalField;
		}
		set {
			this.e_arrivalField = value;
		}
	}
    
	/// <remarks/>
	public bool e_diverted {
		get {
			return this.e_divertedField;
		}
		set {
			this.e_divertedField = value;
		}
	}
    
	/// <remarks/>
	public bool e_cancelled {
		get {
			return this.e_cancelledField;
		}
		set {
			this.e_cancelledField = value;
		}
	}
    
	/// <remarks/>
	public string target_address {
		get {
			return this.target_addressField;
		}
		set {
			this.target_addressField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class FlightAlertEntry {
    
	private int alert_idField;
    
	private bool enabledField;
    
	private string descriptionField;
    
	private string typeField;
    
	private string identField;
    
	private string user_identField;
    
	private string aircrafttypeField;
    
	private string originField;
    
	private string destinationField;
    
	private int date_startField;
    
	private int date_endField;
    
	private FlightAlertChannel[] channelsField;
    
	private int alert_createdField;
    
	private int alert_changedField;
    
	/// <remarks/>
	public int alert_id {
		get {
			return this.alert_idField;
		}
		set {
			this.alert_idField = value;
		}
	}
    
	/// <remarks/>
	public bool enabled {
		get {
			return this.enabledField;
		}
		set {
			this.enabledField = value;
		}
	}
    
	/// <remarks/>
	public string description {
		get {
			return this.descriptionField;
		}
		set {
			this.descriptionField = value;
		}
	}
    
	/// <remarks/>
	public string type {
		get {
			return this.typeField;
		}
		set {
			this.typeField = value;
		}
	}
    
	/// <remarks/>
	public string ident {
		get {
			return this.identField;
		}
		set {
			this.identField = value;
		}
	}
    
	/// <remarks/>
	public string user_ident {
		get {
			return this.user_identField;
		}
		set {
			this.user_identField = value;
		}
	}
    
	/// <remarks/>
	public string aircrafttype {
		get {
			return this.aircrafttypeField;
		}
		set {
			this.aircrafttypeField = value;
		}
	}
    
	/// <remarks/>
	public string origin {
		get {
			return this.originField;
		}
		set {
			this.originField = value;
		}
	}
    
	/// <remarks/>
	public string destination {
		get {
			return this.destinationField;
		}
		set {
			this.destinationField = value;
		}
	}
    
	/// <remarks/>
	public int date_start {
		get {
			return this.date_startField;
		}
		set {
			this.date_startField = value;
		}
	}
    
	/// <remarks/>
	public int date_end {
		get {
			return this.date_endField;
		}
		set {
			this.date_endField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("channels")]
	public FlightAlertChannel[] channels {
		get {
			return this.channelsField;
		}
		set {
			this.channelsField = value;
		}
	}
    
	/// <remarks/>
	public int alert_created {
		get {
			return this.alert_createdField;
		}
		set {
			this.alert_createdField = value;
		}
	}
    
	/// <remarks/>
	public int alert_changed {
		get {
			return this.alert_changedField;
		}
		set {
			this.alert_changedField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class FlightAlertListing {
    
	private int num_alertsField;
    
	private FlightAlertEntry[] alertsField;
    
	/// <remarks/>
	public int num_alerts {
		get {
			return this.num_alertsField;
		}
		set {
			this.num_alertsField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("alerts")]
	public FlightAlertEntry[] alerts {
		get {
			return this.alertsField;
		}
		set {
			this.alertsField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class FlightExStruct {
    
	private string faFlightIDField;
    
	private string identField;
    
	private string aircrafttypeField;
    
	private string filed_eteField;
    
	private int filed_timeField;
    
	private int filed_departuretimeField;
    
	private int filed_airspeed_ktsField;
    
	private string filed_airspeed_machField;
    
	private int filed_altitudeField;
    
	private string routeField;
    
	private int actualdeparturetimeField;
    
	private int estimatedarrivaltimeField;
    
	private int actualarrivaltimeField;
    
	private string divertedField;
    
	private string originField;
    
	private string destinationField;
    
	private string originNameField;
    
	private string originCityField;
    
	private string destinationNameField;
    
	private string destinationCityField;
    
	/// <remarks/>
	public string faFlightID {
		get {
			return this.faFlightIDField;
		}
		set {
			this.faFlightIDField = value;
		}
	}
    
	/// <remarks/>
	public string ident {
		get {
			return this.identField;
		}
		set {
			this.identField = value;
		}
	}
    
	/// <remarks/>
	public string aircrafttype {
		get {
			return this.aircrafttypeField;
		}
		set {
			this.aircrafttypeField = value;
		}
	}
    
	/// <remarks/>
	public string filed_ete {
		get {
			return this.filed_eteField;
		}
		set {
			this.filed_eteField = value;
		}
	}
    
	/// <remarks/>
	public int filed_time {
		get {
			return this.filed_timeField;
		}
		set {
			this.filed_timeField = value;
		}
	}
    
	/// <remarks/>
	public int filed_departuretime {
		get {
			return this.filed_departuretimeField;
		}
		set {
			this.filed_departuretimeField = value;
		}
	}
    
	/// <remarks/>
	public int filed_airspeed_kts {
		get {
			return this.filed_airspeed_ktsField;
		}
		set {
			this.filed_airspeed_ktsField = value;
		}
	}
    
	/// <remarks/>
	public string filed_airspeed_mach {
		get {
			return this.filed_airspeed_machField;
		}
		set {
			this.filed_airspeed_machField = value;
		}
	}
    
	/// <remarks/>
	public int filed_altitude {
		get {
			return this.filed_altitudeField;
		}
		set {
			this.filed_altitudeField = value;
		}
	}
    
	/// <remarks/>
	public string route {
		get {
			return this.routeField;
		}
		set {
			this.routeField = value;
		}
	}
    
	/// <remarks/>
	public int actualdeparturetime {
		get {
			return this.actualdeparturetimeField;
		}
		set {
			this.actualdeparturetimeField = value;
		}
	}
    
	/// <remarks/>
	public int estimatedarrivaltime {
		get {
			return this.estimatedarrivaltimeField;
		}
		set {
			this.estimatedarrivaltimeField = value;
		}
	}
    
	/// <remarks/>
	public int actualarrivaltime {
		get {
			return this.actualarrivaltimeField;
		}
		set {
			this.actualarrivaltimeField = value;
		}
	}
    
	/// <remarks/>
	public string diverted {
		get {
			return this.divertedField;
		}
		set {
			this.divertedField = value;
		}
	}
    
	/// <remarks/>
	public string origin {
		get {
			return this.originField;
		}
		set {
			this.originField = value;
		}
	}
    
	/// <remarks/>
	public string destination {
		get {
			return this.destinationField;
		}
		set {
			this.destinationField = value;
		}
	}
    
	/// <remarks/>
	public string originName {
		get {
			return this.originNameField;
		}
		set {
			this.originNameField = value;
		}
	}
    
	/// <remarks/>
	public string originCity {
		get {
			return this.originCityField;
		}
		set {
			this.originCityField = value;
		}
	}
    
	/// <remarks/>
	public string destinationName {
		get {
			return this.destinationNameField;
		}
		set {
			this.destinationNameField = value;
		}
	}
    
	/// <remarks/>
	public string destinationCity {
		get {
			return this.destinationCityField;
		}
		set {
			this.destinationCityField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class FlightInfoExStruct {
    
	private int next_offsetField;
    
	private FlightExStruct[] flightsField;
    
	/// <remarks/>
	public int next_offset {
		get {
			return this.next_offsetField;
		}
		set {
			this.next_offsetField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("flights")]
	public FlightExStruct[] flights {
		get {
			return this.flightsField;
		}
		set {
			this.flightsField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class FlightStruct {
    
	private string identField;
    
	private string aircrafttypeField;
    
	private string filed_eteField;
    
	private int filed_timeField;
    
	private int filed_departuretimeField;
    
	private int filed_airspeed_ktsField;
    
	private string filed_airspeed_machField;
    
	private int filed_altitudeField;
    
	private string routeField;
    
	private int actualdeparturetimeField;
    
	private int estimatedarrivaltimeField;
    
	private int actualarrivaltimeField;
    
	private string divertedField;
    
	private string originField;
    
	private string destinationField;
    
	private string originNameField;
    
	private string originCityField;
    
	private string destinationNameField;
    
	private string destinationCityField;
    
	/// <remarks/>
	public string ident {
		get {
			return this.identField;
		}
		set {
			this.identField = value;
		}
	}
    
	/// <remarks/>
	public string aircrafttype {
		get {
			return this.aircrafttypeField;
		}
		set {
			this.aircrafttypeField = value;
		}
	}
    
	/// <remarks/>
	public string filed_ete {
		get {
			return this.filed_eteField;
		}
		set {
			this.filed_eteField = value;
		}
	}
    
	/// <remarks/>
	public int filed_time {
		get {
			return this.filed_timeField;
		}
		set {
			this.filed_timeField = value;
		}
	}
    
	/// <remarks/>
	public int filed_departuretime {
		get {
			return this.filed_departuretimeField;
		}
		set {
			this.filed_departuretimeField = value;
		}
	}
    
	/// <remarks/>
	public int filed_airspeed_kts {
		get {
			return this.filed_airspeed_ktsField;
		}
		set {
			this.filed_airspeed_ktsField = value;
		}
	}
    
	/// <remarks/>
	public string filed_airspeed_mach {
		get {
			return this.filed_airspeed_machField;
		}
		set {
			this.filed_airspeed_machField = value;
		}
	}
    
	/// <remarks/>
	public int filed_altitude {
		get {
			return this.filed_altitudeField;
		}
		set {
			this.filed_altitudeField = value;
		}
	}
    
	/// <remarks/>
	public string route {
		get {
			return this.routeField;
		}
		set {
			this.routeField = value;
		}
	}
    
	/// <remarks/>
	public int actualdeparturetime {
		get {
			return this.actualdeparturetimeField;
		}
		set {
			this.actualdeparturetimeField = value;
		}
	}
    
	/// <remarks/>
	public int estimatedarrivaltime {
		get {
			return this.estimatedarrivaltimeField;
		}
		set {
			this.estimatedarrivaltimeField = value;
		}
	}
    
	/// <remarks/>
	public int actualarrivaltime {
		get {
			return this.actualarrivaltimeField;
		}
		set {
			this.actualarrivaltimeField = value;
		}
	}
    
	/// <remarks/>
	public string diverted {
		get {
			return this.divertedField;
		}
		set {
			this.divertedField = value;
		}
	}
    
	/// <remarks/>
	public string origin {
		get {
			return this.originField;
		}
		set {
			this.originField = value;
		}
	}
    
	/// <remarks/>
	public string destination {
		get {
			return this.destinationField;
		}
		set {
			this.destinationField = value;
		}
	}
    
	/// <remarks/>
	public string originName {
		get {
			return this.originNameField;
		}
		set {
			this.originNameField = value;
		}
	}
    
	/// <remarks/>
	public string originCity {
		get {
			return this.originCityField;
		}
		set {
			this.originCityField = value;
		}
	}
    
	/// <remarks/>
	public string destinationName {
		get {
			return this.destinationNameField;
		}
		set {
			this.destinationNameField = value;
		}
	}
    
	/// <remarks/>
	public string destinationCity {
		get {
			return this.destinationCityField;
		}
		set {
			this.destinationCityField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class FlightInfoStruct {
    
	private int next_offsetField;
    
	private FlightStruct[] flightsField;
    
	/// <remarks/>
	public int next_offset {
		get {
			return this.next_offsetField;
		}
		set {
			this.next_offsetField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("flights")]
	public FlightStruct[] flights {
		get {
			return this.flightsField;
		}
		set {
			this.flightsField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class ScheduledFlightStruct {
    
	private string identField;
    
	private string aircrafttypeField;
    
	private int filed_departuretimeField;
    
	private int estimatedarrivaltimeField;
    
	private string originField;
    
	private string destinationField;
    
	private string originNameField;
    
	private string originCityField;
    
	private string destinationNameField;
    
	private string destinationCityField;
    
	/// <remarks/>
	public string ident {
		get {
			return this.identField;
		}
		set {
			this.identField = value;
		}
	}
    
	/// <remarks/>
	public string aircrafttype {
		get {
			return this.aircrafttypeField;
		}
		set {
			this.aircrafttypeField = value;
		}
	}
    
	/// <remarks/>
	public int filed_departuretime {
		get {
			return this.filed_departuretimeField;
		}
		set {
			this.filed_departuretimeField = value;
		}
	}
    
	/// <remarks/>
	public int estimatedarrivaltime {
		get {
			return this.estimatedarrivaltimeField;
		}
		set {
			this.estimatedarrivaltimeField = value;
		}
	}
    
	/// <remarks/>
	public string origin {
		get {
			return this.originField;
		}
		set {
			this.originField = value;
		}
	}
    
	/// <remarks/>
	public string destination {
		get {
			return this.destinationField;
		}
		set {
			this.destinationField = value;
		}
	}
    
	/// <remarks/>
	public string originName {
		get {
			return this.originNameField;
		}
		set {
			this.originNameField = value;
		}
	}
    
	/// <remarks/>
	public string originCity {
		get {
			return this.originCityField;
		}
		set {
			this.originCityField = value;
		}
	}
    
	/// <remarks/>
	public string destinationName {
		get {
			return this.destinationNameField;
		}
		set {
			this.destinationNameField = value;
		}
	}
    
	/// <remarks/>
	public string destinationCity {
		get {
			return this.destinationCityField;
		}
		set {
			this.destinationCityField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class ScheduledStruct {
    
	private int next_offsetField;
    
	private ScheduledFlightStruct[] scheduledField;
    
	/// <remarks/>
	public int next_offset {
		get {
			return this.next_offsetField;
		}
		set {
			this.next_offsetField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("scheduled")]
	public ScheduledFlightStruct[] scheduled {
		get {
			return this.scheduledField;
		}
		set {
			this.scheduledField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class EnrouteFlightStruct {
    
	private string identField;
    
	private string aircrafttypeField;
    
	private int actualdeparturetimeField;
    
	private int estimatedarrivaltimeField;
    
	private int filed_departuretimeField;
    
	private string originField;
    
	private string destinationField;
    
	private string originNameField;
    
	private string originCityField;
    
	private string destinationNameField;
    
	private string destinationCityField;
    
	/// <remarks/>
	public string ident {
		get {
			return this.identField;
		}
		set {
			this.identField = value;
		}
	}
    
	/// <remarks/>
	public string aircrafttype {
		get {
			return this.aircrafttypeField;
		}
		set {
			this.aircrafttypeField = value;
		}
	}
    
	/// <remarks/>
	public int actualdeparturetime {
		get {
			return this.actualdeparturetimeField;
		}
		set {
			this.actualdeparturetimeField = value;
		}
	}
    
	/// <remarks/>
	public int estimatedarrivaltime {
		get {
			return this.estimatedarrivaltimeField;
		}
		set {
			this.estimatedarrivaltimeField = value;
		}
	}
    
	/// <remarks/>
	public int filed_departuretime {
		get {
			return this.filed_departuretimeField;
		}
		set {
			this.filed_departuretimeField = value;
		}
	}
    
	/// <remarks/>
	public string origin {
		get {
			return this.originField;
		}
		set {
			this.originField = value;
		}
	}
    
	/// <remarks/>
	public string destination {
		get {
			return this.destinationField;
		}
		set {
			this.destinationField = value;
		}
	}
    
	/// <remarks/>
	public string originName {
		get {
			return this.originNameField;
		}
		set {
			this.originNameField = value;
		}
	}
    
	/// <remarks/>
	public string originCity {
		get {
			return this.originCityField;
		}
		set {
			this.originCityField = value;
		}
	}
    
	/// <remarks/>
	public string destinationName {
		get {
			return this.destinationNameField;
		}
		set {
			this.destinationNameField = value;
		}
	}
    
	/// <remarks/>
	public string destinationCity {
		get {
			return this.destinationCityField;
		}
		set {
			this.destinationCityField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class EnrouteStruct {
    
	private int next_offsetField;
    
	private EnrouteFlightStruct[] enrouteField;
    
	/// <remarks/>
	public int next_offset {
		get {
			return this.next_offsetField;
		}
		set {
			this.next_offsetField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("enroute")]
	public EnrouteFlightStruct[] enroute {
		get {
			return this.enrouteField;
		}
		set {
			this.enrouteField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class DepartureFlightStruct {
    
	private string identField;
    
	private string aircrafttypeField;
    
	private int actualdeparturetimeField;
    
	private int estimatedarrivaltimeField;
    
	private int actualarrivaltimeField;
    
	private string originField;
    
	private string destinationField;
    
	private string originNameField;
    
	private string originCityField;
    
	private string destinationNameField;
    
	private string destinationCityField;
    
	/// <remarks/>
	public string ident {
		get {
			return this.identField;
		}
		set {
			this.identField = value;
		}
	}
    
	/// <remarks/>
	public string aircrafttype {
		get {
			return this.aircrafttypeField;
		}
		set {
			this.aircrafttypeField = value;
		}
	}
    
	/// <remarks/>
	public int actualdeparturetime {
		get {
			return this.actualdeparturetimeField;
		}
		set {
			this.actualdeparturetimeField = value;
		}
	}
    
	/// <remarks/>
	public int estimatedarrivaltime {
		get {
			return this.estimatedarrivaltimeField;
		}
		set {
			this.estimatedarrivaltimeField = value;
		}
	}
    
	/// <remarks/>
	public int actualarrivaltime {
		get {
			return this.actualarrivaltimeField;
		}
		set {
			this.actualarrivaltimeField = value;
		}
	}
    
	/// <remarks/>
	public string origin {
		get {
			return this.originField;
		}
		set {
			this.originField = value;
		}
	}
    
	/// <remarks/>
	public string destination {
		get {
			return this.destinationField;
		}
		set {
			this.destinationField = value;
		}
	}
    
	/// <remarks/>
	public string originName {
		get {
			return this.originNameField;
		}
		set {
			this.originNameField = value;
		}
	}
    
	/// <remarks/>
	public string originCity {
		get {
			return this.originCityField;
		}
		set {
			this.originCityField = value;
		}
	}
    
	/// <remarks/>
	public string destinationName {
		get {
			return this.destinationNameField;
		}
		set {
			this.destinationNameField = value;
		}
	}
    
	/// <remarks/>
	public string destinationCity {
		get {
			return this.destinationCityField;
		}
		set {
			this.destinationCityField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class DepartureStruct {
    
	private int next_offsetField;
    
	private DepartureFlightStruct[] departuresField;
    
	/// <remarks/>
	public int next_offset {
		get {
			return this.next_offsetField;
		}
		set {
			this.next_offsetField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("departures")]
	public DepartureFlightStruct[] departures {
		get {
			return this.departuresField;
		}
		set {
			this.departuresField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class FlightRouteStruct {
    
	private string nameField;
    
	private string typeField;
    
	private float latitudeField;
    
	private float longitudeField;
    
	/// <remarks/>
	public string name {
		get {
			return this.nameField;
		}
		set {
			this.nameField = value;
		}
	}
    
	/// <remarks/>
	public string type {
		get {
			return this.typeField;
		}
		set {
			this.typeField = value;
		}
	}
    
	/// <remarks/>
	public float latitude {
		get {
			return this.latitudeField;
		}
		set {
			this.latitudeField = value;
		}
	}
    
	/// <remarks/>
	public float longitude {
		get {
			return this.longitudeField;
		}
		set {
			this.longitudeField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class ArrayOfFlightRouteStruct {
    
	private int next_offsetField;
    
	private FlightRouteStruct[] dataField;
    
	/// <remarks/>
	public int next_offset {
		get {
			return this.next_offsetField;
		}
		set {
			this.next_offsetField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("data")]
	public FlightRouteStruct[] data {
		get {
			return this.dataField;
		}
		set {
			this.dataField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class CountAirlineOperationsStruct {
    
	private string icaoField;
    
	private string nameField;
    
	private int enrouteField;
    
	/// <remarks/>
	public string icao {
		get {
			return this.icaoField;
		}
		set {
			this.icaoField = value;
		}
	}
    
	/// <remarks/>
	public string name {
		get {
			return this.nameField;
		}
		set {
			this.nameField = value;
		}
	}
    
	/// <remarks/>
	public int enroute {
		get {
			return this.enrouteField;
		}
		set {
			this.enrouteField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class CountAirportOperationsStruct {
    
	private int enrouteField;
    
	private int departedField;
    
	private int scheduled_departuresField;
    
	private int scheduled_arrivalsField;
    
	/// <remarks/>
	public int enroute {
		get {
			return this.enrouteField;
		}
		set {
			this.enrouteField = value;
		}
	}
    
	/// <remarks/>
	public int departed {
		get {
			return this.departedField;
		}
		set {
			this.departedField = value;
		}
	}
    
	/// <remarks/>
	public int scheduled_departures {
		get {
			return this.scheduled_departuresField;
		}
		set {
			this.scheduled_departuresField = value;
		}
	}
    
	/// <remarks/>
	public int scheduled_arrivals {
		get {
			return this.scheduled_arrivalsField;
		}
		set {
			this.scheduled_arrivalsField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class ArrivalFlightStruct {
    
	private string identField;
    
	private string aircrafttypeField;
    
	private int actualdeparturetimeField;
    
	private int actualarrivaltimeField;
    
	private string originField;
    
	private string destinationField;
    
	private string originNameField;
    
	private string originCityField;
    
	private string destinationNameField;
    
	private string destinationCityField;
    
	/// <remarks/>
	public string ident {
		get {
			return this.identField;
		}
		set {
			this.identField = value;
		}
	}
    
	/// <remarks/>
	public string aircrafttype {
		get {
			return this.aircrafttypeField;
		}
		set {
			this.aircrafttypeField = value;
		}
	}
    
	/// <remarks/>
	public int actualdeparturetime {
		get {
			return this.actualdeparturetimeField;
		}
		set {
			this.actualdeparturetimeField = value;
		}
	}
    
	/// <remarks/>
	public int actualarrivaltime {
		get {
			return this.actualarrivaltimeField;
		}
		set {
			this.actualarrivaltimeField = value;
		}
	}
    
	/// <remarks/>
	public string origin {
		get {
			return this.originField;
		}
		set {
			this.originField = value;
		}
	}
    
	/// <remarks/>
	public string destination {
		get {
			return this.destinationField;
		}
		set {
			this.destinationField = value;
		}
	}
    
	/// <remarks/>
	public string originName {
		get {
			return this.originNameField;
		}
		set {
			this.originNameField = value;
		}
	}
    
	/// <remarks/>
	public string originCity {
		get {
			return this.originCityField;
		}
		set {
			this.originCityField = value;
		}
	}
    
	/// <remarks/>
	public string destinationName {
		get {
			return this.destinationNameField;
		}
		set {
			this.destinationNameField = value;
		}
	}
    
	/// <remarks/>
	public string destinationCity {
		get {
			return this.destinationCityField;
		}
		set {
			this.destinationCityField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class ArrivalStruct {
    
	private int next_offsetField;
    
	private ArrivalFlightStruct[] arrivalsField;
    
	/// <remarks/>
	public int next_offset {
		get {
			return this.next_offsetField;
		}
		set {
			this.next_offsetField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("arrivals")]
	public ArrivalFlightStruct[] arrivals {
		get {
			return this.arrivalsField;
		}
		set {
			this.arrivalsField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class AirportInfoStruct {
    
	private string nameField;
    
	private string locationField;
    
	private float longitudeField;
    
	private float latitudeField;
    
	private string timezoneField;
    
	/// <remarks/>
	public string name {
		get {
			return this.nameField;
		}
		set {
			this.nameField = value;
		}
	}
    
	/// <remarks/>
	public string location {
		get {
			return this.locationField;
		}
		set {
			this.locationField = value;
		}
	}
    
	/// <remarks/>
	public float longitude {
		get {
			return this.longitudeField;
		}
		set {
			this.longitudeField = value;
		}
	}
    
	/// <remarks/>
	public float latitude {
		get {
			return this.latitudeField;
		}
		set {
			this.latitudeField = value;
		}
	}
    
	/// <remarks/>
	public string timezone {
		get {
			return this.timezoneField;
		}
		set {
			this.timezoneField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class AirlineInsightStruct {
    
	private string originField;
    
	private string layoverField;
    
	private string destinationField;
    
	private string carrierField;
    
	private string opcarrierField;
    
	private int flights_scheduledField;
    
	private int flights_performedField;
    
	private int total_passengersField;
    
	private int total_seatsField;
    
	private int total_payloadField;
    
	private int total_mailField;
    
	private float percentField;
    
	private string fare_minField;
    
	private string fare_medianField;
    
	private string fare_maxField;
    
	/// <remarks/>
	public string origin {
		get {
			return this.originField;
		}
		set {
			this.originField = value;
		}
	}
    
	/// <remarks/>
	public string layover {
		get {
			return this.layoverField;
		}
		set {
			this.layoverField = value;
		}
	}
    
	/// <remarks/>
	public string destination {
		get {
			return this.destinationField;
		}
		set {
			this.destinationField = value;
		}
	}
    
	/// <remarks/>
	public string carrier {
		get {
			return this.carrierField;
		}
		set {
			this.carrierField = value;
		}
	}
    
	/// <remarks/>
	public string opcarrier {
		get {
			return this.opcarrierField;
		}
		set {
			this.opcarrierField = value;
		}
	}
    
	/// <remarks/>
	public int flights_scheduled {
		get {
			return this.flights_scheduledField;
		}
		set {
			this.flights_scheduledField = value;
		}
	}
    
	/// <remarks/>
	public int flights_performed {
		get {
			return this.flights_performedField;
		}
		set {
			this.flights_performedField = value;
		}
	}
    
	/// <remarks/>
	public int total_passengers {
		get {
			return this.total_passengersField;
		}
		set {
			this.total_passengersField = value;
		}
	}
    
	/// <remarks/>
	public int total_seats {
		get {
			return this.total_seatsField;
		}
		set {
			this.total_seatsField = value;
		}
	}
    
	/// <remarks/>
	public int total_payload {
		get {
			return this.total_payloadField;
		}
		set {
			this.total_payloadField = value;
		}
	}
    
	/// <remarks/>
	public int total_mail {
		get {
			return this.total_mailField;
		}
		set {
			this.total_mailField = value;
		}
	}
    
	/// <remarks/>
	public float percent {
		get {
			return this.percentField;
		}
		set {
			this.percentField = value;
		}
	}
    
	/// <remarks/>
	public string fare_min {
		get {
			return this.fare_minField;
		}
		set {
			this.fare_minField = value;
		}
	}
    
	/// <remarks/>
	public string fare_median {
		get {
			return this.fare_medianField;
		}
		set {
			this.fare_medianField = value;
		}
	}
    
	/// <remarks/>
	public string fare_max {
		get {
			return this.fare_maxField;
		}
		set {
			this.fare_maxField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class ArrayOfAirlineInsightStruct {
    
	private AirlineInsightStruct[] dataField;
    
	private int start_dateField;
    
	private int end_dateField;
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("data")]
	public AirlineInsightStruct[] data {
		get {
			return this.dataField;
		}
		set {
			this.dataField = value;
		}
	}
    
	/// <remarks/>
	public int start_date {
		get {
			return this.start_dateField;
		}
		set {
			this.start_dateField = value;
		}
	}
    
	/// <remarks/>
	public int end_date {
		get {
			return this.end_dateField;
		}
		set {
			this.end_dateField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class AirlineInfoStruct {
    
	private string nameField;
    
	private string shortnameField;
    
	private string callsignField;
    
	private string locationField;
    
	private string countryField;
    
	private string urlField;
    
	private string phoneField;
    
	/// <remarks/>
	public string name {
		get {
			return this.nameField;
		}
		set {
			this.nameField = value;
		}
	}
    
	/// <remarks/>
	public string shortname {
		get {
			return this.shortnameField;
		}
		set {
			this.shortnameField = value;
		}
	}
    
	/// <remarks/>
	public string callsign {
		get {
			return this.callsignField;
		}
		set {
			this.callsignField = value;
		}
	}
    
	/// <remarks/>
	public string location {
		get {
			return this.locationField;
		}
		set {
			this.locationField = value;
		}
	}
    
	/// <remarks/>
	public string country {
		get {
			return this.countryField;
		}
		set {
			this.countryField = value;
		}
	}
    
	/// <remarks/>
	public string url {
		get {
			return this.urlField;
		}
		set {
			this.urlField = value;
		}
	}
    
	/// <remarks/>
	public string phone {
		get {
			return this.phoneField;
		}
		set {
			this.phoneField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class AirlineFlightScheduleStruct {
    
	private string identField;
    
	private string actual_identField;
    
	private int departuretimeField;
    
	private int arrivaltimeField;
    
	private string originField;
    
	private string destinationField;
    
	private string aircrafttypeField;
    
	private string meal_serviceField;
    
	private int seats_cabin_firstField;
    
	private int seats_cabin_businessField;
    
	private int seats_cabin_coachField;
    
	/// <remarks/>
	public string ident {
		get {
			return this.identField;
		}
		set {
			this.identField = value;
		}
	}
    
	/// <remarks/>
	public string actual_ident {
		get {
			return this.actual_identField;
		}
		set {
			this.actual_identField = value;
		}
	}
    
	/// <remarks/>
	public int departuretime {
		get {
			return this.departuretimeField;
		}
		set {
			this.departuretimeField = value;
		}
	}
    
	/// <remarks/>
	public int arrivaltime {
		get {
			return this.arrivaltimeField;
		}
		set {
			this.arrivaltimeField = value;
		}
	}
    
	/// <remarks/>
	public string origin {
		get {
			return this.originField;
		}
		set {
			this.originField = value;
		}
	}
    
	/// <remarks/>
	public string destination {
		get {
			return this.destinationField;
		}
		set {
			this.destinationField = value;
		}
	}
    
	/// <remarks/>
	public string aircrafttype {
		get {
			return this.aircrafttypeField;
		}
		set {
			this.aircrafttypeField = value;
		}
	}
    
	/// <remarks/>
	public string meal_service {
		get {
			return this.meal_serviceField;
		}
		set {
			this.meal_serviceField = value;
		}
	}
    
	/// <remarks/>
	public int seats_cabin_first {
		get {
			return this.seats_cabin_firstField;
		}
		set {
			this.seats_cabin_firstField = value;
		}
	}
    
	/// <remarks/>
	public int seats_cabin_business {
		get {
			return this.seats_cabin_businessField;
		}
		set {
			this.seats_cabin_businessField = value;
		}
	}
    
	/// <remarks/>
	public int seats_cabin_coach {
		get {
			return this.seats_cabin_coachField;
		}
		set {
			this.seats_cabin_coachField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class ArrayOfAirlineFlightScheduleStruct {
    
	private int next_offsetField;
    
	private AirlineFlightScheduleStruct[] dataField;
    
	/// <remarks/>
	public int next_offset {
		get {
			return this.next_offsetField;
		}
		set {
			this.next_offsetField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("data")]
	public AirlineFlightScheduleStruct[] data {
		get {
			return this.dataField;
		}
		set {
			this.dataField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://flightxml.flightaware.com/soap/FlightXML2")]
public partial class AirlineFlightInfoStruct {
    
	private string faFlightIDField;
    
	private string identField;
    
	private string[] codesharesField;
    
	private string tailnumberField;
    
	private string meal_serviceField;
    
	private string gate_origField;
    
	private string gate_destField;
    
	private string terminal_origField;
    
	private string terminal_destField;
    
	private string bag_claimField;
    
	private int seats_cabin_firstField;
    
	private int seats_cabin_businessField;
    
	private int seats_cabin_coachField;
    
	/// <remarks/>
	public string faFlightID {
		get {
			return this.faFlightIDField;
		}
		set {
			this.faFlightIDField = value;
		}
	}
    
	/// <remarks/>
	public string ident {
		get {
			return this.identField;
		}
		set {
			this.identField = value;
		}
	}
    
	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("codeshares")]
	public string[] codeshares {
		get {
			return this.codesharesField;
		}
		set {
			this.codesharesField = value;
		}
	}
    
	/// <remarks/>
	public string tailnumber {
		get {
			return this.tailnumberField;
		}
		set {
			this.tailnumberField = value;
		}
	}
    
	/// <remarks/>
	public string meal_service {
		get {
			return this.meal_serviceField;
		}
		set {
			this.meal_serviceField = value;
		}
	}
    
	/// <remarks/>
	public string gate_orig {
		get {
			return this.gate_origField;
		}
		set {
			this.gate_origField = value;
		}
	}
    
	/// <remarks/>
	public string gate_dest {
		get {
			return this.gate_destField;
		}
		set {
			this.gate_destField = value;
		}
	}
    
	/// <remarks/>
	public string terminal_orig {
		get {
			return this.terminal_origField;
		}
		set {
			this.terminal_origField = value;
		}
	}
    
	/// <remarks/>
	public string terminal_dest {
		get {
			return this.terminal_destField;
		}
		set {
			this.terminal_destField = value;
		}
	}
    
	/// <remarks/>
	public string bag_claim {
		get {
			return this.bag_claimField;
		}
		set {
			this.bag_claimField = value;
		}
	}
    
	/// <remarks/>
	public int seats_cabin_first {
		get {
			return this.seats_cabin_firstField;
		}
		set {
			this.seats_cabin_firstField = value;
		}
	}
    
	/// <remarks/>
	public int seats_cabin_business {
		get {
			return this.seats_cabin_businessField;
		}
		set {
			this.seats_cabin_businessField = value;
		}
	}
    
	/// <remarks/>
	public int seats_cabin_coach {
		get {
			return this.seats_cabin_coachField;
		}
		set {
			this.seats_cabin_coachField = value;
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void AircraftTypeCompletedEventHandler(object sender, AircraftTypeCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AircraftTypeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal AircraftTypeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public AircraftTypeStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((AircraftTypeStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void AirlineFlightInfoCompletedEventHandler(object sender, AirlineFlightInfoCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AirlineFlightInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal AirlineFlightInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public AirlineFlightInfoStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((AirlineFlightInfoStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void AirlineFlightSchedulesCompletedEventHandler(object sender, AirlineFlightSchedulesCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AirlineFlightSchedulesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal AirlineFlightSchedulesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public ArrayOfAirlineFlightScheduleStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((ArrayOfAirlineFlightScheduleStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void AirlineInfoCompletedEventHandler(object sender, AirlineInfoCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AirlineInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal AirlineInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public AirlineInfoStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((AirlineInfoStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void AirlineInsightCompletedEventHandler(object sender, AirlineInsightCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AirlineInsightCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal AirlineInsightCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public ArrayOfAirlineInsightStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((ArrayOfAirlineInsightStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void AirportInfoCompletedEventHandler(object sender, AirportInfoCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AirportInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal AirportInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public AirportInfoStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((AirportInfoStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void AllAirlinesCompletedEventHandler(object sender, AllAirlinesCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AllAirlinesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal AllAirlinesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public string[] Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string[]) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void AllAirportsCompletedEventHandler(object sender, AllAirportsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AllAirportsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal AllAirportsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public string[] Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string[]) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void ArrivedCompletedEventHandler(object sender, ArrivedCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ArrivedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal ArrivedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public ArrivalStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((ArrivalStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void BlockIdentCheckCompletedEventHandler(object sender, BlockIdentCheckCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class BlockIdentCheckCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal BlockIdentCheckCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public int Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((int) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void CountAirportOperationsCompletedEventHandler(object sender, CountAirportOperationsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CountAirportOperationsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal CountAirportOperationsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public CountAirportOperationsStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((CountAirportOperationsStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void CountAllEnrouteAirlineOperationsCompletedEventHandler(object sender, CountAllEnrouteAirlineOperationsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class CountAllEnrouteAirlineOperationsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal CountAllEnrouteAirlineOperationsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public CountAirlineOperationsStruct[] Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((CountAirlineOperationsStruct[]) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void DecodeFlightRouteCompletedEventHandler(object sender, DecodeFlightRouteCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DecodeFlightRouteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal DecodeFlightRouteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public ArrayOfFlightRouteStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((ArrayOfFlightRouteStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void DecodeRouteCompletedEventHandler(object sender, DecodeRouteCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DecodeRouteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal DecodeRouteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public ArrayOfFlightRouteStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((ArrayOfFlightRouteStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void DeleteAlertCompletedEventHandler(object sender, DeleteAlertCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DeleteAlertCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal DeleteAlertCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public int Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((int) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void DepartedCompletedEventHandler(object sender, DepartedCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class DepartedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal DepartedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public DepartureStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((DepartureStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void EnrouteCompletedEventHandler(object sender, EnrouteCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class EnrouteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal EnrouteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public EnrouteStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((EnrouteStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void FleetArrivedCompletedEventHandler(object sender, FleetArrivedCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class FleetArrivedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal FleetArrivedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public ArrivalStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((ArrivalStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void FleetScheduledCompletedEventHandler(object sender, FleetScheduledCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class FleetScheduledCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal FleetScheduledCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public ScheduledStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((ScheduledStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void FlightInfoCompletedEventHandler(object sender, FlightInfoCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class FlightInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal FlightInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public FlightInfoStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((FlightInfoStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void FlightInfoExCompletedEventHandler(object sender, FlightInfoExCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class FlightInfoExCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal FlightInfoExCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public FlightInfoExStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((FlightInfoExStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void GetAlertsCompletedEventHandler(object sender, GetAlertsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetAlertsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal GetAlertsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public FlightAlertListing Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((FlightAlertListing) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void GetFlightIDCompletedEventHandler(object sender, GetFlightIDCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetFlightIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal GetFlightIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public string Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void GetHistoricalTrackCompletedEventHandler(object sender, GetHistoricalTrackCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetHistoricalTrackCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal GetHistoricalTrackCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public TrackStruct[] Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((TrackStruct[]) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void GetLastTrackCompletedEventHandler(object sender, GetLastTrackCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetLastTrackCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal GetLastTrackCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public TrackStruct[] Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((TrackStruct[]) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void InboundFlightInfoCompletedEventHandler(object sender, InboundFlightInfoCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class InboundFlightInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal InboundFlightInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public FlightExStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((FlightExStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void InFlightInfoCompletedEventHandler(object sender, InFlightInfoCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class InFlightInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal InFlightInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public InFlightAircraftStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((InFlightAircraftStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void LatLongsToDistanceCompletedEventHandler(object sender, LatLongsToDistanceCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class LatLongsToDistanceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal LatLongsToDistanceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public int Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((int) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void LatLongsToHeadingCompletedEventHandler(object sender, LatLongsToHeadingCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class LatLongsToHeadingCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal LatLongsToHeadingCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public int Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((int) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void MapFlightCompletedEventHandler(object sender, MapFlightCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MapFlightCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal MapFlightCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public string Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void MapFlightExCompletedEventHandler(object sender, MapFlightExCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MapFlightExCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal MapFlightExCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public string Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void MetarCompletedEventHandler(object sender, MetarCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MetarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal MetarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public string Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void MetarExCompletedEventHandler(object sender, MetarExCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MetarExCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal MetarExCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public ArrayOfMetarStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((ArrayOfMetarStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void NTafCompletedEventHandler(object sender, NTafCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class NTafCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal NTafCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public TafStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((TafStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void RegisterAlertEndpointCompletedEventHandler(object sender, RegisterAlertEndpointCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class RegisterAlertEndpointCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal RegisterAlertEndpointCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public int Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((int) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void RoutesBetweenAirportsCompletedEventHandler(object sender, RoutesBetweenAirportsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class RoutesBetweenAirportsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal RoutesBetweenAirportsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public RoutesBetweenAirportsStruct[] Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((RoutesBetweenAirportsStruct[]) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void RoutesBetweenAirportsExCompletedEventHandler(object sender, RoutesBetweenAirportsExCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class RoutesBetweenAirportsExCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal RoutesBetweenAirportsExCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public ArrayOfRoutesBetweenAirportsExStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((ArrayOfRoutesBetweenAirportsExStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void ScheduledCompletedEventHandler(object sender, ScheduledCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ScheduledCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal ScheduledCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public ScheduledStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((ScheduledStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void SearchCompletedEventHandler(object sender, SearchCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SearchCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal SearchCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public InFlightStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((InFlightStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void SearchBirdseyeInFlightCompletedEventHandler(object sender, SearchBirdseyeInFlightCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SearchBirdseyeInFlightCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal SearchBirdseyeInFlightCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public InFlightStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((InFlightStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void SearchBirdseyePositionsCompletedEventHandler(object sender, SearchBirdseyePositionsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SearchBirdseyePositionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal SearchBirdseyePositionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public ArrayOfTrackExStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((ArrayOfTrackExStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void SearchCountCompletedEventHandler(object sender, SearchCountCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SearchCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal SearchCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public int Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((int) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void SetAlertCompletedEventHandler(object sender, SetAlertCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SetAlertCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal SetAlertCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public int Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((int) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void SetMaximumResultSizeCompletedEventHandler(object sender, SetMaximumResultSizeCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SetMaximumResultSizeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal SetMaximumResultSizeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public int Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((int) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void TafCompletedEventHandler(object sender, TafCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class TafCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal TafCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public string Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((string) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void TailOwnerCompletedEventHandler(object sender, TailOwnerCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class TailOwnerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal TailOwnerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public TailOwnerStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((TailOwnerStruct) (this.results[0]));
		}
	}
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void ZipcodeInfoCompletedEventHandler(object sender, ZipcodeInfoCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ZipcodeInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
	private object[] results;
    
	internal ZipcodeInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
	base(exception, cancelled, userState) {
		this.results = results;
	}
    
	/// <remarks/>
	public ZipcodeInfoStruct Result {
		get {
			this.RaiseExceptionIfNecessary();
			return ((ZipcodeInfoStruct) (this.results[0]));
		}
	}
}

