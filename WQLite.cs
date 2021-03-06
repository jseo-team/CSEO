using System;
using dotNet;

namespace dotNet {

public class WQLite : Wise
{
	public delegate bool condition(string s);

	public WQLite(){}
	
}


public static class WiseBool {

	public static bool knows(this Wise w, string name){ return false; }
	public static bool contains(this Wise w, string text){ return false; }
	public static bool lessExists(this Wise w, string value){ return false; }
	public static bool greaterExists(this Wise w, string value){ return false; }

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

	public static Wise that(this Wise w, dotNet.WQLite.condition c, string s){ return new Wise(new string[]{""}); }

} 


}
