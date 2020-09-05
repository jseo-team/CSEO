using System;

namespace dotNet
{

public static class Dyper
{

	// server:port
	public static void dype(this Wise w, int port, string sname){}

	// :: connection kept alive ::


	// prepare response
	// {...} \n
	public static void send(this Wise w, int status){}

	// header: {...} \n
	public static void header(this Wise w, string name){}
	// ACTIVE {...} \n
	public static void active(this Wise w, string name){}
	// {name}/item={two} ... \n
	public static void state(this Wise w, string code){}


	// :: connection closed ::

	// take any query & validate sqt
	// call within triggers when received
	// concat send() and header()
	// then transfer response
	public static void find(this Wise w, string query){ }


}

}

