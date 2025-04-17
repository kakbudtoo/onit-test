using System;

namespace StringDecoder
{
    public class Program
    {
        public static void Main()
        {
            string encodedString = "eflohgcpkgjpegaapahapboajbfbdbmbhedcbekcgfbdkphdlepdgegekdnepcefhdlfiobggcjgadahd" +
"chhmnnhncfiobmiibdjanjjcoakkmhklapkfaglkbnloldmcalmkacngpinfppnepgomknojpeplolpf" +
"pcajojamoabonhbhjobmnfccnmcboddlikdnmbedniegmpeemgfamnfhiegghlghkchiljhglainlhih" +
"goififjdkmjnkdkalkkmkblffilehplojgmeknmjeennjlnmicomijojiapkdhpihopaifaiimapgdbe" +
"ikblhbcfcicegpceggdmbndmgeeoflecgcfhgjflfagkahgicogcdfhfcmhopcipekiaebjkdijeepje" +
"dgkmomkaeelpcllpccmmcjmnnpmmbhnmboneneocbmoomcppakpnababbiadapaibgbmlmbiaecmpkcd" +
"lbddmidnkpdnpgemonehoefaplfmocgpnjgloahfjhhdnohdofimimimndjknkjembkcnikbnpkpmglh" +
"mnlciemlflmifcnekjnhlaoklhocgoomkfpblmpmkdakkkadfbbakibckpbmjgckincmiedcildbjcea" +
"ijeidafbihflhofchfgbhmghhdhjhkhigbidhiinbpioggjggnjebekfflkhfclofjljeamhehmoeome" +
"efnmplnnedoodkoidbpaphpbeppmdgaadnafcebnclbonbcacjcgcadmbhdlbodnbfebbmejmcfhakfb" +
"bbgeaignlognpfhganhcaeifalihpbjjpijnppjkogkcknkepelpollcocmeojmknanajhnbooncnfom" +
"mmoeidpemkpnmbajmiammpahmgbbmnbllecpllcjgcdpkjdblaeaghegloejkffmkmfgkdgbfkgcjbha" +
"jihojphkigioinioiejmiljgicklhjkbialeihlncolkhfmjhmmdhdnlgkndgboofiomgpoiggpacnpp" +
"aeabelamfcblejbdaacefhcfeocpdfdhpldaedekdkemdbfgdifldpffofgecngecehiclhiccincjid" +
"npiechjmbojkmekoamkjadlfbklolamhaimbapmipfnhpmnnpdoppkooobpgkipdpppcpgagonanneba" +
"olbcoccinjcoiadmmhdgnodjmfecimeomdfomkfnlbglligfmpgjlghllnhbleihglinkcjpkjjekakk" +
"khkkkokckfldjmldkdmfjkmijbnejinbfpnaegoggnoaiephdlpnicaaijadiablchbphobggfcahmcd" +
"hddmbkdkfbeegiedbpeffgffgnfofegmelgcfchefjhheaikehigeoifpejidmjoddkodkkjoallcilj" +
"dplbcgmjcnmpceniblniccokbjonbapjbhpennpfmeacbmaladbbakbkpacjaicipocalfdapmdjpdef" +
"pkeipbfcoifbopfpoggijngkoehfolhpicibojimnajpmhjbnojhmfknhmkomdlplkljlbmbhimklpme" +
"lgnglnnaleofllopfcpojjpojaackhackoahkfblfmbq";
            int seed = 7400187;
            string decodeMessage = StringDecoder.Decode(encodedString, seed);
            Console.WriteLine(decodeMessage);
        }
    }
}