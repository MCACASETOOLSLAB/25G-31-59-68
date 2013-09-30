/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

import java.applet.Applet;

/**
 *
 * @author savita
 */
public class Chopstick5 extends Applet {private boolean _isUsed;

    /*
    * @return the current state of the chopstick
    */
    public boolean isUsed(){
        return _isUsed; 
    }

    /*
    * @param usedFlag the new state of the chopstick
    */
    public void setUsed(boolean usedFlag){
        _isUsed = usedFlag;
    }

    /**
     * Initialization method that will be called after the applet is loaded into
     * the browser.
     */
    public void init() {
        // TODO start asynchronous download of heavy resources
    }
    // TODO overwrite start(), stop() and destroy() methods
}
