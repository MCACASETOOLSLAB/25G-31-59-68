/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

import java.applet.Applet;

/**
 *
 * @author savita
 */
public class DiningApplet extends Applet {

    /**
     * Initialization method that will be called after the applet is loaded into
     * the browser.
     */private final Chopstick5[] chopsticks = new Chopstick5[5];

    /*Constructor for the main class
    * Creates all the chopsticks 
    * Creates and starts all the threads*/
    public DiningApplet(){
        putChopsticksOnTheTable();
        Thread t1 = new Thread(new Philosopher5("First",this.chopsticks[4],this.chopsticks[0]));
        Thread t2 = new Thread(new Philosopher5("Second",this.chopsticks[0],this.chopsticks[1]));
        Thread t3 = new Thread(new Philosopher5("Third",this.chopsticks[1],this.chopsticks[2]));
        Thread t4 = new Thread(new Philosopher5("Fourth",this.chopsticks[2],this.chopsticks[3]));
        Thread t5 = new Thread(new Philosopher5("Fifth",this.chopsticks[3],this.chopsticks[4]));
        t1.start();
        t2.start();
        t3.start();
        t4.start();
        t5.start();

}
    /*Initialise the chopsticks in the array*/
    private void putChopsticksOnTheTable(){
        for(int i = 0;i < chopsticks.length;i++) {
            chopsticks[i]= new Chopstick5();
        } 
    }

    /**
     *
     * @param args
     */
    public static void main(String[] args){
        new DiningApplet();
    }
    public void init() {
        // TODO start asynchronous download of heavy resources
    }
    // TODO overwrite start(), stop() and destroy() methods
}
