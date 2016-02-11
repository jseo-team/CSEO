using System;

namespace dotNet
{

public class Looner : Wise
{
	public Looner()
	{
	}
}

public static class WiseClient
{
	public static void connect(this Wise w){}
	public static void quit(this Wise w){}


	// :: connection kept alive ::
	

	//prepare request
	//{...} \n
	public static void request(this Wise w){}			

	//header: {...} \n
	public static void header(this Wise w, string name){}
	//MODE {...} \n
	public static void mode(this Wise w, string name){}
	//{name}/item={two} ... \n
	public static void msg(this Wise w, string code){}

	// :: connection closed ::
	// validate welcome sqt
	// concat headers & requests
	// send everything at once
	public static void ask(this Wise w, string welcome){}


}


}
