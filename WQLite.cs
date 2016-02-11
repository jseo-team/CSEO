using System;
using dotNet;

namespace dotNet {

public class WQLite : Wise
{
	public delegate bool condition(string s);

	public WQLite(){}
	
}


public static class WiseBool {

	public static bool knows(this Wise w, string name){}
	public static bool contains(this Wise w, string text){}
	public static bool lessThan(this Wise w, string value){}
	public static bool greaterThan(this Wise w, string value){}

}

public static class WiseCRUD {

	public static void create(this Wise w){}
	public static void reload(this Wise w, string id){}
	public static void update(this Wise w, string id, Wise data){}
	public static void delete(this Wise w, string id){}
}

public static class WiseLang {

	public static void XML(this Wise w, string xml){}
	public static void WQL(this Wise w, string wql){}
	public static void SQL(this Wise w, string sql){}

	public static Wise that(this Wise w, dotNet.WQLite.condition c, string s){}

} 


}
